namespace SloManager
{
    partial class ViewCharts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.navigationMenu1 = new SloManager.NavigationMenu();
            this.BuildChartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(45, 62);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(547, 62);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(41, 38);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(82, 20);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Year";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(543, 38);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(76, 20);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Year";
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(800, 31);
            this.navigationMenu1.TabIndex = 4;
            // 
            // BuildChartButton
            // 
            this.BuildChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildChartButton.Location = new System.Drawing.Point(45, 89);
            this.BuildChartButton.Name = "BuildChartButton";
            this.BuildChartButton.Size = new System.Drawing.Size(103, 31);
            this.BuildChartButton.TabIndex = 5;
            this.BuildChartButton.Text = "Build Chart";
            this.BuildChartButton.UseVisualStyleBackColor = true;
            this.BuildChartButton.Click += new System.EventHandler(this.BuildChartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 415);
            this.panel1.TabIndex = 6;
            // 
            // ViewCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuildChartButton);
            this.Controls.Add(this.navigationMenu1);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Name = "ViewCharts";
            this.Text = "ViewCharts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCharts_FormClosed);
            this.Load += new System.EventHandler(this.ViewCharts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private NavigationMenu navigationMenu1;
        private System.Windows.Forms.Button BuildChartButton;
        private System.Windows.Forms.Panel panel1;
    }
}