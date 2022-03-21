using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelim_Exam_Aton
{
    public partial class Ordering : Form
    {
        public Ordering()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panelBG.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panelBG_Paint(object sender, PaintEventArgs e)
        {
            // For background panel
            panelBG.BackColor = Color.FromArgb(90,0,0,0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            txtSumName.Text = txtName.Text.ToUpper();
            txtSumContact.Text = txtContact.Text;
            txtSumDateTime.Text = dateTimePicker1.Text + "-" + txtTime.Text;
            txtSumOR.Text = txtOR.Text;

            // Flavor Choice
            double fAM, fVegie, fCheezy, fHouseSpe;
            if (rbtnAllmeat.Checked == true)
            {
                fAM = 125;
                txtFlavor.Text = fAM.ToString("0.00");
                txtSumFlavor.Text = rbtnAllmeat.Text;
            }
            if (rbtnVegetarian.Checked == true)
            {
                fVegie = 100;
                txtFlavor.Text = fVegie.ToString("0.00");
                txtSumFlavor.Text = rbtnVegetarian.Text;
            }
            if (rbtnCheezynez.Checked == true)
            {
                fCheezy = 150;
                txtFlavor.Text = fCheezy.ToString("0.00");
                txtSumFlavor.Text = rbtnCheezynez.Text;
            }
            if (rbtnHouseSpecial.Checked == true)
            {
                fHouseSpe = 175;
                txtFlavor.Text = fHouseSpe.ToString("0.00");
                txtSumFlavor.Text = rbtnHouseSpecial.Text;
            }
            // Crust Choice
            double cPan, cCrispy, cStuffed;
            if (rbtnPan.Checked == true)
            {
                cPan = 50;
                txtCrust.Text = cPan.ToString("0.00");
                txtSumCrust.Text = rbtnPan.Text;
            }
            if (rbtnCrispy.Checked == true)
            {
                cCrispy = 69;
                txtCrust.Text = cCrispy.ToString("0.00");
                txtSumCrust.Text = rbtnCrispy.Text;
            }
            if (rbtnStuffed.Checked == true)
            {
                cStuffed = 87;
                txtCrust.Text = cStuffed.ToString("0.00");
                txtSumCrust.Text = rbtnStuffed.Text;
            }
            // For Add ons choice
            string atext = "";
            double aMeatier = 0, aVeggier = 0, aCheezier = 0, aSS = 0, aTotal = 0;
            if (cbMeatier.Checked == true)
            {
                aMeatier = 45;
                aTotal = aMeatier + aVeggier + aCheezier + aSS;
                atext = atext + cbMeatier.Text + ", ";
                txtSumAddOnns.Text = atext;
            }
            if (cbVeggier.Checked == true)
            {
                aVeggier = 30;
                aTotal = aMeatier + aVeggier + aCheezier + aSS;
                atext = atext + cbVeggier.Text + ", ";
                txtSumAddOnns.Text = atext;
            }
            if (cbCheezier.Checked == true)
            {
                aCheezier = 40;
                aTotal = aMeatier + aVeggier + aCheezier + aSS;
                atext = atext + cbCheezier.Text + ", ";
                txtSumAddOnns.Text = atext;
            }
            if (cbSauceSpice.Checked == true)
            {
                aSS = 35;
                aTotal = aMeatier + aVeggier + aCheezier + aSS;
                atext = atext + cbSauceSpice.Text + ", ";
                txtSumAddOnns.Text = atext;
            }
            txtAddOns.Text = aTotal.ToString("0.00");
            txtSumSlices.Text = comboSlice.SelectedItem.ToString();
            // For Size choice
            double comboSmall = 0, comboMedium = 0, comboLarge = 0, comboParty = 0;
            if (comboSize.SelectedItem == "Small")
            {
                comboSmall = 125;
                txtSize.Text = comboSmall.ToString("0.00");
                txtSumSize.Text = comboSize.SelectedItem.ToString();
            }
            if (comboSize.SelectedItem == "Medium")
            {
                comboMedium = 145;
                txtSize.Text = comboMedium.ToString("0.00");
                txtSumSize.Text = comboSize.SelectedItem.ToString();
            }
            if (comboSize.SelectedItem == "Large")
            {
                comboLarge = 165;
                txtSize.Text = comboLarge.ToString("0.00");
                txtSumSize.Text = comboSize.SelectedItem.ToString();
            }
            if (comboSize.SelectedItem == "Party")
            {
                comboParty = 185;
                txtSize.Text = comboParty.ToString("0.00");
                txtSumSize.Text = comboSize.SelectedItem.ToString();
            }
            // For Side Dish choice
            string sdText = "";
            double sdGarlicBread = 0, sdCheeseStick = 0, sdTotal = 0;
            if (cbGarlicBread.Checked == true)
            {
                sdGarlicBread = 70;
                sdTotal = sdCheeseStick + sdGarlicBread;
                sdText = sdText + cbGarlicBread.Text + ", ";
                txtSumSides.Text = sdText;
            }
            if (cbCheeseSticks.Checked == true)
            {
                sdCheeseStick = 70;
                sdTotal = sdCheeseStick + sdGarlicBread;
                sdText = sdText + cbCheeseSticks.Text + ", ";
                txtSumSides.Text = sdText;
            }
            txtSides.Text = sdTotal.ToString("0.00");
            // Compute for total Price
            txtTotal.Text = (Convert.ToDouble(txtFlavor.Text) + Convert.ToDouble(txtCrust.Text) + Convert.ToDouble(txtAddOns.Text) + Convert.ToDouble(txtSides.Text) + Convert.ToDouble(txtSize.Text)).ToString("0.00");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Select();
            // Reset all Textbox in Order Summary
            foreach (Control ctrl in panelOrderSum.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            // Reset all Textbox in panelBG
            foreach (Control ctrl in panelBG.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            // Uncheck all radiobuttons in gbFlavor
            foreach (Control ctrl in gbFlavor.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                    }
                }
            }
            // Uncheck all radiobuttons in gbCrust
            foreach (Control ctrl in gbCrust.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                    }
                }
            }
            // Uncheck all checkboxes in gbAddOns
            foreach (Control ctrl in gbAddOns.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox check = (CheckBox)ctrl;
                    if (check.Checked == true)
                    {
                        check.Checked = false;
                    }
                }
            }
            // Reset combobox for size and slice
            comboSize.SelectedIndex = -1;
            comboSlice.SelectedIndex = -1;
            //Reset all checkboxes in gbSideDish
            foreach (Control ctrl in gbSideDish.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox check = (CheckBox)ctrl;
                    if (check.Checked == true)
                    {
                        check.Checked = false;
                    }
                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Compute for change       
            if (Double.Parse(txtTotal.Text) > Double.Parse(txtPayment.Text))
            {
                MessageBox.Show("INSUFFICIENT MONEY");
                txtPayment.Clear();
            }
            else
            {
                txtChange.Text = (Convert.ToDouble(txtPayment.Text) - Convert.ToDouble(txtTotal.Text)).ToString("0.00");
                txtPayment.Text = Convert.ToDouble(txtPayment.Text).ToString("0.00");
            }
        }
        private void Ordering_Load(object sender, EventArgs e)
        {
            txtName.Select();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Time
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program
            Application.Exit();
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Will ignore chars in txtPayment exept for "."
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
           // 
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
