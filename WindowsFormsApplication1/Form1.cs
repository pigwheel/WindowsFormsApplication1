using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "แบบสอบถามการเลือกรถยนต์ :" + Environment.NewLine;


            str = str + "1.คุณชอบรถยี่ห้อใด ===";
            if (apt1.Checked == true)
            {
                str = str + "ฮอนด้า" + Environment.NewLine;


            }
            if (radioButton2.Checked == true)
            {
                str = str + "โตโยต้า" + Environment.NewLine;

            }
            if (radioButton4.Checked == true)
            {
                str = str + "เชฟโลเลต" + Environment.NewLine;

            }
            if (radioButton5.Checked == true)
            {
                str = str + "มาสด้า" + Environment.NewLine;

            }
            if (radioButton6.Checked == true)
            {
                str = str + "ฟอร์ด" + Environment.NewLine;

            }
            str = str + "2.สีอะไร ===";
            if (bpt1.Checked == true)
            {
                str = str + "ขาว" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "ดำ" + Environment.NewLine;
            }
            if (radioButton1.Checked == true)
            {
                str = str + "แดง" + Environment.NewLine;

            }
            if (radioButton3.Checked == true)
            {
                str = str + "น้ำเงิน" + Environment.NewLine;

            }
            if (radioButton7.Checked == true)
            {
                str = str + "บรอนด์" + Environment.NewLine;

            }
            str = str + "3.รถแบบไหน ===";
            if (cpt1.Checked == true)
            {
                str = str + "รถครอบครัว" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "รถปิคอัพ" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "รถเก๋ง" + Environment.NewLine;

            }
            
            str = str + "4.แต่งหรือไม่ ===";
            if (dpt1.Checked == true)
            {
                str = str + "แต่ง" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "ไม่แต่ง" + Environment.NewLine;
            }
            str = str + "5.เบาะอะไร ===";
            if (radioButton9.Checked == true)
                str = str + "หนัง" + Environment.NewLine;
            {
                if (radioButton8.Checked == true)
                    str = str + "กำมะหยี่" + Environment.NewLine;
                }
            
            
            MessageBox.Show(str, "รายงานผล");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

