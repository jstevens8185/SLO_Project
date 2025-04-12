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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.EnterDataButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EditTargetsButton = new System.Windows.Forms.Button();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.navigationMenu1 = new SloManager.NavigationMenu();
            this.SuspendLayout();
            // 
            // EnterDataButton
            // 
            this.EnterDataButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDataButton.Location = new System.Drawing.Point(237, 80);
            this.EnterDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterDataButton.Name = "EnterDataButton";
            this.EnterDataButton.Size = new System.Drawing.Size(181, 68);
            this.EnterDataButton.TabIndex = 0;
            this.EnterDataButton.Text = "Enter Data";
            this.EnterDataButton.UseVisualStyleBackColor = true;
            this.EnterDataButton.Click += new System.EventHandler(this.EnterDataButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(237, 245);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(181, 68);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View Charts";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // EditTargetsButton
            // 
            this.EditTargetsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTargetsButton.Location = new System.Drawing.Point(648, 245);
            this.EditTargetsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditTargetsButton.Name = "EditTargetsButton";
            this.EditTargetsButton.Size = new System.Drawing.Size(181, 68);
            this.EditTargetsButton.TabIndex = 2;
            this.EditTargetsButton.Text = "Edit Targets";
            this.EditTargetsButton.UseVisualStyleBackColor = true;
            this.EditTargetsButton.Click += new System.EventHandler(this.ManageTargetsButton_Click);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDataButton.Location = new System.Drawing.Point(648, 80);
            this.ViewDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(181, 68);
            this.ViewDataButton.TabIndex = 3;
            this.ViewDataButton.Text = "View Data";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click);
            // 
            // navigationMenu1
            // 
            this.navigationMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu1.Margin = new System.Windows.Forms.Padding(5);
            this.navigationMenu1.Name = "navigationMenu1";
            this.navigationMenu1.Size = new System.Drawing.Size(1067, 28);
            this.navigationMenu1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.navigationMenu1);
            this.Controls.Add(this.ViewDataButton);
            this.Controls.Add(this.EditTargetsButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EnterDataButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterDataButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button EditTargetsButton;
        private System.Windows.Forms.Button ViewDataButton;
        private NavigationMenu navigationMenu1;
    }
}