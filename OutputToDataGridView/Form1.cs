using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OutputToDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string connStr = "server=localhost;user=root;database=univercity_catalog;password=1234321;";

            MySqlConnection myConnection = new MySqlConnection(connStr);

            myConnection.Open();

            string query = "SELECT * FROM faculty ORDER BY fac_id;";

            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
