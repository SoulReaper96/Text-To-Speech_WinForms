namespace Text_To_Speech_Forms
{
    partial class TextToSpeech
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToSpeech));
            panel1 = new Panel();
            BtnResume = new Button();
            BtnPause = new Button();
            BtnStop = new Button();
            BtnSpeak = new Button();
            BtnOpen = new Button();
            RtbBox = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(BtnResume);
            panel1.Controls.Add(BtnPause);
            panel1.Controls.Add(BtnStop);
            panel1.Controls.Add(BtnSpeak);
            panel1.Controls.Add(BtnOpen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 78);
            panel1.TabIndex = 0;
            // 
            // BtnResume
            // 
            BtnResume.Location = new Point(216, 12);
            BtnResume.Name = "BtnResume";
            BtnResume.Size = new Size(62, 53);
            BtnResume.TabIndex = 4;
            BtnResume.Text = "Resume";
            BtnResume.UseVisualStyleBackColor = true;
            BtnResume.Click += BtnResume_Click;
            // 
            // BtnPause
            // 
            BtnPause.Location = new Point(148, 12);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(62, 53);
            BtnPause.TabIndex = 3;
            BtnPause.Text = "Pause";
            BtnPause.UseVisualStyleBackColor = true;
            BtnPause.Click += BtnPause_Click;
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(284, 12);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(62, 53);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnSpeak
            // 
            BtnSpeak.BackgroundImage = Properties.Resources.voice_control;
            BtnSpeak.BackgroundImageLayout = ImageLayout.Center;
            BtnSpeak.FlatStyle = FlatStyle.System;
            BtnSpeak.Image = (Image)resources.GetObject("BtnSpeak.Image");
            BtnSpeak.Location = new Point(80, 12);
            BtnSpeak.Name = "BtnSpeak";
            BtnSpeak.Size = new Size(62, 53);
            BtnSpeak.TabIndex = 1;
            BtnSpeak.Text = "Speak";
            BtnSpeak.UseVisualStyleBackColor = true;
            BtnSpeak.Click += BtnSpeak_Click;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(12, 12);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(62, 53);
            BtnOpen.TabIndex = 0;
            BtnOpen.Text = "Open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // RtbBox
            // 
            RtbBox.BackColor = Color.DarkGray;
            RtbBox.Location = new Point(12, 84);
            RtbBox.Name = "RtbBox";
            RtbBox.Size = new Size(702, 420);
            RtbBox.TabIndex = 1;
            RtbBox.Text = "";
            // 
            // timer1
            // 
            timer1.Interval = 150;
            timer1.Tick += timer1_Tick;
            // 
            // TextToSpeech
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(726, 516);
            Controls.Add(RtbBox);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F);
            Name = "TextToSpeech";
            Text = "Text To Speech";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnResume;
        private Button BtnPause;
        private Button BtnStop;
        private Button BtnSpeak;
        private Button BtnOpen;
        private RichTextBox RtbBox;
        private System.Windows.Forms.Timer timer1;
    }
}
