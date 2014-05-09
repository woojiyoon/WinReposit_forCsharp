using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWatch
{
    public partial class Form1 : Form
    {
        bool isClick_clock = false; // 시계 라디오 버튼 boolean
        bool isClick_stopwatch = false; // 스탑와치 라디오 버튼 boolean
        bool isClick_timer = false; // 타이머 라디오 버튼 boolean
        int hour, min, sec; // 스탑와치의 시,분,초
        int order_sw; // 스탑와치 기록 순위

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Enabled = true;
            Button_Record.Visible = false;
            groupBox2.Visible = true;
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if(Button_Confirm.Text == "Confirm")
            {
                timer1.Enabled = true;
                Button_Confirm.Text = "Pause";
            }
            else // Pause
            {
                timer1.Enabled = false; //  타이머 일시정지
                Button_Confirm.Text = "Confirm";
            }
            
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {       
            // 시계 라디오 버튼 클릭시
            if(Radio_Clock.Checked)
            {
                label2.Text =  string.Format("{0:00}:{1:00}:{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            }
            
            // 스탑와치 라디오 버튼 클릭시
            else if(Radio_Stopwatch.Checked)
            {
                isClick_stopwatch = true; //  스탑와치 라디오 버튼으로 들어왔다.
                if (isClick_timer == true)
                {
                    hour = 0;
                    min = 0;
                    sec = 0;
                    Textbox_Hour.Text = "";
                    Textbox_Minute.Text = "";
                    Textbox_Second.Text = "";

                    label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
                    isClick_timer = false;
                }
                Button_Record.Visible = true;

                if (Button_Confirm.Text == "Pause")
                {
                    sec++;
                    if (sec == 60)
                    {
                        sec = 0;
                        min++;
                    }
                    if (min == 60)
                    {
                        min = 0;
                        hour++;
                    }
                    label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
                } 
           }

            // 타이머 라디오 버튼 클릭시
            else if(Radio_Timer.Checked)
            {
                isClick_timer = true; // 타이머 라디어 버튼으로 들어왔다.
                if (isClick_stopwatch == true)
                {
                    hour = 0;
                    min = 0;
                    sec = 0;
                    label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
                    isClick_stopwatch = false;
                }

                if (Button_Confirm.Text == "Confirm" && Textbox_Hour.Text != "" && Textbox_Minute.Text != ""  && Textbox_Second.Text != "" )
                {
                    hour = Convert.ToInt32(Textbox_Hour.Text);
                    min = Convert.ToInt32(Textbox_Minute.Text);
                    sec = Convert.ToInt32(Textbox_Second.Text);
                } 
                else if(Button_Confirm.Text == "Pause")
                {
                    sec--;
                    if (sec == 0)
                    {
                        min--;
                        sec = 59;
                    }
                    if (min == 0)
                    {
                        hour--;
                        min = 59;
                    }
                    Thread.Sleep(1000);
                    label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);    
                }
            }
        }

        // 스탑와치 순위 기록 버튼 클릭시
        private void Button_Record_Click(object sender, EventArgs e)
        {
            Textbox_Record.Visible = true; // 스탑와치 기록창 보이기
            order_sw++;  // 스탑와치 순위값 상승

            // 스탑와치 순위 출력
            Textbox_Record.Text = Textbox_Record.Text + "\r\n " + "[" + order_sw + "] " + hour + ":" + min + ":" + sec;
        }

        // 리셋 버튼 클릭시
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            // 돌고 있는 타이머 멈추기
            timer1.Enabled = false;
            
            // 증가되던 시간값들 0으로 초기화
            if (Radio_Stopwatch.Checked)
            {
                Textbox_Record.Text = "";  // 스탑와치 순위창 지우기
                Textbox_Record.Visible = false; // 스탑와치 순위창 안보이기
                order_sw = 0; // 스탑와치 순위 변수 초기화
                hour = 0;
                min = 0;
                sec = 0;
                label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
            }
            if (Radio_Timer.Checked)
            {
                hour = Convert.ToInt32(Textbox_Hour.Text);
                min = Convert.ToInt32(Textbox_Minute.Text);
                sec = Convert.ToInt32(Textbox_Second.Text);

                label2.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
            }
            
        }         
    }
}
