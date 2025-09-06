using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2_CircleClassWithRead_OnlyProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Double.Parse(numericUpDownRadius.Text));

            MessageBox.Show("Radius: " + circle.Radius + "\nArea: " + circle.Area);
        }
    }
}
