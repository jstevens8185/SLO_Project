namespace SloManager
{
    partial class MainMenu
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
            this.EnterDataButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EditSLOButton = new System.Windows.Forms.Button();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.navigationMenu1 = new SloManager.NavigationMenu();
            this.SuspendLayout();
            // 
            // EnterDataButton
            // 
            this.EnterDataButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDataButton.Location = new System.Drawing.Point(178, 65);
            this.EnterDataButton.Name = "EnterDataButton";
            this.EnterDataButton.Size = new System.Drawing.Size(136, 55);
            this.EnterDataButton.TabIndex = 0;
            this.EnterDataButton.Text = "Enter Data";
            this.EnterDataButton.UseVisualStyleBackColor = true;
            this.EnterDataButton.Click += new System.EventHandler(this.EnterDataButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(178, 199);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(136, 55);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View Charts";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // EditSLOButton
            // 
            this.EditSLOButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSLOButton.Location = new System.Drawing.Point(486, 199);
            this.EditSLOButton.Name = "EditSLOButton";
            this.EditSLOButton.Size = new System.Drawing.Size(136, 55);
            this.EditSLOButton.TabIndex = 2;
            this.EditSLOButton.Text = "Edit SLOs";
            this.EditSLOButton.UseVisualStyleBackColor = true;
            this.EditSLOButton.Click += new System.EventHandler(this.EditSLOButton_Click);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDataButton.Location = new System.Drawing.Point(486, 65);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(136, 55);
            this.ViewDataButton.TabIndex = 3;
            this.ViewDataButton.Text = "View Data";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click);
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(800, 23);
            this.navigationMenu1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigationMenu1);
            this.Controls.Add(this.ViewDataButton);
            this.Controls.Add(this.EditSLOButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EnterDataButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterDataButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button EditSLOButton;
        private System.Windows.Forms.Button ViewDataButton;
        private NavigationMenu navigationMenu1;
    }
}