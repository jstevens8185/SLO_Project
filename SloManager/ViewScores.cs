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
        Score_ID = s.Score_Id, // ← Confirm property name is Score_ID, not Score_Id
        SLO_Title = s.Measurement.SLO.Title,
        Measurement_Title = s.Measurement.Title, // ← Use Name if Title doesn't exist
        Score_Val = s.Score_Val,
        Year = s.Date.Year
    })
    .ToList();


            ScoresDataGridView.DataSource = scoreList;

            
            

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
    }
}
