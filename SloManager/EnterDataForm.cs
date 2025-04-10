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
        public EnterDataForm()
        {
            InitializeComponent();
        }

        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();

        private void EnterDataForm_Load(object sender, EventArgs e)
        {
            dbcontext.SLOs.OrderBy(SLO => SLO.SLO_ID).Load();
            sLOBindingSource.DataSource = dbcontext.SLOs.Local;

            dbcontext.Measurements.Load();
            measurementBindingSource.DataSource = dbcontext.Measurements.Local;
            SloSelectComboBox_SelectedIndexChanged(null, null);

        }


        public class PendingScore
        {
            public string SLO_Description { get; set; }
            public int Measure_ID { get; set; }
            public string Measure_Name { get; set; }
            public int Grade_Value { get; set; }
            public DateTime Date { get; set; }

            public override string ToString()
            {
                return $"SLO: {SLO_Description} | Metric: {Measure_Name} | Grade: {Grade_Value} | Year: {Date.Year}";
            }
        }

        private void EnterDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

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
                MetricComboBox.DisplayMember = "Name";         // Use the correct property name
                MetricComboBox.ValueMember = "Measurement_ID"; // Use the correct key name
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MetricComboBox.SelectedValue is int selectedMeasureId &&
         int.TryParse(DataTextBox.Text, out int gradeValue) &&
         SloSelectComboBox.SelectedItem is SlosClassLibrary.SLO selectedSLO &&
         MetricComboBox.SelectedItem is SlosClassLibrary.Measurement selectedMeasurement)
            {
                var pending = new PendingScore
                {
                    SLO_Description = selectedSLO.Description,
                    Measure_ID = selectedMeasureId,
                    Measure_Name = selectedMeasurement.Title,
                    Grade_Value = gradeValue,
                    Date = DateTime.Now
                };

                DataListBox.Items.Add(pending);
                DataTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Make sure all fields are filled out correctly.");
            }
        }

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
    }
}
