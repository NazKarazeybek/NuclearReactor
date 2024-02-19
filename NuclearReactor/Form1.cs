using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace NuclearReactor
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            reactorsstable.BackColor = Color.Red;
            reactorsstable.ForeColor = Color.White;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            reactorsstable.BackColor = Color.White;
            reactorsstable.ForeColor = Color.Red;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            reactorsstable.BackColor = Color.Red;
            reactorsstable.ForeColor = Color.White;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            reactorsstable.BackColor = Color.White;
            reactorsstable.ForeColor = Color.Red;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            reactorsstable.BackColor = Color.Red;
            reactorsstable.ForeColor = Color.White;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            reactorsstable.BackColor = Color.White;
            reactorsstable.ForeColor = Color.Red;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            reactorsstable.BackColor = Color.Red;
            reactorsstable.ForeColor = Color.White;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            reactorsstable.BackColor = Color.White;
            reactorsstable.ForeColor = Color.Red;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            reactorsstable.BackColor = Color.Red;
            reactorsstable.ForeColor = Color.White;
            reactorsstable.Text = "Meltdown Happening";

            Refresh();
            Thread.Sleep(500);

            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            reactorsstable.BackColor = Color.White;
            reactorsstable.ForeColor = Color.Red;
            reactorsstable.Text = "Meltdown Happening";


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Reactor2_Click(object sender, EventArgs e)
        {
     
        }
    }
}
