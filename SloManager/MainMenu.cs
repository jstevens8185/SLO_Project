using System;
using System.Windows.Forms;

namespace SloManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EnterDataButton_Click(object sender, EventArgs e)
        {
            EnterDataForm enterData = new EnterDataForm();
            enterData.Show();
            this.Hide();
        }

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

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            ViewScores viewScores = new ViewScores();
            viewScores.Show();
            this.Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewCharts viewCharts = new ViewCharts();
            viewCharts.Show();
            this.Hide();
        }
    }
}
