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
using ScottPlot.WinForms;

namespace SloManager
{
    public partial class ViewCharts : Form
    {

        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };
        public ViewCharts()
        {
            InitializeComponent();
            panel1.Controls.Add(FormsPlot1);

            FormsPlot1.Plot.XLabel("Year");
            FormsPlot1.Plot.YLabel("Grade");
            FormsPlot1.Plot.Title("Performance Data");
            FormsPlot1.Refresh();

        }

        private SlosClassLibrary.SloDatabaseEntities dbcontext =
            new SlosClassLibrary.SloDatabaseEntities();

        private void ViewCharts_Load(object sender, EventArgs e)
        {
            startDatePicker.CustomFormat = "yyyy";
            startDatePicker.ShowUpDown = true;
            endDatePicker.CustomFormat = "yyyy";
            endDatePicker.ShowUpDown = true;
        }

        private void ViewCharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BuildChartButton_Click(object sender, EventArgs e)
        {
            FormsPlot1.Plot.Clear();
            int startYear = startDatePicker.Value.Year;
            int endYear = endDatePicker.Value.Year;

            if (startYear > endYear)
            {
                MessageBox.Show("Start year must be before or equal to end year.");
                return;
            }

            // Create actual date range
            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);

            var scoresInRange = dbcontext.Scores
                .Include(s => s.Measurement.SLO)
                .Where(s => s.Date >= startDate && s.Date <= endDate)
                .ToList();

        }
    }
}
