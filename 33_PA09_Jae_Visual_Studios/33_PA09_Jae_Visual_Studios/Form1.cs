using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_PA09_Jae_Visual_Studios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double ConvertedValue;

            try
            {
                if ((Rdb_USDollars.Checked == false) && (Rdb_JapaneseYen.Checked = false) && (Rdb_MalaysianRinggit.Checked = false))
                {
                    MessageBox.Show("Select at least one type of currency to convert");
                }

                if (Rdb_USDollars.Checked == true)
                {
                    AmountEntered = double.Parse(Txt_Amount.Text);
                    ConvertedValue = AmountEntered * 0.74;

                    Txt_Value.Text = ConvertedValue.ToString();
                }

                if (Rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(Txt_Amount.Text);
                    ConvertedValue = AmountEntered * 81.97;

                    Txt_Value.Text = ConvertedValue.ToString();
                }

                if (Rdb_MalaysianRinggit.Checked == true)
                {
                    AmountEntered = double.Parse(Txt_Amount.Text);
                    ConvertedValue = AmountEntered * 3.01;

                    Txt_Value.Text = ConvertedValue.ToString();
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Amount.Text = " ";
            Txt_Value.Text = " ";
            Rdb_JapaneseYen.Checked = false;
            Rdb_USDollars.Checked = false;
            Rdb_MalaysianRinggit.Checked = false;
        }
    }
}
