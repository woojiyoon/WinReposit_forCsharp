namespace TypingABC
{
    partial class frmMain
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
            this.rtxSentence = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.panBoard = new System.Windows.Forms.Panel();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxSentence
            // 
            this.rtxSentence.Location = new System.Drawing.Point(0, 3);
            this.rtxSentence.Name = "rtxSentence";
            this.rtxSentence.ReadOnly = true;
            this.rtxSentence.Size = new System.Drawing.Size(560, 185);
            this.rtxSentence.TabIndex = 0;
            this.rtxSentence.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(3, 218);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(560, 21);
            this.txtInput.TabIndex = 0;
            this.txtInput.CursorChanged += new System.EventHandler(this.frmMain_Load);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(246, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 12);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblName1.Location = new System.Drawing.Point(53, 312);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(38, 12);
            this.lblName1.TabIndex = 3;
            this.lblName1.Text = "label1";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(113, 312);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 12);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "label2";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(246, 312);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(38, 12);
            this.lblName2.TabIndex = 5;
            this.lblName2.Text = "label3";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(300, 312);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(38, 12);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "label4";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(412, 312);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(38, 12);
            this.lblName3.TabIndex = 7;
            this.lblName3.Text = "label5";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(491, 312);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(38, 12);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.Text = "label6";
            // 
            // panBoard
            // 
            this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panBoard.Controls.Add(this.rtxSentence);
            this.panBoard.Controls.Add(this.txtInput);
            this.panBoard.Location = new System.Drawing.Point(12, 30);
            this.panBoard.Name = "panBoard";
            this.panBoard.Size = new System.Drawing.Size(570, 257);
            this.panBoard.TabIndex = 9;
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "산성비게임설정버튼 영역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "난이도 상 중 하";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panBoard);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Speed Up";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panBoard.ResumeLayout(false);
            this.panBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxSentence;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel panBoard;
        private System.Windows.Forms.Timer tmTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

