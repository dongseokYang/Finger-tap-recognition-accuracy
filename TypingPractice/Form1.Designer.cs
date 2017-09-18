namespace TypingPractice
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_current = new System.Windows.Forms.Label();
            this.label_forward = new System.Windows.Forms.Label();
            this.label_backward = new System.Windows.Forms.Label();
            this.label_true = new System.Windows.Forms.Label();
            this.label_false = new System.Windows.Forms.Label();
            this.label_tpm = new System.Windows.Forms.Label();
            this.pic_tf = new System.Windows.Forms.PictureBox();
            this.pic_hand = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_finger0 = new System.Windows.Forms.PictureBox();
            this.pic_finger1 = new System.Windows.Forms.PictureBox();
            this.pic_finger2 = new System.Windows.Forms.PictureBox();
            this.pic_finger3 = new System.Windows.Forms.PictureBox();
            this.pic_finger4 = new System.Windows.Forms.PictureBox();
            this.pic_finger5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_current.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.label_current.ForeColor = System.Drawing.Color.Black;
            this.label_current.Location = new System.Drawing.Point(510, 79);
            this.label_current.MinimumSize = new System.Drawing.Size(260, 60);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(260, 60);
            this.label_current.TabIndex = 0;
            this.label_current.Text = "backspace";
            this.label_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_forward
            // 
            this.label_forward.AutoSize = true;
            this.label_forward.Font = new System.Drawing.Font("굴림", 28F);
            this.label_forward.ForeColor = System.Drawing.Color.Black;
            this.label_forward.Location = new System.Drawing.Point(795, 89);
            this.label_forward.MaximumSize = new System.Drawing.Size(450, 40);
            this.label_forward.MinimumSize = new System.Drawing.Size(450, 40);
            this.label_forward.Name = "label_forward";
            this.label_forward.Size = new System.Drawing.Size(450, 40);
            this.label_forward.TabIndex = 1;
            this.label_forward.Text = "▶  A  ▶  Backspace";
            this.label_forward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_backward
            // 
            this.label_backward.AutoEllipsis = true;
            this.label_backward.AutoSize = true;
            this.label_backward.Font = new System.Drawing.Font("굴림", 22F);
            this.label_backward.ForeColor = System.Drawing.Color.DarkGray;
            this.label_backward.Location = new System.Drawing.Point(49, 89);
            this.label_backward.MaximumSize = new System.Drawing.Size(450, 40);
            this.label_backward.MinimumSize = new System.Drawing.Size(450, 40);
            this.label_backward.Name = "label_backward";
            this.label_backward.Size = new System.Drawing.Size(450, 40);
            this.label_backward.TabIndex = 2;
            this.label_backward.Text = "A  ▶  Backspace  ▶";
            this.label_backward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_true
            // 
            this.label_true.AutoSize = true;
            this.label_true.Font = new System.Drawing.Font("굴림", 20F);
            this.label_true.ForeColor = System.Drawing.Color.Black;
            this.label_true.Location = new System.Drawing.Point(924, 592);
            this.label_true.MinimumSize = new System.Drawing.Size(50, 40);
            this.label_true.Name = "label_true";
            this.label_true.Size = new System.Drawing.Size(100, 40);
            this.label_true.TabIndex = 5;
            this.label_true.Text = "정답: 0";
            this.label_true.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_false
            // 
            this.label_false.AutoSize = true;
            this.label_false.Font = new System.Drawing.Font("굴림", 20F);
            this.label_false.ForeColor = System.Drawing.Color.Black;
            this.label_false.Location = new System.Drawing.Point(1079, 592);
            this.label_false.MinimumSize = new System.Drawing.Size(50, 40);
            this.label_false.Name = "label_false";
            this.label_false.Size = new System.Drawing.Size(100, 40);
            this.label_false.TabIndex = 7;
            this.label_false.Text = "오답: 0";
            this.label_false.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tpm
            // 
            this.label_tpm.AutoSize = true;
            this.label_tpm.Font = new System.Drawing.Font("굴림", 20F);
            this.label_tpm.ForeColor = System.Drawing.Color.Black;
            this.label_tpm.Location = new System.Drawing.Point(240, 28);
            this.label_tpm.MinimumSize = new System.Drawing.Size(800, 40);
            this.label_tpm.Name = "label_tpm";
            this.label_tpm.Size = new System.Drawing.Size(800, 40);
            this.label_tpm.TabIndex = 8;
            this.label_tpm.Text = "정답: 0";
            this.label_tpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_tf
            // 
            this.pic_tf.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_tf.Location = new System.Drawing.Point(929, 339);
            this.pic_tf.Name = "pic_tf";
            this.pic_tf.Size = new System.Drawing.Size(250, 250);
            this.pic_tf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_tf.TabIndex = 6;
            this.pic_tf.TabStop = false;
            // 
            // pic_hand
            // 
            this.pic_hand.Image = global::TypingPractice.Properties.Resources.handR_t;
            this.pic_hand.Location = new System.Drawing.Point(0, 0);
            this.pic_hand.Name = "pic_hand";
            this.pic_hand.Size = new System.Drawing.Size(460, 540);
            this.pic_hand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hand.TabIndex = 4;
            this.pic_hand.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pic_finger0
            // 
            this.pic_finger0.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger0.BackgroundImage")));
            this.pic_finger0.ErrorImage = null;
            this.pic_finger0.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger0.InitialImage = null;
            this.pic_finger0.Location = new System.Drawing.Point(12, 299);
            this.pic_finger0.Name = "pic_finger0";
            this.pic_finger0.Size = new System.Drawing.Size(50, 50);
            this.pic_finger0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger0.TabIndex = 9;
            this.pic_finger0.TabStop = false;
            // 
            // pic_finger1
            // 
            this.pic_finger1.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger1.BackgroundImage")));
            this.pic_finger1.ErrorImage = null;
            this.pic_finger1.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger1.InitialImage = null;
            this.pic_finger1.Location = new System.Drawing.Point(60, 243);
            this.pic_finger1.Name = "pic_finger1";
            this.pic_finger1.Size = new System.Drawing.Size(50, 50);
            this.pic_finger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger1.TabIndex = 10;
            this.pic_finger1.TabStop = false;
            // 
            // pic_finger2
            // 
            this.pic_finger2.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger2.BackgroundImage")));
            this.pic_finger2.ErrorImage = null;
            this.pic_finger2.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger2.InitialImage = null;
            this.pic_finger2.Location = new System.Drawing.Point(142, 62);
            this.pic_finger2.Name = "pic_finger2";
            this.pic_finger2.Size = new System.Drawing.Size(50, 50);
            this.pic_finger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger2.TabIndex = 11;
            this.pic_finger2.TabStop = false;
            // 
            // pic_finger3
            // 
            this.pic_finger3.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger3.BackgroundImage")));
            this.pic_finger3.ErrorImage = null;
            this.pic_finger3.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger3.InitialImage = null;
            this.pic_finger3.Location = new System.Drawing.Point(240, 21);
            this.pic_finger3.Name = "pic_finger3";
            this.pic_finger3.Size = new System.Drawing.Size(50, 50);
            this.pic_finger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger3.TabIndex = 12;
            this.pic_finger3.TabStop = false;
            // 
            // pic_finger4
            // 
            this.pic_finger4.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger4.BackgroundImage")));
            this.pic_finger4.ErrorImage = null;
            this.pic_finger4.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger4.InitialImage = null;
            this.pic_finger4.Location = new System.Drawing.Point(317, 49);
            this.pic_finger4.Name = "pic_finger4";
            this.pic_finger4.Size = new System.Drawing.Size(50, 50);
            this.pic_finger4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger4.TabIndex = 13;
            this.pic_finger4.TabStop = false;
            // 
            // pic_finger5
            // 
            this.pic_finger5.BackColor = System.Drawing.Color.Transparent;
            this.pic_finger5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_finger5.BackgroundImage")));
            this.pic_finger5.ErrorImage = null;
            this.pic_finger5.Image = global::TypingPractice.Properties.Resources.circle_disable;
            this.pic_finger5.InitialImage = null;
            this.pic_finger5.Location = new System.Drawing.Point(405, 133);
            this.pic_finger5.Name = "pic_finger5";
            this.pic_finger5.Size = new System.Drawing.Size(50, 50);
            this.pic_finger5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_finger5.TabIndex = 14;
            this.pic_finger5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 603);
            this.label1.MinimumSize = new System.Drawing.Size(216, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 95);
            this.label1.TabIndex = 16;
            this.label1.Text = "다시 시작";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_finger5);
            this.Controls.Add(this.pic_finger4);
            this.Controls.Add(this.pic_finger3);
            this.Controls.Add(this.pic_finger2);
            this.Controls.Add(this.pic_finger1);
            this.Controls.Add(this.pic_finger0);
            this.Controls.Add(this.label_tpm);
            this.Controls.Add(this.label_false);
            this.Controls.Add(this.pic_tf);
            this.Controls.Add(this.label_true);
            this.Controls.Add(this.pic_hand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_backward);
            this.Controls.Add(this.label_forward);
            this.Controls.Add(this.label_current);
            this.Name = "Form1";
            this.Text = "Typing Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_tf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_finger5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Label label_forward;
        private System.Windows.Forms.Label label_backward;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_hand;
        private System.Windows.Forms.Label label_true;
        private System.Windows.Forms.PictureBox pic_tf;
        private System.Windows.Forms.Label label_false;
        private System.Windows.Forms.Label label_tpm;
        private System.Windows.Forms.PictureBox pic_finger0;
        private System.Windows.Forms.PictureBox pic_finger1;
        private System.Windows.Forms.PictureBox pic_finger2;
        private System.Windows.Forms.PictureBox pic_finger3;
        private System.Windows.Forms.PictureBox pic_finger4;
        private System.Windows.Forms.PictureBox pic_finger5;
        private System.Windows.Forms.Label label1;
    }
}

