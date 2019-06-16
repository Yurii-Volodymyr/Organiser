using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Tworzymy (otwieramy) "Form1 "
        /// Design tej formy to "Form1.Designer.cs"
        /// /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przy nacisku na "Learning" otwira sie "User control"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //learning
            learnign1.BringToFront();
        }
        /// <summary>
        /// Przy nacisku na "Books" otwira sie "User control"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //books
            books1.BringToFront();
        }
        /// <summary>
        /// Object senter - parametr
        /// EventsArg e - Represents the base class for classes that contain event data, and provides a value ti use for events that do not include event data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //targets
            targets1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //ideas
            ideas1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //minimize
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Timer jest potrzebny dla tego zeby program wyswietlal date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// dziala w podobny sposob. Dla wyswietlenia aktualnej daty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}
