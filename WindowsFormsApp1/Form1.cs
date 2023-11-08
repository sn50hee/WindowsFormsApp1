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
            // line 변수에 출력화면의 텍스트를 가져옴
            string line = textBox_print.Text;
            // line 변수에 입력 화면 텍스트를 추가함
            // 출력 화면은 현재 입력한 값이 적용 되어 있지 않기 때문에 입력 화면의 텍스트를 맨 뒤에 추가
            line += textBox_input.Text;
            // 입력 화면 초기화
            textBox_input.Text = "";
            // line의 결과값을 가져옴
            double answer = EvaluateExpression(line);
            // 출력 화면 텍스트에 수식과 결과를 출력
            textBox_print.Text = line + " = " + answer.ToString();
        }

        // 문자열을 수식으로 변환하고 결과값을 반환하는 함수
        static double EvaluateExpression(string expression)
        {
            // DataTable 클래스를 가져와서 table 인스턴스 생성
            DataTable table = new DataTable();

            // "expression" 열 추가
            // string 타입
            // expression 변수에 저장된 문자열이 해당 열에 저장됨
            // "expression" 열에 행이 추가 된다면 expression 수식이 적용
            table.Columns.Add("expression", typeof(string), expression);

            // 새로운 데이터 행 생성
            DataRow row = table.NewRow();
            // row 변수를 table에 추가
            // "expression" 열에 expression 변수에 저장된 문자열이 수식화 되어 계산 결과가 출력
            table.Rows.Add(row);

            // 테이블에 저장된 "expression" 열의 값을 가져와 문자열로 변환
            // 문자열을 double.Parse를 사용하여 실수(double)로 변환
            double result = double.Parse((string)row["expression"]);
            return result;
        }


        private void operator_btn_Click(object sender, EventArgs e)
        {
            // 입력 화면의 텍스트를 가져옴
            string num_text = textBox_input.Text;
            double num2;
            string result = "";

            // 입력 화면의 텍스트가 숫자형 일 때 실행
            if (double.TryParse(num_text, out num2) != false)
            {
                // sender를 Button으로 변환 후 text 값 가져옴
                // sender의 text는 연산자(+, -, *, /, %)
                // " "을 기준으로 입력 화면의 text와 연산자를 하나의 문자열로 만듦
                result = num2.ToString() + " " + ((Button)sender).Text + " ";
            }
            // 입력 화면의 텍스트가 숫자형이 아닐 때 실행
            else
            {
                // 경고창 표시
                MessageBox.Show("숫자를 입력해주세요.");
            }
            // 출력 화면에 result 출력
            textBox_print.Text += result;
            // 입력 화면 초기화
            textBox_input.Text = "";
        }

        /*
         * 정형진 작성
        */
        private void del_all_Click(object sender, EventArgs e)
        {
            // 입력 화면과 출력 화면 모두 초기화
            textBox_input.Text = "";
            textBox_print.Text = "";
        }

        private void del_one_Click(object sender, EventArgs e)
        {
            // 입력 화면에 text가 입력이 되어 있을 시 실행
            if (textBox_input.Text.Length > 0)
            {
                // 맨 뒤 문자를 제외한 나머지 문자를 입력 화면에 출력
                textBox_input.Text = textBox_input.Text.Substring(0, textBox_input.Text.Length - 1);
            }
        }//

        private void sign_Click(object sender, EventArgs e)
        {
            // 입력 화면에 text가 입력이 되어 있을 시 실행
            if (textBox_input.Text.Length > 0)
            {
                // 입력 화면에 있는 숫자에 -1을 곱하여 -, + 기로 변환
                textBox_input.Text = (double.Parse(textBox_input.Text) * double.Parse("-1")).ToString();
            }
        }
    }
}
