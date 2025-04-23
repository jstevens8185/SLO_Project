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
using SlosClassLibrary;


namespace SloManager
{
    public partial class EnterDataForm : Form
    {

        /******************************************************
         * Function Name: EnterDataForm
         *
         * Parameters: None
         *
         * Return Type: void (Constructor)
         * 
         * Description: Initializes the EnterDataForm.
         *********************************************************/
        public EnterDataForm()
        {
            InitializeComponent();
        }

        // Entity Framework database context for accessing SLO and measurement data
        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();

        private void EnterDataForm_Load(object sender, EventArgs e)
        {


        }


        /******************************************************
         * Class Name: PendingScore
         *
         * Description: Represents a temporary score entry to be saved.
         * Used for displaying pending data before saving to the database.
         *********************************************************/

        public class PendingScore
        {
            public string SLO_Description { get; set; }
            public int Measure_ID { get; set; }
            public string Measure_Name { get; set; }
            public decimal Grade_Value { get; set; }
            public DateTime Date { get; set; }

            public override string ToString()
            {
                return $"SLO: {SLO_Description} | Metric: {Measure_Name} | Grade: {Grade_Value} | Year: {Date.Year}";
            }
        }


        /******************************************************
         * Function Name: EnterDataForm_FormClosed
         *
         * Parameters: object sender, FormClosedEventArgs e
         *
         * Return Type: void
         * 
         * Description: Exits the application when the form is closed.
         *********************************************************/

        private void EnterDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /******************************************************
         * Function Name: SloSelectComboBox_SelectedIndexChanged
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Filters the MetricComboBox based on the selected SLO
         * to show only related measurements.
         *********************************************************/

        private void SloSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SloSelectComboBox.SelectedValue is int selectedSloId)
            {
                // Filter the measurements based on selected SLO_ID
                var filteredMeasurements = dbcontext.Measurements
                    .Local
                    .Where(m => m.SLO_ID == selectedSloId)
                    .ToList();

                MetricComboBox.DataSource = filteredMeasurements;
                MetricComboBox.DisplayMember = "Name";
                MetricComboBox.ValueMember = "Measurement_ID";
            }
        }



        /******************************************************
         * Function Name: AddButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Validates and adds a new PendingScore to the list.
         * Ensures all fields are correctly filled before adding.
         *********************************************************/

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MetricComboBox.SelectedValue is int selectedMeasureId &&
         decimal.TryParse(DataTextBox.Text, out decimal gradeValue) &&
         SloSelectComboBox.SelectedItem is SlosClassLibrary.SLO selectedSLO &&
         MetricComboBox.SelectedItem is SlosClassLibrary.Measurement selectedMeasurement &&
         int.TryParse(YearComboBox.Text, out int selectedYear))
            {
                var pending = new PendingScore
                {
                    SLO_Description = selectedSLO.Description,
                    Measure_ID = selectedMeasureId,
                    Measure_Name = selectedMeasurement.Title,
                    Grade_Value = gradeValue,
                    Date = new DateTime(selectedYear, 1, 1)
                };

                DataListBox.Items.Add(pending);
                DataTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Make sure all fields are filled out correctly.");
            }
        }


        /******************************************************
         * Function Name: RemoveButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Removes the selected PendingScore from the list.
         *********************************************************/

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DataListBox.SelectedItem != null)
            {
                DataListBox.Items.Remove(DataListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }


        /******************************************************
         * Function Name: SaveButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Saves all PendingScores in the list to the database
         * as Score records. Displays a success or error message.
         *********************************************************/

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DataListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no scores to save.");
                return;
            }

            try
            {
                foreach (PendingScore pending in DataListBox.Items)
                {
                    var newScore = new SlosClassLibrary.Score
                    {
                        Measurement_ID = pending.Measure_ID,
                        Score_Val = pending.Grade_Value,
                        Date = pending.Date
                    };

                    dbcontext.Scores.Add(newScore);
                }

                dbcontext.SaveChanges();
                DataListBox.Items.Clear();
                MessageBox.Show("All scores have been saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving scores: {ex.Message}");
            }
        }


        /******************************************************
         * Function Name: BackButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Navigates back to MainMenu. If it's not open,
         * creates a new instance and opens it.
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
         * Function Name: EnterDataForm_Shown
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Loads database content into the form when it's first shown.
         *********************************************************/

        private void EnterDataForm_Shown(object sender, EventArgs e)
        {
            loadDB();
        }


        /******************************************************
         * Function Name: loadDB
         *
         * Parameters: None
         *
         * Return Type: async Task (void-like)
         * 
         * Description: Asynchronously loads SLO and Measurement data from the
         * database and binds them to their respective data sources. Also sets
         * the YearComboBox to the current year.
         *********************************************************/

        private async void loadDB()
        {

            DateTime date = DateTime.Now;
            await dbcontext.SLOs.OrderBy(SLO => SLO.SLO_ID).LoadAsync();
            sLOBindingSource.DataSource = dbcontext.SLOs.Local;

            
            await dbcontext.Measurements.LoadAsync();
            measurementBindingSource.DataSource = dbcontext.Measurements.Local;
            SloSelectComboBox_SelectedIndexChanged(null, null);

            YearComboBox.SelectedItem = date.Year.ToString();
        } 
    }
}
