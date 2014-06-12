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
        public frmMain()
        {
            InitializeComponent();
        }

        const int BACKSPACE_KYE = 8; // backspace key의 아스키 코드값 8
        const int ENTER_KEY = 13; // enter key 아스키 코드 값 13
        const int SPACE_KEY = 32; // space key 아스키 코드 값 32

        int m_nIndex = 0; // 글자 위치(사용자의 입력 횟수를 의미함)
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

            return str;
        }

        // 사용자의 타이핑한 시간 설정
        private void tmTimer_Tick(object sender, EventArgs e)
        {
            m_nTime += 1;
        }
        //************************************//
        // 현재 상황 :
        // 윈도우 폼 작성 완료
        // 텍스트 파일 불러오기
        // 사용자가 글자 타이핑 하기
        //**********************************//
        // 추가할 메소드들 :
        // 틀린 타이핑 처리
        // 엔터키 처리
        // 글자 지우기 처리
        // 사용자의 타이핑 속도, 정확도 표시
        // 시간이 된다면 산성비 게임 까지 !
        // **********************************//

       
    }
}
