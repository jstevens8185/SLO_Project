using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloManager
{
    public partial class ViewScores : Form
    {

        private SlosClassLibrary.SloDatabaseEntities dbcontext =
        new SlosClassLibrary.SloDatabaseEntities();

        public ViewScores()
        {
            InitializeComponent();
        }

        public void RefreshGrid()
        {
            LoadScoresIntoGrid();
        }

        private void ViewScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewScores_Load(object sender, EventArgs e)
        {
            LoadScoresIntoGrid();
        }

        private void LoadScoresIntoGrid()
        {
            var scoreList = dbcontext.Scores
                .Include(s => s.Measurement.SLO)
                .Select(s => new
                {
                    Score_ID = s.Score_Id, 
                    SLO_Title = s.Measurement.SLO.Description,
                    Measurement_Title = s.Measurement.Title, 
                    Score_Val = s.Score_Val,
                    Year = s.Date.Year
                })
                .ToList();


            ScoresDataGridView.DataSource = scoreList;

            // Hide score ID
            if (ScoresDataGridView.Columns.Contains("Score_ID"))
                ScoresDataGridView.Columns["Score_ID"].Visible = false;

            // Resize cells to fit all text
            if (ScoresDataGridView.Columns.Contains("SLO_Title"))
                ScoresDataGridView.Columns["SLO_Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Change Grid header text to be more readable
            if (ScoresDataGridView.Columns.Contains("SLO_Title"))
                ScoresDataGridView.Columns["SLO_Title"].HeaderText = "SLO Title";

            if (ScoresDataGridView.Columns.Contains("Measurement_Title"))
                ScoresDataGridView.Columns["Measurement_Title"].HeaderText = "Metric Title";

            if (ScoresDataGridView.Columns.Contains("Score_Val"))
                ScoresDataGridView.Columns["Score_Val"].HeaderText = "Score";

        }

        private void DeleteScoreButton_Click(object sender, EventArgs e)
        {
            if (ScoresDataGridView.SelectedRows.Count > 0)
            {
                // Grab the Score_ID from the selected row
                var selectedRow = ScoresDataGridView.SelectedRows[0];
                var scoreId = (int)selectedRow.Cells["Score_ID"].Value;

                // Find the score in the DB
                var scoreToDelete = dbcontext.Scores.FirstOrDefault(s => s.Score_Id == scoreId);

                if (scoreToDelete != null)
                {
                    var confirm = MessageBox.Show(
                        "Are you sure you want to delete this score?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        dbcontext.Scores.Remove(scoreToDelete);
                        dbcontext.SaveChanges();
                        LoadScoresIntoGrid(); // Refresh the grid
                        MessageBox.Show("Score deleted.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is MainMenu)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            parentForm.Visible = false;
        }

        private void SortScores(bool byYearFirst)
        {
            var sortedScores = dbcontext.Scores
                .Include(s => s.Measurement.SLO)
                .ToList();

            var scoreList = byYearFirst
                ? sortedScores
                    .OrderBy(s => s.Date.Year)
                    .ThenBy(s => s.Measurement.SLO.Description)
                    .Select(s => new
                    {
                        Score_ID = s.Score_Id,
                        SLO_Title = s.Measurement.SLO.Description,
                        Measurement_Title = s.Measurement.Title,
                        Score_Val = s.Score_Val,
                        Year = s.Date.Year
                    })
                    .ToList()
                : sortedScores
                    .OrderBy(s => s.Measurement.SLO.Description)
                    .ThenBy(s => s.Date.Year)
                    .Select(s => new
                    {
                        Score_ID = s.Score_Id,
                        SLO_Title = s.Measurement.SLO.Description,
                        Measurement_Title = s.Measurement.Title,
                        Score_Val = s.Score_Val,
                        Year = s.Date.Year
                    })
                    .ToList();

            ScoresDataGridView.DataSource = scoreList;
        }

        private void SortBySloButton_Click(object sender, EventArgs e)
        {
            SortScores(byYearFirst: false);
        }

        private void SortByYearButton_Click(object sender, EventArgs e)
        {
            SortScores(byYearFirst: true);
        }
    }
}
