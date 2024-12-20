using SlotMachine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformSlotMachine1
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private Theme selectedTheme;

        public Form1()
        {
            InitializeComponent();
            InitializeThemeComboBox();
            InitializeSlotMachine();
        }
        private void InitializeThemeComboBox()
        {
            cmbThemes.Items.Add("Fruits");
            cmbThemes.Items.Add("Animals");
            cmbThemes.Items.Add("Jewels");
            cmbThemes.Items.Add("Numbers");
            cmbThemes.SelectedIndex = 0;
            cmbThemes.SelectedIndexChanged += cmbThemes_SelectedIndexChanged;
        }
        private void InitializeSlotMachine()
        {
            List<Reel> reels = new List<Reel>
            {
                new Reel(label1, selectedTheme),
                new Reel(label2, selectedTheme),
                new Reel(label3, selectedTheme)
            };

            slotMachine = new Slot(selectedTheme, reels, 1000);

            lblBalance.Text = "Balance: P" + slotMachine.Balance;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbThemes.SelectedItem.ToString())
            {
                case "Fruits":
                    selectedTheme = new FruitsTheme();
                    break;
                case "Animals":
                    selectedTheme = new AnimalsTheme();
                    break;
                case "Jewels":
                    selectedTheme = new JewelsTheme();
                    break;
                case "Numbers":
                    selectedTheme = new NumbersTheme();
                    break;
                default:
                    selectedTheme = new FruitsTheme();
                    break;
            }

            InitializeSlotMachine();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }



        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                btnSpin.Enabled = false;
                lblResult.Text = "";
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }
        }




        private void timerSpin_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin();

            if (DateTime.Now.Second % 2 == 0)
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult();
                slotMachine.UpdateBalance(winnings);

                if (winnings > 0)
                {
                    lblResult.Text = $"🎉 WIN! You earned P{winnings} 🎉";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
                txtStake.Clear();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
