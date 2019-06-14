using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoList
{
    public partial class Books : UserControl
    {
        int poss = 10;
        public Books()
        {
            InitializeComponent();
            getTargets();
        }
        public void addItem(string text)
        {
            ToDoItem item = new ToDoList.ToDoItem(text);
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

       
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            //add item button
            string tarName = textBox.Text;
            addItem(tarName);
            addTargets(tarName);
            textBox.Text = "";

        }
        void getTargets()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("select * from TargetTab where TargetID=2", SQL);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItem("" + reader["TargetText"]);
                    }
                }
            }
        }

        public void addTargets(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("insert into TargetTab(TargetText, TargetID), values('" + insert + "', '2')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }

    }
}
