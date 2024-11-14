﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сrystals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        int a, b, c, move, wins, balance,loss;

        private void btn_bid_Click(object sender, EventArgs e)
        {
            lbl_casino.Text = "Casino";
            balance = 0;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "Play";
            lbl_balance.Text="Balance : $";
        }

        private int Game_Result()
        {
            if (System.Convert.ToInt32(a & b) != c)
            {
                wins++;
                lbl_win.Text = "Wins:" wins;
                balance += 2;
                lbl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) balance;
                btn_play.Text = "Continue Playing..";
                lbl_casino.Text = "You Won";

            }
            else
            {
                lbl_casino.Text = "Try Again";
                loss +;
                lbl_loss.Text = "Loss :"+loss;
                lbl_balance.Text = "Balance : $ 0";
                balance = 0;
                textBox1.Text = "";
                btn_play.Enabled = false;
                pictureBox1.Image = Properties.Resources.dollar;
                pictureBox2.Image = Properties.Resources.dollar;
                pictureBox3.Image = Properties.Resources.dollar;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(5);
                b = rnd.Next(5);
                c = rnd.Next(5);
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.Bronze;
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.Bronze;
                        break;

                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.Bronze;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
                Game_Result();
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the Bid Amount inside the textbox to play..");
            }
            else
            {
                timer1.Enabled = true;
                lbl_casino.Text = "Casino";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
            }
        }
    }
}
