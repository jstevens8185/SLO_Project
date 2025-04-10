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
    public partial class NavigationMenu : UserControl
    {
        public NavigationMenu()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    form.Close();
                    return;
                }
            }
        }

        private void viewChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form parentForm = this.FindForm();

            //if (parentForm is ViewForm)
            //{
            //    return;
            //}

            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form is ViewForm)
            //    {
            //        form.Show();
            //        form.Activate();
            //        parentForm?.Close();
            //        return;
            //    }
            //}

            //ViewForm viewForm = new ViewForm();
            //viewForm.Show();
            //parentForm.Visible = false;
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is ViewScores)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is ViewScores existingForm)
                {
                    existingForm.RefreshGrid();
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            ViewScores viewScores = new ViewScores();
            viewScores.Show();
            parentForm.Visible = false;
        }

        private void enterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is EnterDataForm)
            {
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is EnterDataForm)
                {
                    form.Show();
                    form.Activate();
                    parentForm.Visible = false;
                    return;
                }
            }

            EnterDataForm enterDataForm = new EnterDataForm();
            enterDataForm.Show();
            parentForm.Visible = false;
        }
    }
}

