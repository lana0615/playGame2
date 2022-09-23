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

namespace playGame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countdownLabel2.Visible = false;
            countdownLabel3.Visible = false;
            countdowwnLabel1.Visible = false;
            goLabel.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)

        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            playGameButton.Visible = false;
            countdownLabel3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            

            countdownLabel3.Visible = false;
            countdownLabel2.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdownLabel2.Visible = false;
            countdowwnLabel1.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdowwnLabel1.Visible=false;

            this.BackColor = Color.Green;
            goLabel.Visible = true;


        }
     
    }
}
