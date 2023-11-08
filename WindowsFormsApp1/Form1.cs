using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button_input_click(object sender, EventArgs e)
        {
            // [계산] 버튼 클릭 시 이벤트
        }


        /*
         * 윤석희 작성
         */
        private void operator_btn_Click(object sender, EventArgs e)
        {
            string num_text = textBox_input.Text;
            double num2;
            string result = "";
            if (double.TryParse(num_text, out num2) != false)
            {
                result = num2.ToString() + " " + ((Button)sender).Text + " ";
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            textBox_print.Text += result;
            textBox_input.Text = "";
        }
    }
}
