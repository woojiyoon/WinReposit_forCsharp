namespace DigitalWatch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Textbox_Minute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_Hour = new System.Windows.Forms.TextBox();
            this.Textbox_Second = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Record = new System.Windows.Forms.Button();
            this.Radio_Timer = new System.Windows.Forms.RadioButton();
            this.Radio_Stopwatch = new System.Windows.Forms.RadioButton();
            this.Radio_Clock = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Textbox_Record = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼옛체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gadget for study";
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(101, 93);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(92, 39);
            this.Button_Confirm.TabIndex = 2;
            this.Button_Confirm.Text = "Confirm";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(241, 93);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(90, 39);
            this.Button_Reset.TabIndex = 3;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Button_Record);
            this.groupBox1.Controls.Add(this.Radio_Timer);
            this.groupBox1.Controls.Add(this.Radio_Stopwatch);
            this.groupBox1.Controls.Add(this.Radio_Clock);
            this.groupBox1.Location = new System.Drawing.Point(386, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Textbox_Minute);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Textbox_Hour);
            this.groupBox2.Controls.Add(this.Textbox_Second);
            this.groupBox2.Location = new System.Drawing.Point(44, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(104, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // Textbox_Minute
            // 
            this.Textbox_Minute.Location = new System.Drawing.Point(74, 22);
            this.Textbox_Minute.Name = "Textbox_Minute";
            this.Textbox_Minute.Size = new System.Drawing.Size(24, 21);
            this.Textbox_Minute.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(55, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // Textbox_Hour
            // 
            this.Textbox_Hour.Location = new System.Drawing.Point(23, 22);
            this.Textbox_Hour.Name = "Textbox_Hour";
            this.Textbox_Hour.Size = new System.Drawing.Size(26, 21);
            this.Textbox_Hour.TabIndex = 3;
            // 
            // Textbox_Second
            // 
            this.Textbox_Second.Location = new System.Drawing.Point(123, 22);
            this.Textbox_Second.Name = "Textbox_Second";
            this.Textbox_Second.Size = new System.Drawing.Size(25, 21);
            this.Textbox_Second.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // Button_Record
            // 
            this.Button_Record.Location = new System.Drawing.Point(148, 75);
            this.Button_Record.Name = "Button_Record";
            this.Button_Record.Size = new System.Drawing.Size(75, 23);
            this.Button_Record.TabIndex = 4;
            this.Button_Record.Text = "Record";
            this.Button_Record.UseVisualStyleBackColor = true;
            this.Button_Record.Click += new System.EventHandler(this.Button_Record_Click);
            // 
            // Radio_Timer
            // 
            this.Radio_Timer.AutoSize = true;
            this.Radio_Timer.Location = new System.Drawing.Point(44, 114);
            this.Radio_Timer.Name = "Radio_Timer";
            this.Radio_Timer.Size = new System.Drawing.Size(56, 16);
            this.Radio_Timer.TabIndex = 2;
            this.Radio_Timer.TabStop = true;
            this.Radio_Timer.Text = "Timer";
            this.Radio_Timer.UseVisualStyleBackColor = true;
            // 
            // Radio_Stopwatch
            // 
            this.Radio_Stopwatch.AutoSize = true;
            this.Radio_Stopwatch.Location = new System.Drawing.Point(44, 78);
            this.Radio_Stopwatch.Name = "Radio_Stopwatch";
            this.Radio_Stopwatch.Size = new System.Drawing.Size(82, 16);
            this.Radio_Stopwatch.TabIndex = 1;
            this.Radio_Stopwatch.TabStop = true;
            this.Radio_Stopwatch.Text = "Stopwatch";
            this.Radio_Stopwatch.UseVisualStyleBackColor = true;
            // 
            // Radio_Clock
            // 
            this.Radio_Clock.AutoSize = true;
            this.Radio_Clock.Location = new System.Drawing.Point(44, 39);
            this.Radio_Clock.Name = "Radio_Clock";
            this.Radio_Clock.Size = new System.Drawing.Size(55, 16);
            this.Radio_Clock.TabIndex = 0;
            this.Radio_Clock.TabStop = true;
            this.Radio_Clock.Text = "Clock";
            this.Radio_Clock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(93, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Textbox_Record
            // 
            this.Textbox_Record.Location = new System.Drawing.Point(26, 272);
            this.Textbox_Record.Multiline = true;
            this.Textbox_Record.Name = "Textbox_Record";
            this.Textbox_Record.Size = new System.Drawing.Size(333, 114);
            this.Textbox_Record.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 512);
            this.Controls.Add(this.Textbox_Record);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Textbox_Hour;
        private System.Windows.Forms.RadioButton Radio_Timer;
        private System.Windows.Forms.RadioButton Radio_Stopwatch;
        private System.Windows.Forms.RadioButton Radio_Clock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Button_Record;
        private System.Windows.Forms.TextBox Textbox_Record;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox_Second;
        private System.Windows.Forms.TextBox Textbox_Minute;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

