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
using ScottPlot;
using ScottPlot.TickGenerators.Financial;
using ScottPlot.TickGenerators;
using ScottPlot.WinForms;
using ScottPlot.TickGenerators.TimeUnits;
using System.Globalization;

namespace SloManager
{
    public partial class ViewCharts : Form
    {

        bool chartBuilt = false;

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
            dbcontext.SLOs.OrderBy(SLO => SLO.SLO_ID).Load();
            sLOBindingSource.DataSource = dbcontext.SLOs.Local;
        }

        private void ViewCharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BuildChartButton_Click(object sender, EventArgs e)
        {
            FormsPlot1.Plot.Clear();
            FormsPlot1.Plot.Layout.Fixed(new PixelPadding(100, 50, 100, 50));

            int startYear = startDatePicker.Value.Year;
            int endYear = endDatePicker.Value.Year;

            if (startYear > endYear)
            {
                MessageBox.Show("Start year must be before or equal to end year.");
                return;
            }

            var selectedSLO = SloComboBox.SelectedItem as SlosClassLibrary.SLO;
            if (selectedSLO == null)
            {
                MessageBox.Show("Please select an SLO.");
                return;
            }

            // Get all measurements tied to the selected SLO
            var measurements = dbcontext.Measurements
                .Where(m => m.SLO_ID == selectedSLO.SLO_ID)
                .ToList();

            // Pull all scores within range for any of those measurements
            var measurementIds = measurements.Select(m => m.Measurement_ID).ToList(); 

            var scores = dbcontext.Scores
                .Where(s => s.Date.Year >= startYear &&
                            s.Date.Year <= endYear &&
                            measurementIds.Contains(s.Measurement_ID))
                .ToList();

            foreach (var measurement in measurements)
            {
                // Get all scores for this measurement
                var scoresForMeasurement = scores
                    .Where(s => s.Measurement_ID == measurement.Measurement_ID)
                    .GroupBy(s => s.Date.Year)
                    .OrderBy(g => g.Key)
                    .ToList();

                if (!scoresForMeasurement.Any())
                    continue; // skip if no data for this measurement

                double[] years = scoresForMeasurement.Select(g => (double)g.Key).ToArray();
                double[] avgScores = scoresForMeasurement.Select(g => (double)g.Average(s => s.Score_Val)).ToArray();

                // Plot actual scores
                var scoreLine = FormsPlot1.Plot.Add.Scatter(years, avgScores);
                scoreLine.LineWidth = 2;
                scoreLine.LegendText = measurement.Title;

                // custom tick labels, no commas in the year
                var tickGen = new NumericManual();
                foreach (var year in years)
                {
                    tickGen.AddMajor(year, year.ToString());
                }

                FormsPlot1.Plot.Axes.Bottom.TickGenerator = tickGen;

                // Plot target line (flat, across years)
                double[] targetLine = years.Select(y => (double)measurement.Target).ToArray();
                var targetLinePlot = FormsPlot1.Plot.Add.Scatter(years, targetLine);
                targetLinePlot.LegendText = $"{measurement.Title} Target";
                targetLinePlot.LinePattern = LinePattern.Dashed;
                targetLinePlot.LineWidth = 3;
                targetLinePlot.Color = scoreLine.Color;
            }

            
            // show labels and legends
            FormsPlot1.Plot.XLabel("Year");
            FormsPlot1.Plot.YLabel("Score");
            FormsPlot1.Plot.Title($"Measurement Trends for: {selectedSLO.Description}");
            FormsPlot1.Plot.ShowLegend();
            FormsPlot1.Plot.Axes.AutoScale();

            // set the data area to render inside a fixed rectangle
            PixelSize size = new PixelSize(700, 350);
            Pixel offset = new Pixel(50, 50);
            PixelRect rect = new PixelRect(size, offset);
            FormsPlot1.Plot.Layout.Fixed(rect);

            // update the chart
            FormsPlot1.Refresh();
            chartBuilt = true;
        }



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

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (chartBuilt)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png";
                    sfd.Title = "Save Chart As Image";
                    sfd.FileName = "SLO_Performance_Chart.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Save the plot as a PNG
                            FormsPlot1.Plot.SavePng(sfd.FileName, 800, 600);
                            MessageBox.Show("Chart saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to save chart:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please generate a chart first.", "Error",MessageBoxButtons.OK);
            }
        }
    }
}
