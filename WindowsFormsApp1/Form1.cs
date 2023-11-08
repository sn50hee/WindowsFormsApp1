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

        /*
        * 윤석희 작성
        */

        private void button_input_click(object sender, EventArgs e)
        {
            // [계산] 버튼 클릭 시 이벤트
            string line = textBox_print.Text;
            line += textBox_input.Text;
            textBox_input.Text = "";
            double answer = EvaluateExpression(line);
            textBox_print.Text = line + " = " + answer.ToString();
        }

        static double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);

            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double result = double.Parse((string)row["expression"]);
            return result;
        }

        static double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);

            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double result = double.Parse((string)row["expression"]);
            return result;
        }

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

        /*
         * 정형진 작성
        */
        private void del_all_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "";
            textBox_print.Text = "";
        }

        private void del_one_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0)
            {
                textBox_input.Text = textBox_input.Text.Substring(0, textBox_input.Text.Length - 1);
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0)
                textBox_input.Text = (double.Parse(textBox_input.Text) * double.Parse("-1")).ToString();
        }
    }
}
