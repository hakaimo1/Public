namespace Ampersand
{
    partial class Dashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTelematics = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonPricing = new System.Windows.Forms.Button();
            this.buttonBatteries = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonTelematics);
            this.panelMenu.Controls.Add(this.buttonUsers);
            this.panelMenu.Controls.Add(this.buttonPricing);
            this.panelMenu.Controls.Add(this.buttonBatteries);
            this.panelMenu.Controls.Add(this.buttonSwap);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(181, 507);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(181, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(512, 53);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(217, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(181, 53);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(512, 454);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Ampersand.Properties.Resources.lookup_small;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 403);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(181, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = " Lookups";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTelematics
            // 
            this.buttonTelematics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonTelematics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTelematics.FlatAppearance.BorderSize = 0;
            this.buttonTelematics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelematics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTelematics.ForeColor = System.Drawing.Color.White;
            this.buttonTelematics.Image = global::Ampersand.Properties.Resources.Telematic_small;
            this.buttonTelematics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTelematics.Location = new System.Drawing.Point(0, 333);
            this.buttonTelematics.Name = "buttonTelematics";
            this.buttonTelematics.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonTelematics.Size = new System.Drawing.Size(181, 70);
            this.buttonTelematics.TabIndex = 5;
            this.buttonTelematics.Text = "     Telematics";
            this.buttonTelematics.UseVisualStyleBackColor = false;
            this.buttonTelematics.Click += new System.EventHandler(this.buttonTelematics_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.Image = global::Ampersand.Properties.Resources.Users_small;
            this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.Location = new System.Drawing.Point(0, 263);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonUsers.Size = new System.Drawing.Size(181, 70);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonPricing
            // 
            this.buttonPricing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonPricing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPricing.FlatAppearance.BorderSize = 0;
            this.buttonPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPricing.ForeColor = System.Drawing.Color.White;
            this.buttonPricing.Image = global::Ampersand.Properties.Resources.Pricing_small;
            this.buttonPricing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPricing.Location = new System.Drawing.Point(0, 193);
            this.buttonPricing.Name = "buttonPricing";
            this.buttonPricing.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonPricing.Size = new System.Drawing.Size(181, 70);
            this.buttonPricing.TabIndex = 3;
            this.buttonPricing.Text = "  Pricing";
            this.buttonPricing.UseVisualStyleBackColor = false;
            this.buttonPricing.Click += new System.EventHandler(this.buttonPricing_Click);
            // 
            // buttonBatteries
            // 
            this.buttonBatteries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonBatteries.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBatteries.FlatAppearance.BorderSize = 0;
            this.buttonBatteries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBatteries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatteries.ForeColor = System.Drawing.Color.White;
            this.buttonBatteries.Image = global::Ampersand.Properties.Resources.Battery_small;
            this.buttonBatteries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBatteries.Location = new System.Drawing.Point(0, 123);
            this.buttonBatteries.Name = "buttonBatteries";
            this.buttonBatteries.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonBatteries.Size = new System.Drawing.Size(181, 70);
            this.buttonBatteries.TabIndex = 2;
            this.buttonBatteries.Text = "   Batteries";
            this.buttonBatteries.UseVisualStyleBackColor = false;
            this.buttonBatteries.Click += new System.EventHandler(this.buttonBatteries_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonSwap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSwap.FlatAppearance.BorderSize = 0;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwap.ForeColor = System.Drawing.Color.White;
            this.buttonSwap.Image = global::Ampersand.Properties.Resources.swap_small;
            this.buttonSwap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSwap.Location = new System.Drawing.Point(0, 53);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonSwap.Size = new System.Drawing.Size(181, 70);
            this.buttonSwap.TabIndex = 1;
            this.buttonSwap.Text = "Swap In";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.BackgroundImage = global::Ampersand.Properties.Resources.Ampersand_logo;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(181, 53);
            this.panelLogo.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 507);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonPricing;
        private System.Windows.Forms.Button buttonBatteries;
        private System.Windows.Forms.Button buttonTelematics;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button button1;
    }
}