using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPAOnScreenKeyboard
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle = 0x08000000;
                return param;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            btn1.Text = "r";
            btn2.Text = "ɾ";
            btn3.Text = "ɽ";
            btn4.Text = "ɹ";
            btn5.Text = "ɻ";
            btn6.Text = "ɺ";
            btn7.Text = "ʀ";
            btn8.Text = "ʁ";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = "q";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn1.Text = "w"; 
            btn2.Text = "ʍ";
            btn3.Text = "ɰ";
            btn4.Text = "ʷ";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn1.Text = "y";
            btn2.Text = "ʏ";
            btn3.Text = "ɤ";
            btn4.Text = "ɥ";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            btn1.Text = "t";
            btn2.Text = "ʈ";
            btn3.Text = "θ";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            btn1.Text = "ʔ";
            btn2.Text = "ʕ";
            btn3.Text = "ɂ";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOnTop_Click(object sender, EventArgs e)
        {
            if (TopMost == false)
            {
                TopMost = true;
                buttonOnTop.Text = "Unlock";
            }
            else
            {
                TopMost = false;
                buttonOnTop.Text = "Lock";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            btn1.Text = "e";
            btn2.Text = "ɘ";
            btn3.Text = "ə";
            btn4.Text = "ɚ";
            btn5.Text = "ɛ";
            btn6.Text = "ɜ";
            btn7.Text = "ɞ";
            btn8.Text = "ɝ";
            btn9.Text = "ᵊ";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = ""; 
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            btn1.Text = "u";
            btn2.Text = "ʉ";
            btn3.Text = "ɯ";
            btn4.Text = "ʊ";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            btn1.Text = "i";
            btn2.Text = "ɨ";
            btn3.Text = "ı";
            btn4.Text = "ɪ";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            btn1.Text = "o";
            btn2.Text = "ɔ";
            btn3.Text = "ø";
            btn4.Text = "ɵ";
            btn5.Text = "œ";
            btn6.Text = "ɶ";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            btn1.Text = "p";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            btn1.Text = "a";
            btn2.Text = "ɐ";
            btn3.Text = "æ";
            btn4.Text = "ɑ";
            btn5.Text = "ɒ";
            btn6.Text = "ʌ";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            btn1.Text = "s";
            btn2.Text = "ʂ";
            btn3.Text = "ʃ";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            btn1.Text = "d";
            btn2.Text = "ɖ";
            btn3.Text = "ɗ";
            btn4.Text = "ð";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            btn1.Text = "f";
            btn2.Text = "ɸ";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            btn1.Text = "ɡ";
            btn2.Text = "ɠ";
            btn3.Text = "ɢ";
            btn4.Text = "ʛ";
            btn5.Text = "ɣ";
            btn6.Text = "g";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            btn1.Text = "h";
            btn2.Text = "ɦ";
            btn3.Text = "ħ";
            btn4.Text = "ʜ";
            btn5.Text = "ɧ";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            btn1.Text = "j";
            btn2.Text = "ʝ";
            btn3.Text = "ȷ";
            btn4.Text = "ɟ";
            btn5.Text = "ʄ";
            btn6.Text = "ʲ";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            btn1.Text = "k";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            btn1.Text = "l";
            btn2.Text = "ɬ";
            btn3.Text = "ɭ";
            btn4.Text = "ʟ";
            btn5.Text = "ɫ";
            btn6.Text = "ɮ";
            btn7.Text = "ʎ";
            btn8.Text = "ł";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            btn1.Text = "z";
            btn2.Text = "ʐ";
            btn3.Text = "ʑ";
            btn4.Text = "ʒ";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            btn1.Text = "x";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            btn1.Text = "c";
            btn2.Text = "ç";
            btn3.Text = "ɕ";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            btn1.Text = "v";
            btn2.Text = "ʋ";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            btn1.Text = "b";
            btn2.Text = "ɓ";
            btn3.Text = "ʙ";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            btn1.Text = "n";
            btn2.Text = "ɳ";
            btn3.Text = "ɲ";
            btn4.Text = "ŋ";
            btn5.Text = "ɴ";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            btn1.Text = "m";
            btn2.Text = "ɱ";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
        }

        private void Alphabet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SendKeys.Send(btn.Text);
        }
    }
}
