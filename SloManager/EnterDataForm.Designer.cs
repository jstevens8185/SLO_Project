namespace SloManager
{
    partial class EnterDataForm
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.MetricLabel = new System.Windows.Forms.Label();
            this.MetricComboBox = new System.Windows.Forms.ComboBox();
            this.measurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SloSelectLabel = new System.Windows.Forms.Label();
            this.SloSelectComboBox = new System.Windows.Forms.ComboBox();
            this.sLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.navigationMenu1 = new SloManager.NavigationMenu();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(69, 366);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(69, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(587, 381);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(179, 23);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save All To Database";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(69, 250);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(88, 13);
            this.DataLabel.TabIndex = 20;
            this.DataLabel.Text = "Aggregate Grade";
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(69, 269);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataTextBox.TabIndex = 19;
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(69, 178);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(36, 13);
            this.MetricLabel.TabIndex = 18;
            this.MetricLabel.Text = "Metric";
            // 
            // MetricComboBox
            // 
            this.MetricComboBox.DataSource = this.measurementBindingSource;
            this.MetricComboBox.DisplayMember = "Title";
            this.MetricComboBox.FormattingEnabled = true;
            this.MetricComboBox.Location = new System.Drawing.Point(69, 199);
            this.MetricComboBox.Name = "MetricComboBox";
            this.MetricComboBox.Size = new System.Drawing.Size(216, 21);
            this.MetricComboBox.TabIndex = 17;
            this.MetricComboBox.ValueMember = "Description";
            // 
            // measurementBindingSource
            // 
            this.measurementBindingSource.DataSource = typeof(SlosClassLibrary.Measurement);
            // 
            // SloSelectLabel
            // 
            this.SloSelectLabel.AutoSize = true;
            this.SloSelectLabel.Location = new System.Drawing.Point(69, 109);
            this.SloSelectLabel.Name = "SloSelectLabel";
            this.SloSelectLabel.Size = new System.Drawing.Size(28, 13);
            this.SloSelectLabel.TabIndex = 16;
            this.SloSelectLabel.Text = "SLO";
            // 
            // SloSelectComboBox
            // 
            this.SloSelectComboBox.DataSource = this.sLOBindingSource;
            this.SloSelectComboBox.DisplayMember = "Title";
            this.SloSelectComboBox.FormattingEnabled = true;
            this.SloSelectComboBox.Location = new System.Drawing.Point(69, 134);
            this.SloSelectComboBox.Name = "SloSelectComboBox";
            this.SloSelectComboBox.Size = new System.Drawing.Size(216, 21);
            this.SloSelectComboBox.TabIndex = 15;
            this.SloSelectComboBox.ValueMember = "SLO_ID";
            this.SloSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.SloSelectComboBox_SelectedIndexChanged);
            // 
            // sLOBindingSource
            // 
            this.sLOBindingSource.DataSource = typeof(SlosClassLibrary.SLO);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(69, 39);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 14;
            this.YearLabel.Text = "Year";
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.YearComboBox.Location = new System.Drawing.Point(69, 62);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 21);
            this.YearComboBox.TabIndex = 13;
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(331, 39);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(435, 303);
            this.DataListBox.TabIndex = 24;
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(800, 31);
            this.navigationMenu1.TabIndex = 25;
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigationMenu1);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.MetricLabel);
            this.Controls.Add(this.MetricComboBox);
            this.Controls.Add(this.SloSelectLabel);
            this.Controls.Add(this.SloSelectComboBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearComboBox);
            this.Name = "EnterDataForm";
            this.Text = "EnterDataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterDataForm_FormClosed);
            this.Load += new System.EventHandler(this.EnterDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.ComboBox MetricComboBox;
        private System.Windows.Forms.Label SloSelectLabel;
        private System.Windows.Forms.ComboBox SloSelectComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.BindingSource sLOBindingSource;
        private System.Windows.Forms.BindingSource measurementBindingSource;
        private System.Windows.Forms.ListBox DataListBox;
        private NavigationMenu navigationMenu1;
    }
}