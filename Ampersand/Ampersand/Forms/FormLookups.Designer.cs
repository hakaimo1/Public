namespace Ampersand.Forms
{
    partial class FormLookups
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxBatteryDetails = new System.Windows.Forms.TextBox();
            this.batteriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBatteryName = new System.Windows.Forms.TextBox();
            this.batteriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBatteryNumber = new System.Windows.Forms.TextBox();
            this.batteriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDriverDetails = new System.Windows.Forms.TextBox();
            this.driversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDriverNames = new System.Windows.Forms.TextBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lookups";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 243);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxBatteryDetails);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxBatteryName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxBatteryNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Batteries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxBatteryDetails
            // 
            this.textBoxBatteryDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batteriesBindingSource2, "batteryDetails", true));
            this.textBoxBatteryDetails.Location = new System.Drawing.Point(131, 120);
            this.textBoxBatteryDetails.Name = "textBoxBatteryDetails";
            this.textBoxBatteryDetails.Size = new System.Drawing.Size(252, 20);
            this.textBoxBatteryDetails.TabIndex = 6;
            // 
            // batteriesBindingSource2
            // 
            this.batteriesBindingSource2.DataSource = typeof(Ampersand.Models.Batteries);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Other Details";
            // 
            // textBoxBatteryName
            // 
            this.textBoxBatteryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batteriesBindingSource1, "batteryName", true));
            this.textBoxBatteryName.Location = new System.Drawing.Point(131, 75);
            this.textBoxBatteryName.Name = "textBoxBatteryName";
            this.textBoxBatteryName.Size = new System.Drawing.Size(252, 20);
            this.textBoxBatteryName.TabIndex = 4;
            // 
            // batteriesBindingSource1
            // 
            this.batteriesBindingSource1.DataSource = typeof(Ampersand.Models.Batteries);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Battery Name";
            // 
            // textBoxBatteryNumber
            // 
            this.textBoxBatteryNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batteriesBindingSource, "batteryNumber", true));
            this.textBoxBatteryNumber.Location = new System.Drawing.Point(131, 33);
            this.textBoxBatteryNumber.Name = "textBoxBatteryNumber";
            this.textBoxBatteryNumber.Size = new System.Drawing.Size(252, 20);
            this.textBoxBatteryNumber.TabIndex = 2;
            // 
            // batteriesBindingSource
            // 
            this.batteriesBindingSource.DataSource = typeof(Ampersand.Models.Batteries);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Battery Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxDriverDetails);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxDriverNames);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drivers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Other Details";
            // 
            // textBoxDriverDetails
            // 
            this.textBoxDriverDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource1, "driverDetails", true));
            this.textBoxDriverDetails.Location = new System.Drawing.Point(103, 70);
            this.textBoxDriverDetails.Name = "textBoxDriverDetails";
            this.textBoxDriverDetails.Size = new System.Drawing.Size(295, 20);
            this.textBoxDriverDetails.TabIndex = 3;
            // 
            // driversBindingSource1
            // 
            this.driversBindingSource1.DataSource = typeof(Ampersand.Models.Drivers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Names";
            // 
            // textBoxDriverNames
            // 
            this.textBoxDriverNames.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "driverNames", true));
            this.textBoxDriverNames.Location = new System.Drawing.Point(103, 29);
            this.textBoxDriverNames.Name = "textBoxDriverNames";
            this.textBoxDriverNames.Size = new System.Drawing.Size(295, 20);
            this.textBoxDriverNames.TabIndex = 1;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(Ampersand.Models.Drivers);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 217);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Motorcycle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Driver 1",
            "Driver 2",
            "Driver 3",
            "Driver 4",
            "Driver 5"});
            this.comboBox1.Location = new System.Drawing.Point(145, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Driver";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Motocycle Details";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(460, 217);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Station";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationsBindingSource1, "stationAddress", true));
            this.textBox3.Location = new System.Drawing.Point(116, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 20);
            this.textBox3.TabIndex = 4;
            // 
            // stationsBindingSource1
            // 
            this.stationsBindingSource1.DataSource = typeof(Ampersand.Models.Stations);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Station Address";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationsBindingSource, "stationName", true));
            this.textBox2.Location = new System.Drawing.Point(116, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 20);
            this.textBox2.TabIndex = 2;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataSource = typeof(Ampersand.Models.Stations);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Station Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormLookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 300);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormLookups";
            this.Text = "LOOK UP LIST";
            this.Load += new System.EventHandler(this.FormLookups_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxBatteryDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBatteryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBatteryNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDriverDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDriverNames;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource batteriesBindingSource2;
        private System.Windows.Forms.BindingSource batteriesBindingSource1;
        private System.Windows.Forms.BindingSource batteriesBindingSource;
        private System.Windows.Forms.BindingSource driversBindingSource1;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.BindingSource stationsBindingSource1;
        private System.Windows.Forms.BindingSource stationsBindingSource;
    }
}