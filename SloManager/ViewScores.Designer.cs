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
            ((System.ComponentModel.ISupportInitialize)(this.ScoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(800, 31);
            this.navigationMenu1.TabIndex = 1;
            // 
            // ScoresDataGridView
            // 
            this.ScoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoresDataGridView.Location = new System.Drawing.Point(81, 159);
            this.ScoresDataGridView.Name = "ScoresDataGridView";
            this.ScoresDataGridView.Size = new System.Drawing.Size(631, 203);
            this.ScoresDataGridView.TabIndex = 2;
            // 
            // DeleteScoreButton
            // 
            this.DeleteScoreButton.Location = new System.Drawing.Point(589, 384);
            this.DeleteScoreButton.Name = "DeleteScoreButton";
            this.DeleteScoreButton.Size = new System.Drawing.Size(122, 29);
            this.DeleteScoreButton.TabIndex = 3;
            this.DeleteScoreButton.Text = "Delete";
            this.DeleteScoreButton.UseVisualStyleBackColor = true;
            this.DeleteScoreButton.Click += new System.EventHandler(this.DeleteScoreButton_Click);
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteScoreButton);
            this.Controls.Add(this.ScoresDataGridView);
            this.Controls.Add(this.navigationMenu1);
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
    }
}