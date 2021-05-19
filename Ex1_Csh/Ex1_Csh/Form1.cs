using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ex1_Csh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int nrIncerc = 0;
        int score = 0;
        int Random = 0;
        int nrRandom;

        private void btnRez_Click(object sender, EventArgs e)
        {
            ///Creste nr de incercari daca
            ///Creste scoru daca
            ///Istoric

            nrIncerc++;
            lblNrIncercari.Text = nrIncerc.ToString();
            
            ///Corect way
            ///Wrong way
            if(txtPlayerGuess.Text==Random.ToString())
            {
                score += 10;
                lblScorePlayer.Text = score.ToString();
                MessageBox.Show("Felicitari ai ghicit!");

                nrIncerc = 0;
                lblNrIncercari.Text = nrIncerc.ToString();

                score = 0;
                lblScorePlayer.Text = score.ToString();

                var rand = new Random();
                Random = rand.Next(0, 101);

                lblIstoric.Text = "Ghiceste!";
            }
            else
            {
                /// daca rez nu este bun ce se intampla
            }

        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            nrIncerc = 0;
            lblNrIncercari.Text = nrIncerc.ToString();

            score = 0;
            lblScorePlayer.Text = score.ToString();

            var rand = new Random();
            Random = rand.Next(0, 101);

            lblIstoric.Text= "Ghiceste!";

        }

        private void txtPlayerGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=46 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rand = new Random();
            Random = rand.Next(0, 101);
        }
    }
}
