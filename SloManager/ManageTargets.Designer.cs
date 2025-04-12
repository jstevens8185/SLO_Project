namespace SloManager
{
    partial class ManageTargets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTargets));
            this.SloComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectSloLabel = new System.Windows.Forms.Label();
            this.TargetsGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditHelpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TargetsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SloComboBox
            // 
            this.SloComboBox.FormattingEnabled = true;
            this.SloComboBox.Location = new System.Drawing.Point(66, 140);
            this.SloComboBox.Name = "SloComboBox";
            this.SloComboBox.Size = new System.Drawing.Size(208, 25);
            this.SloComboBox.TabIndex = 0;
            this.SloComboBox.SelectedIndexChanged += new System.EventHandler(this.SloComboBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(66, 42);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 37);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Previous Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectSloLabel
            // 
            this.SelectSloLabel.AutoSize = true;
            this.SelectSloLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSloLabel.Location = new System.Drawing.Point(62, 109);
            this.SelectSloLabel.Name = "SelectSloLabel";
            this.SelectSloLabel.Size = new System.Drawing.Size(111, 23);
            this.SelectSloLabel.TabIndex = 2;
            this.SelectSloLabel.Text = "Select SLO";
            // 
            // TargetsGridView
            // 
            this.TargetsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TargetsGridView.Location = new System.Drawing.Point(66, 239);
            this.TargetsGridView.Name = "TargetsGridView";
            this.TargetsGridView.RowHeadersWidth = 51;
            this.TargetsGridView.RowTemplate.Height = 24;
            this.TargetsGridView.Size = new System.Drawing.Size(769, 159);
            this.TargetsGridView.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(66, 435);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 38);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditHelpLabel
            // 
            this.EditHelpLabel.AutoSize = true;
            this.EditHelpLabel.Location = new System.Drawing.Point(66, 217);
            this.EditHelpLabel.Name = "EditHelpLabel";
            this.EditHelpLabel.Size = new System.Drawing.Size(171, 17);
            this.EditHelpLabel.TabIndex = 5;
            this.EditHelpLabel.Text = "Double click target to edit";
            // 
            // ManageTargets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 652);
            this.Controls.Add(this.EditHelpLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TargetsGridView);
            this.Controls.Add(this.SelectSloLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SloComboBox);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTargets";
            this.Text = "Manage Targets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageTargets_FormClosed);
            this.Load += new System.EventHandler(this.ManageTargets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TargetsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SloComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SelectSloLabel;
        private System.Windows.Forms.DataGridView TargetsGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label EditHelpLabel;
    }
}