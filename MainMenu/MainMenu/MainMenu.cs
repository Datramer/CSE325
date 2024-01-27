using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainMenu
{
    public class Order
    {
        public string Name { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
    }
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public string[] itemList;
        public TextBox tb1;
        public string[] tb2;
        public Order order;
        string tempstring;
        string[] tempstring2;

        public MainMenu()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addquote_Click(object sender, EventArgs e)
        {
            AddQuote form = new AddQuote();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "changed";
            tempstring = textBox1.Text;
            tempstring2 = textBox1.Text.Split(' ');
        }
    }
}
