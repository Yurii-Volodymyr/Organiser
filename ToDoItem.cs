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
    public partial class ToDoItem : UserControl
    {
        public ToDoItem()
        {
            InitializeComponent();
        }
        public ToDoItem(string text)
        {
            InitializeComponent();
            lbl.Text = text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("delete from TargetTab where TargetID = '" + lbl.Text +"'", SQL);
                command.ExecuteNonQuery();
                
            }
            this.BackColor = Color.FromArgb(40, 177, 231);
            lbl.Text = "deleted";
        }
    }
}
