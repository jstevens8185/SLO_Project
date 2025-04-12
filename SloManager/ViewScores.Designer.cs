namespace SloManager
{
    partial class ViewScores
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
            this.navigationMenu1 = new SloManager.NavigationMenu();
            this.ScoresDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteScoreButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SortBySloButton = new System.Windows.Forms.Button();
            this.SortByYearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(1067, 38);
            this.navigationMenu1.TabIndex = 1;
            // 
            // ScoresDataGridView
            // 
            this.ScoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoresDataGridView.Location = new System.Drawing.Point(108, 196);
            this.ScoresDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoresDataGridView.Name = "ScoresDataGridView";
            this.ScoresDataGridView.RowHeadersWidth = 51;
            this.ScoresDataGridView.Size = new System.Drawing.Size(841, 250);
            this.ScoresDataGridView.TabIndex = 2;
            // 
            // DeleteScoreButton
            // 
            this.DeleteScoreButton.Location = new System.Drawing.Point(785, 473);
            this.DeleteScoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteScoreButton.Name = "DeleteScoreButton";
            this.DeleteScoreButton.Size = new System.Drawing.Size(163, 36);
            this.DeleteScoreButton.TabIndex = 3;
            this.DeleteScoreButton.Text = "Delete";
            this.DeleteScoreButton.UseVisualStyleBackColor = true;
            this.DeleteScoreButton.Click += new System.EventHandler(this.DeleteScoreButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(40, 47);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 38);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SortBySloButton
            // 
            this.SortBySloButton.Location = new System.Drawing.Point(108, 473);
            this.SortBySloButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortBySloButton.Name = "SortBySloButton";
            this.SortBySloButton.Size = new System.Drawing.Size(163, 36);
            this.SortBySloButton.TabIndex = 5;
            this.SortBySloButton.Text = "Sort By SLO";
            this.SortBySloButton.UseVisualStyleBackColor = true;
            this.SortBySloButton.Click += new System.EventHandler(this.SortBySloButton_Click);
            // 
            // SortByYearButton
            // 
            this.SortByYearButton.Location = new System.Drawing.Point(454, 473);
            this.SortByYearButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortByYearButton.Name = "SortByYearButton";
            this.SortByYearButton.Size = new System.Drawing.Size(163, 36);
            this.SortByYearButton.TabIndex = 6;
            this.SortByYearButton.Text = "Sort By Year";
            this.SortByYearButton.UseVisualStyleBackColor = true;
            this.SortByYearButton.Click += new System.EventHandler(this.SortByYearButton_Click);
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SortByYearButton);
            this.Controls.Add(this.SortBySloButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteScoreButton);
            this.Controls.Add(this.ScoresDataGridView);
            this.Controls.Add(this.navigationMenu1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewScores";
            this.Text = "ViewScores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewScores_FormClosed);
            this.Load += new System.EventHandler(this.ViewScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NavigationMenu navigationMenu1;
        private System.Windows.Forms.DataGridView ScoresDataGridView;
        private System.Windows.Forms.Button DeleteScoreButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SortBySloButton;
        private System.Windows.Forms.Button SortByYearButton;
    }
}