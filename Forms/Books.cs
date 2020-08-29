﻿using System;
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
    /// <summary>
    /// klasa z formy "User Control" dla dodawania nowych "items "
    /// </summary>
    public partial class Books : UserControl
    {
        int poss = 10;
        public Books()
        {
            InitializeComponent();
            getTargets();
        }
        /// <summary>
        /// zmieszcza na 10 pkt nowy item do dolu przy kliknieciu na "+"
        /// </summary>
        /// <param name="text"></param>
        public void addItem(string text)
        {
            ToDoItem item = new ToDoList.ToDoItem(text);
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

       /// <summary>
       /// dodawanie nowego item
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            //add item button
            string tarName = textBox.Text;
            addItem(tarName);
            addTargets(tarName);
            textBox.Text = "";

        }
        /// <summary>
        /// podlaczenie SQL 
        /// otrzymanie nowego zadania od uzytkownika
        /// </summary>
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
        /// <summary>
        /// zapisywanie nowego zadania 
        /// </summary>
        /// <param name="insert"></param>
        public void addTargets(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Targets;Integrated Security=True;Pooling=False");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandSec = new SqlCommand("insert into TargetTab(TargetText, TargetID) values('" + insert + "', '2')", SQL);
                commandSec.ExecuteNonQuery();
            }
        }

    }
}
