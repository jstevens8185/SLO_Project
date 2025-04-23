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
        // Entity Framework database context for accessing SLO-related score data
        private SlosClassLibrary.SloDatabaseEntities dbcontext =
        new SlosClassLibrary.SloDatabaseEntities();


        /******************************************************
         * Function Name: ViewScores
         *
         * Parameters: None
         *
         * Return Type: void (Constructor)
         * 
         * Description: Initializes the ViewScores form.
         *********************************************************/

        public ViewScores()
        {
            InitializeComponent();
        }


        /******************************************************
         * Function Name: RefreshGrid
         *
         * Parameters: None
         *
         * Return Type: void
         * 
         * Description: Public method to reload the scores into the DataGridView.
         *********************************************************/

        public void RefreshGrid()
        {
            LoadScoresIntoGrid();
        }


        /******************************************************
         * Function Name: ViewScores_FormClosed
         *
         * Parameters: object sender, FormClosedEventArgs e
         *
         * Return Type: void
         * 
         * Description: Exits the application when the form is closed.
         *********************************************************/

        private void ViewScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /******************************************************
         * Function Name: ViewScores_Load
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Loads score data into the grid when the form is loaded.
         *********************************************************/

        private void ViewScores_Load(object sender, EventArgs e)
        {
            LoadScoresIntoGrid();
        }


        /******************************************************
         * Function Name: LoadScoresIntoGrid
         *
         * Parameters: None
         *
         * Return Type: void
         * 
         * Description: Fetches score records from the database, projects them
         * into a simplified view model, and binds the result to the DataGridView.
         * Also updates visibility, auto-sizing, and column headers.
         *********************************************************/

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


        /******************************************************
         * Function Name: DeleteScoreButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Deletes the selected score from the database
         * after confirming with the user, then reloads the grid.
         *********************************************************/

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


        /******************************************************
         * Function Name: BackButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Navigates back to the MainMenu form. If not open,
         * creates a new instance of MainMenu and displays it.
         *********************************************************/

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


        /******************************************************
         * Function Name: SortScores
         *
         * Parameters: bool byYearFirst
         *
         * Return Type: void
         * 
         * Description: Sorts scores either by year first then SLO,
         * or by SLO first then year, and updates the DataGridView.
         *********************************************************/

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


        /******************************************************
         * Function Name: SortBySloButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Handles click event for sorting by SLO title first.
         *********************************************************/

        private void SortBySloButton_Click(object sender, EventArgs e)
        {
            SortScores(byYearFirst: false);
        }


        /******************************************************
         * Function Name: SortByYearButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Handles click event for sorting by year first.
         *********************************************************/

        private void SortByYearButton_Click(object sender, EventArgs e)
        {
            SortScores(byYearFirst: true);
        }
    }
}
