using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        // 계산 결과 반환 성공 여부 체크
        bool result_output = false;
        private void button_input_click(object sender, EventArgs e)
        {
            // line 변수에 출력화면의 텍스트를 가져옴
            string line = textBox_print.Text;

            // line 변수에 입력 화면 텍스트를 추가함
            // 출력 화면은 현재 입력한 값이 적용 되어 있지 않기 때문에 입력 화면의 텍스트를 맨 뒤에 추가
            if (textBox_input.Text != "")
            {
                line += textBox_input.Text;
            }
            else
            {
                // 입력 화면에 숫자가 없으면 연산자 삭제
                line = line.Remove(line.Length - 2);
            }
            
            // 입력 화면 초기화
            textBox_input.Text = "";
            // line의 결과값을 가져옴
            decimal answer = EvaluateExpression(line.Replace(",", ""));
            // 출력 화면 텍스트에 수식과 결과를 출력
            textBox_print.Text = line + " = " + string.Format("{0:#,##0}", answer);
            result_output = true;
            // 김영웅 추가
            // 계산 완료시 기록 저장 
            resultArray.ArrayAdd(line + " = " + string.Format("{0:#,##0}", answer));

        }

        // 문자열을 수식으로 변환하고 결과값을 반환하는 함수
        static decimal EvaluateExpression(string expression)
        {
            // DataTable 클래스를 가져와서 table 인스턴스 생성
            DataTable table = new DataTable();

            // Compute Method를 사용하여 문자열을 수식으로 변환 및 결과 반환
            // Compute 사용 방법: Compute(문자열로 된 수식, 필터 조건)
            decimal result = decimal.Parse(table.Compute(expression, "").ToString());

            return result;
        }


        private void operator_btn_Click(object sender, EventArgs e)
        {
            // 입력 화면의 텍스트를 가져옴
            string num_text = textBox_input.Text;
            decimal num2;
            string result = "";

            // 입력 화면의 텍스트가 숫자형 일 때 실행
            if (decimal.TryParse(num_text, out num2) != false)
            {
                // sender를 Button으로 변환 후 text 값 가져옴
                // sender의 text는 연산자(+, -, *, /, %)
                // " "을 기준으로 입력 화면의 text와 연산자를 하나의 문자열로 만듦
                result = num_text.ToString() + " " + ((Button)sender).Text + " ";
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
            textBox_input.Focus();
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
                // 입력 화면에 있는 숫자에 -1을 곱하여 -, + 변환
                textBox_input.Text = (decimal.Parse(textBox_input.Text) * decimal.Parse("-1")).ToString();
            }
        }

        // 숫자에 , 추가
        // 출처: https://shanael.tistory.com/88
        string prevValue = "";
        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            // 반환된 계산 결과가 있을 때 출력 화면 초기화
            if (result_output == true)
            {
                textBox_print.Text = "";
                result_output= false;
            }
            // sender를 TextBox로 캐스팅
            TextBox textBox = sender as TextBox;

            // textBox의 text를 가져와서 ,를 모두 제거한 후 text 변수에 저장
            string text = textBox.Text.Replace(",", "");

            decimal num = 0;

            // text가 숫자형일 때만 실행
            if (decimal.TryParse(text, out num) || text == "." || (text.Length > 1 && text.EndsWith(".")))
            {
                // num을 특정한 형태가 있는 문자열로 변환
                // {0:#,##0}: 숫자를 천 단위 구분 기호(쉼표)가 있는 형태로 표시
                textBox.Text = string.Format("{0:#,##0}", num);
                // 텍스트 상자의 커서를 항상 텍스트의 끝으로 이동
                textBox.SelectionStart = textBox.TextLength;
                // 커서 선택 길이를 0으로 설정
                // 사용자가 새로운 입력을 시작할 때 선택된 텍스트가 없도록 함
                textBox.SelectionLength = 0;
            }
            // text가 숫자형이 아니면 실행
            // else를 쓰지 않은 이유는 textBox 초기화 때문
            else if (textBox.Text.Length > 0)
            {
                //숫자형태의 값이 아니면 이전값으로 설정
                textBox.Text = prevValue;
            }
                prevValue = textBox.Text;
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

            if (record_array.All(string.IsNullOrEmpty))
            {
                MessageBox.Show("계산 기록이 없습니다.","계산 기록");
            }
            else
            {
                Array.Reverse(record_array); // 주석 해제시 새 기록이 위에서 부터 출력
                record_array = record_array.Where(str => !string.IsNullOrWhiteSpace(str)).ToArray();
                string cal_record = string.Join("\n", record_array.Select((result, index) => $"{record_array.Length - index}. {result}")); MessageBox.Show(cal_record, "계산 기록");
            }
        }

        ////////////////////////////////////////////////////
    }
}
