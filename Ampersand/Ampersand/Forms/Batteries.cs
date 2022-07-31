using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Ampersand.Forms
{
    public partial class Batteries : Form
    {
        List<Batteries> Battery = new List<Batteries>();
        public Batteries()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void FormBatteries_Load(object sender, EventArgs e)
        {
            LoadTheme();
            UpdateBinding();

        }
        private void UpdateBinding()
        {
            listBoxBatteries.DataSource = Battery;
            listBoxBatteries.DisplayMember = "fullBatteryInfo";
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void loadData()
        {
            DataAccess db = new DataAccess();
            Battery= db.GetBattery();
            UpdateBinding();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBoxBatteries_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
