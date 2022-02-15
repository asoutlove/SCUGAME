namespace WindowsFinal
{
    partial class game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲選單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回主畫面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音樂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂音樂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音樂1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音樂2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遊戲說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.picManR = new System.Windows.Forms.PictureBox();
            this.picWoofR = new System.Windows.Forms.PictureBox();
            this.picManL = new System.Windows.Forms.PictureBox();
            this.picWoofL = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picShip = new System.Windows.Forms.PictureBox();
            this.picL = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            this.Go = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWoofR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWoofL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲選單ToolStripMenuItem,
            this.背景音效ToolStripMenuItem,
            this.遊戲說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲選單ToolStripMenuItem
            // 
            this.遊戲選單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.回主畫面ToolStripMenuItem});
            this.遊戲選單ToolStripMenuItem.Name = "遊戲選單ToolStripMenuItem";
            this.遊戲選單ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.遊戲選單ToolStripMenuItem.Text = "遊戲選單";
            // 
            // 回主畫面ToolStripMenuItem
            // 
            this.回主畫面ToolStripMenuItem.Name = "回主畫面ToolStripMenuItem";
            this.回主畫面ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.回主畫面ToolStripMenuItem.Text = "回主畫面";
            this.回主畫面ToolStripMenuItem.Click += new System.EventHandler(this.回主畫面ToolStripMenuItem_Click);
            // 
            // 背景音效ToolStripMenuItem
            // 
            this.背景音效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景音樂ToolStripMenuItem,
            this.音效ToolStripMenuItem});
            this.背景音效ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.背景音效ToolStripMenuItem.Name = "背景音效ToolStripMenuItem";
            this.背景音效ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.背景音效ToolStripMenuItem.Text = "背景音效";
            // 
            // 背景音樂ToolStripMenuItem
            // 
            this.背景音樂ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.背景音樂ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂音樂ToolStripMenuItem,
            this.音樂1ToolStripMenuItem,
            this.音樂2ToolStripMenuItem});
            this.背景音樂ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.背景音樂ToolStripMenuItem.Name = "背景音樂ToolStripMenuItem";
            this.背景音樂ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.背景音樂ToolStripMenuItem.Text = "背景音樂";
            // 
            // 自訂音樂ToolStripMenuItem
            // 
            this.自訂音樂ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.自訂音樂ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.自訂音樂ToolStripMenuItem.Name = "自訂音樂ToolStripMenuItem";
            this.自訂音樂ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.自訂音樂ToolStripMenuItem.Text = "自訂音樂";
            this.自訂音樂ToolStripMenuItem.Click += new System.EventHandler(this.自訂音樂ToolStripMenuItem_Click);
            // 
            // 音樂1ToolStripMenuItem
            // 
            this.音樂1ToolStripMenuItem.Name = "音樂1ToolStripMenuItem";
            this.音樂1ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.音樂1ToolStripMenuItem.Text = "音樂1";
            this.音樂1ToolStripMenuItem.Click += new System.EventHandler(this.音樂1ToolStripMenuItem_Click);
            // 
            // 音樂2ToolStripMenuItem
            // 
            this.音樂2ToolStripMenuItem.Name = "音樂2ToolStripMenuItem";
            this.音樂2ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.音樂2ToolStripMenuItem.Text = "關閉音樂";
            this.音樂2ToolStripMenuItem.Click += new System.EventHandler(this.音樂2ToolStripMenuItem_Click);
            // 
            // 音效ToolStripMenuItem
            // 
            this.音效ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.音效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem,
            this.關閉ToolStripMenuItem});
            this.音效ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.音效ToolStripMenuItem.Name = "音效ToolStripMenuItem";
            this.音效ToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.音效ToolStripMenuItem.Text = "音效";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.開啟ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // 關閉ToolStripMenuItem
            // 
            this.關閉ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.關閉ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem";
            this.關閉ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.關閉ToolStripMenuItem.Text = "關閉";
            this.關閉ToolStripMenuItem.Click += new System.EventHandler(this.關閉ToolStripMenuItem_Click);
            // 
            // 遊戲說明ToolStripMenuItem
            // 
            this.遊戲說明ToolStripMenuItem.Name = "遊戲說明ToolStripMenuItem";
            this.遊戲說明ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.遊戲說明ToolStripMenuItem.Text = "遊戲說明";
            this.遊戲說明ToolStripMenuItem.Click += new System.EventHandler(this.遊戲說明ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(299, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(35, 32);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // picManR
            // 
            this.picManR.BackColor = System.Drawing.Color.Transparent;
            this.picManR.Location = new System.Drawing.Point(773, 101);
            this.picManR.Name = "picManR";
            this.picManR.Size = new System.Drawing.Size(215, 250);
            this.picManR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManR.TabIndex = 2;
            this.picManR.TabStop = false;
            this.picManR.Click += new System.EventHandler(this.picManR_Click);
            // 
            // picWoofR
            // 
            this.picWoofR.BackColor = System.Drawing.Color.Transparent;
            this.picWoofR.Location = new System.Drawing.Point(778, 366);
            this.picWoofR.Name = "picWoofR";
            this.picWoofR.Size = new System.Drawing.Size(207, 132);
            this.picWoofR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWoofR.TabIndex = 3;
            this.picWoofR.TabStop = false;
            this.picWoofR.Click += new System.EventHandler(this.picWoofR_Click);
            // 
            // picManL
            // 
            this.picManL.BackColor = System.Drawing.Color.Transparent;
            this.picManL.Location = new System.Drawing.Point(0, 103);
            this.picManL.Name = "picManL";
            this.picManL.Size = new System.Drawing.Size(178, 250);
            this.picManL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManL.TabIndex = 4;
            this.picManL.TabStop = false;
            this.picManL.Click += new System.EventHandler(this.picManL_Click);
            // 
            // picWoofL
            // 
            this.picWoofL.BackColor = System.Drawing.Color.Transparent;
            this.picWoofL.Location = new System.Drawing.Point(1, 387);
            this.picWoofL.Name = "picWoofL";
            this.picWoofL.Size = new System.Drawing.Size(207, 132);
            this.picWoofL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWoofL.TabIndex = 5;
            this.picWoofL.TabStop = false;
            this.picWoofL.Click += new System.EventHandler(this.picWoofL_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Start.Location = new System.Drawing.Point(156, 54);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 26);
            this.Start.TabIndex = 6;
            this.Start.Text = "遊戲開始";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stop.Location = new System.Drawing.Point(330, 54);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(50, 26);
            this.stop.TabIndex = 7;
            this.stop.Text = "暫停";
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picShip
            // 
            this.picShip.BackColor = System.Drawing.Color.Transparent;
            this.picShip.Location = new System.Drawing.Point(356, 302);
            this.picShip.Name = "picShip";
            this.picShip.Size = new System.Drawing.Size(379, 196);
            this.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShip.TabIndex = 8;
            this.picShip.TabStop = false;
            // 
            // picL
            // 
            this.picL.BackColor = System.Drawing.Color.Transparent;
            this.picL.Cursor = System.Windows.Forms.Cursors.Default;
            this.picL.Location = new System.Drawing.Point(317, 97);
            this.picL.Name = "picL";
            this.picL.Size = new System.Drawing.Size(188, 297);
            this.picL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picL.TabIndex = 9;
            this.picL.TabStop = false;
            this.picL.Click += new System.EventHandler(this.picL_Click);
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.Color.Transparent;
            this.picR.Location = new System.Drawing.Point(584, 97);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(188, 297);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picR.TabIndex = 10;
            this.picR.TabStop = false;
            this.picR.Click += new System.EventHandler(this.picR_Click);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Silver;
            this.Go.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Go.Location = new System.Drawing.Point(584, 51);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(81, 31);
            this.Go.TabIndex = 11;
            this.Go.Text = "船開動";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(337, 0);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(37, 32);
            this.axWindowsMediaPlayer2.TabIndex = 12;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(721, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(198, 33);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "計時";
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContinue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContinue.Location = new System.Drawing.Point(262, 54);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(50, 26);
            this.lblContinue.TabIndex = 14;
            this.lblContinue.Text = "繼續";
            this.lblContinue.Visible = false;
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.picL);
            this.Controls.Add(this.picShip);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.picWoofL);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.picManL);
            this.Controls.Add(this.picWoofR);
            this.Controls.Add(this.picManR);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "game1";
            this.Text = "game1";
            this.Load += new System.EventHandler(this.game1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWoofR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWoofL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲選單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回主畫面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景音樂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂音樂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音樂1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音樂2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 遊戲說明ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox picManR;
        private System.Windows.Forms.PictureBox picWoofR;
        private System.Windows.Forms.PictureBox picManL;
        private System.Windows.Forms.PictureBox picWoofL;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picShip;
        private System.Windows.Forms.PictureBox picL;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.Button Go;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Timer timer2;
    }
}