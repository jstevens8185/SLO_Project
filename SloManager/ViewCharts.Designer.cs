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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCharts));
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.navigationMenu1 = new SloManager.NavigationMenu();
            this.BuildChartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SloComboBox = new System.Windows.Forms.ComboBox();
            this.sLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SloSelectLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(269, 136);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(269, 22);
            this.startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(558, 134);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(265, 22);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(264, 101);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(99, 25);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Year";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(553, 101);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(93, 25);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Year";
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Margin = new System.Windows.Forms.Padding(5);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(1067, 38);
            this.navigationMenu1.TabIndex = 4;
            // 
            // BuildChartButton
            // 
            this.BuildChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildChartButton.Location = new System.Drawing.Point(857, 123);
            this.BuildChartButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildChartButton.Name = "BuildChartButton";
            this.BuildChartButton.Size = new System.Drawing.Size(137, 38);
            this.BuildChartButton.TabIndex = 5;
            this.BuildChartButton.Text = "Build Chart";
            this.BuildChartButton.UseVisualStyleBackColor = true;
            this.BuildChartButton.Click += new System.EventHandler(this.BuildChartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(59, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 511);
            this.panel1.TabIndex = 6;
            // 
            // SloComboBox
            // 
            this.SloComboBox.DataSource = this.sLOBindingSource;
            this.SloComboBox.DisplayMember = "Description";
            this.SloComboBox.FormattingEnabled = true;
            this.SloComboBox.Location = new System.Drawing.Point(59, 134);
            this.SloComboBox.Name = "SloComboBox";
            this.SloComboBox.Size = new System.Drawing.Size(193, 24);
            this.SloComboBox.TabIndex = 7;
            this.SloComboBox.ValueMember = "Description";
            // 
            // sLOBindingSource
            // 
            this.sLOBindingSource.DataSource = typeof(SlosClassLibrary.SLO);
            // 
            // SloSelectLabel
            // 
            this.SloSelectLabel.AutoSize = true;
            this.SloSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SloSelectLabel.Location = new System.Drawing.Point(54, 101);
            this.SloSelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SloSelectLabel.Name = "SloSelectLabel";
            this.SloSelectLabel.Size = new System.Drawing.Size(113, 25);
            this.SloSelectLabel.TabIndex = 8;
            this.SloSelectLabel.Text = "Select SLO";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(59, 47);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.Location = new System.Drawing.Point(847, 696);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(176, 41);
            this.DownloadButton.TabIndex = 10;
            this.DownloadButton.Text = "Download PNG";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ViewCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 758);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SloSelectLabel);
            this.Controls.Add(this.SloComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuildChartButton);
            this.Controls.Add(this.navigationMenu1);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewCharts";
            this.Text = "ViewCharts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCharts_FormClosed);
            this.Load += new System.EventHandler(this.ViewCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox SloComboBox;
        private System.Windows.Forms.BindingSource sLOBindingSource;
        private System.Windows.Forms.Label SloSelectLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DownloadButton;
    }
}