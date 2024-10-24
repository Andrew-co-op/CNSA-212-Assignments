using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_WINDOWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            // Get the name from the text box
            string name = textBox1.Text;

            // If the name is empty, show a generic greeting
            if (string.IsNullOrWhiteSpace(name))
            {
                textBox1.Text = "Hello! Welcome to HelloWindows!";
            }
            else
            {
                // Show a personalized greeting
                textBox2.Text = $"Hello, {name}! Welcome to HelloWindows!";
            }
        }
    }
}
