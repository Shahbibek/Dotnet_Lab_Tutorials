using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            string[] items = { };
            comboBox1.Items.AddRange(items);
            MessageBox.Show("Value Added");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            string[] items = { };
            comboBox1.Items.AddRange(items);
            MessageBox.Show("Value Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());

        }
    }
}
