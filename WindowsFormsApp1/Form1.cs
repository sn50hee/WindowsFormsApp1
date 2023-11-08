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

        public string Calculation(double x, double y, string oper)
        {
            string result = "";
            switch (oper)
            {
                case "success":
                    result += "\r\n계산 완료";
                    break;
                case "+":
                    result = (x + y).ToString();
                    goto case "success";
                case "-":
                    result = (x - y).ToString();
                    goto case "success";
                case "*":
                    result = (x * y).ToString();
                    goto case "success";
                case "/":
                    if (y == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                    }
                    else
                    {
                        result = (x / y).ToString();
                        goto case "success";
                    }
                    break;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] num_arr = textBox_input.Text.Split(' ');
            string s_answer;
            s_answer = Calculation(double.Parse(num_arr[0]), double.Parse(num_arr[2]), num_arr[1]);
            textBox_print.Text = (s_answer).ToString();
        }
    }
}
