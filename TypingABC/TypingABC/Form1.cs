using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingABC
{
    public partial class frmMain : Form
    {
        //public bool KeyPreview { get; set; }
        
        public frmMain()
        {
            InitializeComponent();
               
        }
        
        const int BACKSPACE_KYE = 8; // backspace key의 아스키 코드값 8
        const int ENTER_KEY = 13; // enter key 아스키 코드 값 13
        const int SPACE_KEY = 32; // space key 아스키 코드 값 32

        int m_nIndex = 0; // 글자 위치(사용자의 입력 횟수(문자단위)를 의미함)
        int m_nLen = 0; // 현재 보이는 문장의 길이
        String m_strFile; // 파일 경로
        System.IO.StreamReader m_file;  // 파일 내용을 얻기 위한 객체

        int m_nTime; // 사용자가 타이핑하는 데 걸린 시간
        int m_nTotalSpeed; // 타이핑 스피드를 모두 더하기
        int m_nTry; // 문장 테스트 횟수
        int m_nCorrect; // 정확도 표시

        // 폼을 로드함과 동시에 파일도 로드, 타이핑 초기화 준비
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 파일 열기
            m_strFile = Application.StartupPath + "\\txt\\TypingTest.txt";

            try
            {
                m_file = System.IO.File.OpenText(m_strFile);
            }
            catch
            {
                MessageBox.Show(m_strFile + "File Open Failed.");
                this.Close();
                return;
            }

            // 프로그램 시작과 동시에 원문을 보여주기 위해 한 라인 읽기
            rtxSentence.Text = NextSentence(); // 다음 문장 가져오기(미완성)
            m_nLen = rtxSentence.Text.Length; // 현재 보이는 문장의 길이 넣기

            m_nTry = 1; // 시도횟수
            tmTimer.Interval = 1000;

            Init();
        }

        // 데이터 초기화
        private void Init() {
            m_nIndex = 0; // 글자위치
            txtInput.Clear(); // 사용자 입력 텍스트박스 지우기
            tmTimer.Stop();
            m_nTime = 0; // 사용자가 타이핑 하는데 걸린 시간 초기화
        }

        //파일에서 다음 문장을 읽어서 리턴해준다.
        private String NextSentence() {
            String str;
            str = m_file.ReadLine();

            if (str == null) { // 읽을 내용이 없으면 첨 부터 다시 읽기
                m_file.Close();
                m_file = null;

                try
                {
                    m_file = System.IO.File.OpenText(m_strFile);
                }
                catch {
                    MessageBox.Show(m_strFile + "Failed File Open");
                    this.Close();
                    return null;
                }
                str = m_file.ReadLine();
            }
            // 타이핑 결과 속도나 정확도 같은거 설정하는 부분 추가해야함

            m_nLen = str.Length;

            // 다음 문장의 색깔을 검은색으로 되돌릴 코드 추가해야함
            rtxSentence.Select(0, m_nLen);

            return str;
        }

        // 사용자의 타이핑한 시간 설정
        private void tmTimer_Tick(object sender, EventArgs e)
        {
            m_nTime += 1;
        }

        private void Backspace() {
            int cnt;
            cnt = txtInput.SelectionLength; // 사용자의 글자 선택 영역(글자를 블럭잡으로는 것)

            if (cnt == 0)  // 0이면 백스페이스 1번 입력한거고, 사용자가 블럭잡지 않은 것임
                m_nIndex -= 1;
            else
                m_nIndex -= cnt;

            if (m_nIndex < 0)
                m_nIndex = 0;

            if (cnt > 0)
            {
                String str;

                rtxSentence.Select(m_nIndex, cnt);
                str = rtxSentence.SelectedText;

                rtxSentence.SelectedText = str.Replace("*", " "); // * 표시를 원래대로 돌리기
            }
            else {
                rtxSentence.Select(m_nIndex, 1);
                if (rtxSentence.SelectedText.Equals("*"))
                    rtxSentence.SelectedText = " ";
            }
            rtxSentence.SelectionColor = Color.Black;
        }

        private int AvgSpeed() {

            // 속도 누적하여, 그 누적값을 타이핑 시도횟수로 나누어 평균 얻기
            return 0;
        }
        private int Speed() {
            // 속도 = 거리 / 시간
            // 타이핑 속도 = 입력한 총 문장 길이 / 걸린 시간
            return 0;
        }

        private int Correctness() {

            return 0;
        }

        // 엔터키 누르면 다음 문장 넘어가기
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            String str1; //
            m_nIndex += 1; // 사용자가 입력한 글자 수 증가
                    
            if (e.KeyChar == (char)ENTER_KEY) // 엔터키를 입력받으면
            {
                txtInput.Clear(); // 텍스트 입력창 지우고
                rtxSentence.Text = NextSentence(); // 다음 문자열 뿌려주고
                Init(); // 초기화
                return;
            }
            else if (e.KeyChar == (char)BACKSPACE_KYE) // 백스페이스 입력받으면
            { 
                // code here
                Backspace();
                return;
            }
            
            /*
            else if (e.KeyChar == (char)SPACE_KEY)// 스페이스바 효과 = 엔터키 효과
            { 
            
            }
             */
            // 백스페이스 키로 지울경우 추가하기
            // 스페이스 바를 누를 경우 추가하기

            if (m_nLen <= m_nIndex)
            {
                e.Handled = true; // Handled : 키처리 이벤트 처리 여부
                return;
            }

            str1 = rtxSentence.Text.Substring(m_nIndex,1);// 부분 문자열 가져오기 (startIndext,Length)

            if (e.KeyChar.ToString().Equals(str1) != true) // 사용자 입력 글자가 틀리면
            {
                if (m_nIndex < 0)
                    m_nIndex = 0;

                rtxSentence.Select(m_nIndex, 1); // 텍스트 상자의 문자열 글자 선택하기
                rtxSentence.SelectionColor = Color.Red; // 선택된 틀린 글자는 빨간색으로

                if (str1.Equals(" ")) {
                    rtxSentence.SelectedText = "*";
                }
                
                // 여기에 정확도 변수가 하락되어야 함...
            }
            else { // 정확한 입력이면 
                rtxSentence.Select(m_nIndex, 1);
                rtxSentence.SelectionColor = Color.Black; // 검정글씨로..
            }
            m_nIndex += 1;
        }


        //************************************//
        // 현재 상황 :
        // 윈도우 폼 작성 완료
        // 텍스트 파일 불러오기
        // 사용자가 글자 타이핑 하기
        // 엔터키 처리(완료)=> 다음문장으로 넘어감
        //**********************************//
        // 추가할 메소드들 :
        // 틀린 타이핑 처리
        
        // 글자 지우기 처리
        // 사용자의 타이핑 속도, 정확도 표시
        // 시간이 된다면 산성비 게임 까지 !
        // **********************************//

       
    }
}
