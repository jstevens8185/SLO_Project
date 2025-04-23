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
    public partial class ManageTargets : Form
    {
        /******************************************************
         * Function Name: ManageTargets
         *
         * Parameters: None
         *
         * Return Type: void (Constructor)
         * 
         * Description: Initializes the ManageTargets form.
         *********************************************************/

        public ManageTargets()
        {
            InitializeComponent();
        }


        // Entity Framework database context for accessing SLO and measurement data
        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();


        /******************************************************
         * Function Name: BackButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Navigates back to the MainMenu form if it exists.
         * If it doesn't, creates a new MainMenu form and displays it.
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
         * Function Name: ManageTargets_FormClosed
         *
         * Parameters: object sender, FormClosedEventArgs e
         *
         * Return Type: void
         * 
         * Description: Closes the application if the ManageTargets form is closed.
         *********************************************************/

        private void ManageTargets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /******************************************************
         * Function Name: ManageTargets_Load
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Loads SLOs from the database into the ComboBox and
         * displays associated measurements in the DataGridView. Sets column
         * visibility and editability as needed.
         *********************************************************/

        private void ManageTargets_Load(object sender, EventArgs e)
        {
            // Load all SLOs into the ComboBox
            dbcontext.SLOs.Load();
            var sloList = dbcontext.SLOs.Local.ToList();

            SloComboBox.DataSource = sloList;
            SloComboBox.DisplayMember = "Description";
            SloComboBox.ValueMember = "SLO_ID";

            // Force selection of the first item
            if (sloList.Any())
            {
                SloComboBox.SelectedIndex = 0;

                int selectedSloID = sloList[0].SLO_ID;

                var measurements = dbcontext.Measurements
                    .Where(m => m.SLO_ID == selectedSloID)
                    .ToList();

                TargetsGridView.DataSource = measurements;

                // Hide irrelevant columns
                if (TargetsGridView.Columns.Contains("Measurement_ID"))
                    TargetsGridView.Columns["Measurement_ID"].Visible = false;

                if (TargetsGridView.Columns.Contains("SLO_ID"))
                    TargetsGridView.Columns["SLO_ID"].Visible = false;

                if (TargetsGridView.Columns.Contains("SLO"))
                    TargetsGridView.Columns["SLO"].Visible = false;

                if (TargetsGridView.Columns.Contains("Scores"))
                    TargetsGridView.Columns["Scores"].Visible = false;

                // Make only the Target column editable
                foreach (DataGridViewColumn col in TargetsGridView.Columns)
                    col.ReadOnly = col.Name != "Target";

                // Resize "Description" column to fit data
                if (TargetsGridView.Columns.Contains("Description"))
                    TargetsGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            }
            else
            {
                MessageBox.Show("No SLOs found in the database.");
            }
        }

        /******************************************************
         * Function Name: SloComboBox_SelectedIndexChanged
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Updates the DataGridView to show measurements associated
         * with the newly selected SLO in the ComboBox.
         *********************************************************/

        private void SloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SloComboBox.SelectedValue is int selectedSloId)
            {
                var measurements = dbcontext.Measurements
                    .Where(m => m.SLO_ID == selectedSloId)
                    .ToList();

                TargetsGridView.DataSource = measurements;

                // Hide unneeded columns
                TargetsGridView.Columns["Measurement_ID"].Visible = false;
                TargetsGridView.Columns["SLO_ID"].Visible = false;
                TargetsGridView.Columns["SLO"].Visible = false;

                // Optional: make only the Target column editable
                foreach (DataGridViewColumn col in TargetsGridView.Columns)
                    col.ReadOnly = col.Name != "Target";
            }
        }

        /******************************************************
         * Function Name: SaveButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Saves any changes made to the measurements in the DataGridView
         * to the database and notifies the user of the result.
         *********************************************************/

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbcontext.SaveChanges();
                MessageBox.Show("Targets updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }
    }
}
