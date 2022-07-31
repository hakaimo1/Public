using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ampersand.Forms
{
    public partial class FormSwapIn : Form
    {
        public FormSwapIn()
        {
            InitializeComponent();
            textBox3.Validated += TextBox3_Validated;
            
        }

        private void TextBox3_Validated(object sender, EventArgs e)
        {
            int reading = Convert.ToInt32(textBox3.Text);
            var connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            var conn = new SqlConnection(connstr);
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetPrice";
            cmd.Parameters.Add(new SqlParameter("Reading", reading));

            conn.Open();
            var value = cmd.ExecuteScalar();
            var amount = 0M;
            if (value != null)
            {
                amount = Convert.ToDecimal(value);
            }

            conn.Close();

            textBox4.Text = amount.ToString();
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

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSwapIn_Load(object sender, EventArgs e)
        {
            LoadTheme();
          
            var connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            var conn = new SqlConnection(connstr);
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetBatteries";

            conn.Open();
            var dr =cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["BatteryNumber"]);
            }

            dr.Close();
            





        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
