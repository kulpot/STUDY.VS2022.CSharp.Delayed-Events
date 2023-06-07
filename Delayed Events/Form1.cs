using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=F9rU180GplE&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=58
//  in conjunction with the TextChanged event which is commonly used with this method.
// TextBox2 toolbox created

namespace Delayed_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox21.TextChangedDelayedInterval = 3000;
        }

        private void textBox21_TextChangedDelayed(object sender, EventArgs e)
        {
            this.Text += " raised ";
        }
    }
}
