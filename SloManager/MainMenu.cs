using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void EditSLOButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature isn't safe to use yet!");
            return;

            Form parentForm = this.FindForm();

            foreach (Form form in Application.OpenForms)
            {
                if (form is DataGridView)
                {
                    form.Show();
                    form.Activate();
                    parentForm?.Close();
                    return;
                }
            }

            DataGridView dataGridView = new DataGridView();
            dataGridView.Show();
            parentForm.Hide();
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
