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
            string line = textBox_print.Text;
            line += textBox_input.Text;
            textBox_input.Text = "";
            double answer = EvaluateExpression(line);
            textBox_print.Text = line + " = " + answer.ToString();

            // 김영웅 추가
            // 계산 완료시 기록 저장 
            resultArray.ArrayAdd(line + " = " + answer.ToString()); 
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
        }//

        private void sign_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox_input.Text) > 0)
                //textBox_input.Text += '-';
                textBox_input.Text = (double.Parse(textBox_input.Text) * double.Parse("-1")).ToString();
            else
                // textBox_input.Text = textBox_input.Text.Substring(1, textBox_input.Text.Length - 1);
                textBox_input.Text = (double.Parse(textBox_input.Text) * double.Parse("-1")).ToString();
        }

        ////////////////////////////////////////////////////
        ///// 김영웅 작성
        // 제한 배열 클래스
        public class LimitArray
        {
            // 배열, 크기, 인덱스를 멤버 변수로 선언
            private string[] array;
            private int size;
            private int index;

            // 생성자
            public LimitArray(int size) // 크기를 인자로 받아
            {
                this.size = size;
                array = new string[size]; // 해당 크기의 배열을 생성
                index = 0; // 인덱스를 0으로 초기화
            }

            // ArrayAdd 메서드 (기록 추가)
            public void ArrayAdd(string item)
            {
                // 인덱스는 size로 나눈 나머지 위치에 기록을 추가하여
                // 배열의 크기를 벗어나지 않도록 한다.
                array[index % size] = item;
                index++; // 기록을 추가한 후 인덱스 1 증가
            }

            // PushArray 메서드 (오래된 기록 밀어내기 지정 크기 초과시 삭제)
            public string[] PushArray()
            {
                // array의 원소들이 오래된 순서대로 result로 복사되어 밀어냄.
                string[] result = new string[size];
                for (int i = 0; i < size; i++)
                {
                    result[i] = array[(index + i) % size];
                }
                return result;
            }
        }
        // 크기가 5인 LimitArray 클래스의 인스턴스를 생성하여 resultArray에 저장
        private LimitArray resultArray = new LimitArray(5);
        private void history_Click(object sender, EventArgs e) //계산결과 확인 
        {
            // 저장된 계산 결과 가져오기
            string[] record_array = resultArray.PushArray();
            //Array.Reverse(items); // 주석 해제시 새 기록이 위에서 부터 출력

            // 계산 결과를 개행 문자로 연결한 문자열 생성
            string cal_record = string.Join("\n", record_array);
            MessageBox.Show(cal_record, "계산 기록"); // 메세지 박스
        }
        ////////////////////////////////////////////////////

    }

}
