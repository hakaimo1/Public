namespace Ampersand.Forms
{
    partial class Batteries
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSwapOut = new System.Windows.Forms.Button();
            this.listBoxBatteries = new System.Windows.Forms.ListBox();
            this.batteriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Batteries";
            // 
            // buttonSwapOut
            // 
            this.buttonSwapOut.Location = new System.Drawing.Point(383, 220);
            this.buttonSwapOut.Name = "buttonSwapOut";
            this.buttonSwapOut.Size = new System.Drawing.Size(105, 41);
            this.buttonSwapOut.TabIndex = 2;
            this.buttonSwapOut.Text = "Swap Out";
            this.buttonSwapOut.UseVisualStyleBackColor = true;
            // 
            // listBoxBatteries
            // 
            this.listBoxBatteries.FormattingEnabled = true;
            this.listBoxBatteries.Location = new System.Drawing.Point(12, 59);
            this.listBoxBatteries.Name = "listBoxBatteries";
            this.listBoxBatteries.Size = new System.Drawing.Size(476, 147);
            this.listBoxBatteries.TabIndex = 3;
            this.listBoxBatteries.SelectedIndexChanged += new System.EventHandler(this.listBoxBatteries_SelectedIndexChanged);
            // 
            // batteriesBindingSource
            // 
            this.batteriesBindingSource.DataSource = typeof(Ampersand.Models.Batteries);
            // 
            // Batteries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 273);
            this.Controls.Add(this.listBoxBatteries);
            this.Controls.Add(this.buttonSwapOut);
            this.Controls.Add(this.label1);
            this.Name = "Batteries";
            this.Text = "BATTERIES";
            this.Load += new System.EventHandler(this.FormBatteries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSwapOut;
        private System.Windows.Forms.BindingSource batteriesBindingSource;
        private System.Windows.Forms.ListBox listBoxBatteries;
    }
}