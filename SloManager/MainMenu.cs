using System;
using System.Windows.Forms;

namespace SloManager
{
    public partial class MainMenu : Form
    {

        /******************************************************
         * Function Name: MainMenu
         *
         * Parameters: None
         *
         * Return Type: void (Constructor)
         * 
         * Description: Initializes the main menu form.
         *********************************************************/

        public MainMenu()
        {
            InitializeComponent();
        }


        /******************************************************
         * Function Name: EnterDataButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Opens the EnterDataForm and hides the main menu.
         *********************************************************/

        private void EnterDataButton_Click(object sender, EventArgs e)
        {
            EnterDataForm enterData = new EnterDataForm();
            enterData.Show();
            this.Hide();
        }


        /******************************************************
         * Function Name: ManageTargetsButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Opens the ManageTargets form. If already open,
         * brings it to the front and hides the main menu.
         *********************************************************/

        private void ManageTargetsButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is ManageTargets)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is ManageTargets)
                {
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            ManageTargets manageTargetsForm = new ManageTargets();
            manageTargetsForm.Show();
            parentForm.Visible = false;
        }


        /******************************************************
         * Function Name: ViewDataButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Opens the ViewScores form and hides the main menu.
         *********************************************************/

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            ViewScores viewScores = new ViewScores();
            viewScores.Show();
            this.Hide();
        }


        /******************************************************
         * Function Name: ViewButton_Click
         *
         * Parameters: object sender, EventArgs e
         *
         * Return Type: void
         * 
         * Description: Opens the ViewCharts form and hides the main menu.
         *********************************************************/

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewCharts viewCharts = new ViewCharts();
            viewCharts.Show();
            this.Hide();
        }
    }
}
