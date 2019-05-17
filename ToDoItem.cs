using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
