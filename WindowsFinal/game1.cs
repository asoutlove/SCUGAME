using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFinal
{

    public partial class game1 : Form
    {
        int pR, pL;
        int wR, wL;
        Boolean music = true;
        Boolean bm = false;
        String uponShip; //以W,P判定人物;
        string shipLocation; // left, right
        String lastShipLocation;
        DateTime startTime;
        DateTime endTime;
        TimeSpan lastTime;
        public game1()
        {
            InitializeComponent();
        }

        private void game1_Load(object sender, EventArgs e)
        {
            picShip.Image = new Bitmap("images/ship.png");
                
            reLoad();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            reLoad();
            stop.Visible = true;
            lblContinue.Visible = false;
            picManR.Enabled = true;
            picWoofR.Enabled = true;
            startTime = DateTime.Now;
            timer1.Enabled = true;

        }

        

        private void reLoad()
        {
            pR = 3;
            pL = 0;
            wR = 3;
            wL = 0;
            uponShip = "00"; // there's no one in the ship
            shipLocation = "right";
            picShip.Left = 356;
            picL.Left = 317;
            picR.Left = 584;
            Go.Enabled = false;
            picL.Visible = false;
            picR.Visible = false;
            picL.Enabled = true;
            picR.Enabled = true;
            picWoofL.Enabled = false;
            picManL.Enabled = false;
            picManR.Enabled = false;
            picWoofR.Enabled = false;
            lastTime = (TimeSpan)(DateTime.Now - DateTime.Now);
            timer1.Enabled = false;
            lblTime.Text = "計時";
            stop.Visible = false;
            upDate();
        }

        /*********************************************************/

        private void 回主畫面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void 自訂音樂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //開啟開檔對話方塊，並判斷是否按下「開啟」鈕
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //表單標題顯示多媒體檔案路徑
                this.Text = openFileDialog1.FileName;
                //axWindowsMediaPlayer1播放開檔對話方塊所選擇的多媒體檔
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            }

            axWindowsMediaPlayer1.Visible = true;
        }

        private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music = false;
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music = true;
        }

        private void 遊戲說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遊戲目的：將三個人和三隻狼運到河的對岸\n" +
                            "遊戲限制：\n" +
                            "1. 在岸邊人數如果低於野狼數目，人就會被吃掉！\n" +
                            "2. 船一定要有人或狼才會開動\n" +
                            "3. 船一次最多只能載兩名乘客（包括人或狼）\n"
                            );
        }

        //兩岸的上船按鈕
        /**
        *呼叫 embark("man||woof") 來控制上船的是man || woof
        */

        private void picManR_Click(object sender, EventArgs e)
        {
            embark("man");
            upDate();
        }

        private void picWoofR_Click(object sender, EventArgs e)
        {
            embark("woof");
            upDate();
        }

        private void picManL_Click(object sender, EventArgs e)
        {
            embark("man");
            upDate();
        }

        private void picWoofL_Click(object sender, EventArgs e)
        {
            embark("woof");
            upDate();
        }
        /**********************************************************/

        //上船的是man || woof
        //船上要如何顯示

        private void embark(String type)
        {
            // 處理人物
            if (type == "man")
            {
                if (shipLocation == "right")
                {
                    pR--;
                    picManR.Image = new Bitmap("images/p" + pR.ToString() + ".png");
                }
                else
                {
                    pL--;
                    picManL.Image = new Bitmap("images/p" + pL.ToString() + ".png");
                }
            }
            else if (type == "woof")
            {
                if (shipLocation == "right")
                {
                    wR--;
                    picWoofR.Image = new Bitmap("images/w" + wR.ToString() + ".png");
                }
                else
                {
                    wL--;
                    picWoofL.Image = new Bitmap("images/w" + wL.ToString() + ".png");
                }
            }

            //處理船上人物
            if (uponShip == "00")
            { //無人
                if (type == "man")
                {
                    picL.Image = new Bitmap("images/P1.png");
                    picL.Visible = true;
                    picR.Visible = false;
                    uponShip = "P0";
                }
                else if (type == "woof")
                {
                    picL.Image = new Bitmap("images/W1.png");
                    picL.Visible = true;
                    picR.Visible = false;
                    uponShip = "W0";
                }
                controlRiparian(1, 1);
            }
            else if (uponShip == "W0")
            {//一隻狼
                if (type == "man")
                {
                    picL.Image = new Bitmap("images/W1.png");
                    picR.Image = new Bitmap("images/P1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "WP";
                }
                else
                {
                    picL.Image = new Bitmap("images/W1.png");
                    picR.Image = new Bitmap("images/W1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "WW";
                }
                controlRiparian(0, 0);
            }
            else if (uponShip == "0W")
            {
                if (type == "man")
                {
                    picL.Image = new Bitmap("images/P1.png");
                    picR.Image = new Bitmap("images/W1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "PW";
                }
                else
                {
                    picL.Image = new Bitmap("images/W1.png");
                    picR.Image = new Bitmap("images/W1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "WW";
                }
                controlRiparian(0, 0);
            }
            else if (uponShip == "P0")
            {
                if (type == "man")
                {
                    picL.Image = new Bitmap("images/P1.png");
                    picR.Image = new Bitmap("images/P1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "PP";
                }
                else
                {
                    picL.Image = new Bitmap("images/P1.png");
                    picR.Image = new Bitmap("images/W1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "PW";
                }
                controlRiparian(0, 0);
            }
            else if (uponShip == "0P")
            {
                if (type == "man")
                {
                    picL.Image = new Bitmap("images/P1.png");
                    picR.Image = new Bitmap("images/P1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "PP";
                }
                else
                {
                    picL.Image = new Bitmap("images/W1.png");
                    picR.Image = new Bitmap("images/P1.png");
                    picL.Visible = true;
                    picR.Visible = true;
                    uponShip = "WP";
                }
                controlRiparian(0, 0);
            }
        }

        private void controlRiparian(int i1, int i2)
        {
            //0=不可以按,1=可以按
            //左邊
            if (shipLocation == "left")
            {
                if (i1 == 0)
                {
                    picManL.Enabled = false;
                }
                else
                {
                    if (pL > 0)
                    {
                        picManL.Enabled = true;
                    }
                    else
                    {
                        picManL.Enabled = false;
                    }
                }

                if (i2 == 0)
                {
                    picWoofL.Enabled = false;
                }
                else
                {
                    if (wL > 0)
                    {
                        picWoofL.Enabled = true;
                    }
                    else
                    {
                        picWoofL.Enabled = false;
                    }
                }
            }
            else
            { //右邊
                if (i1 == 0)
                {
                    picManR.Enabled = false;
                }
                else
                {
                    if (pR > 0)
                    {
                        picManR.Enabled = true;
                    }
                    else
                    {
                        picManR.Enabled = false;
                    }
                }
                if (i2 == 0)
                {
                    picWoofR.Enabled = false;
                }
                else
                {
                    if (wR > 0)
                    {
                        picWoofR.Enabled = true;
                    }
                    else
                    {
                        picWoofR.Enabled = false;
                    }
                }
            }
        }

        //下船
        /**
        *呼叫disembark(left || right)控制下船的是船的哪一邊
        */
        private void picL_Click(object sender, EventArgs e)
        {
            disembark("left");
            upDate();
        }

        private void picR_Click(object sender, EventArgs e)
        {
            disembark("right");
            upDate();
        }

        /**
        *下船的那一方圖案會消失
        *判斷下船的是人還是狼，增加船所在之人物項目數量
        *下左邊船前情況:P0,PP,PW;WP,W0,WW
        *下右邊船前情況:0P,PP,WP;0W,WW,PW
        */
        private void disembark(String disDirection)
        {
            if (disDirection == "left")
            { //下左邊
                picL.Visible = false;
                if (uponShip == "P0" || uponShip == "PP" || uponShip == "PW")
                {
                    if (shipLocation == "left")
                    {
                        pL++;
                        picManL.Image = new Bitmap("images/p" + pL.ToString() + ".png");
                    }
                    else
                    {
                        pR++;
                        picManR.Image = new Bitmap("images/p" + pR.ToString() + ".png");
                    }

                    if (uponShip == "P0")
                    {
                        uponShip = "00";
                    }
                    else if (uponShip == "PP")
                    {
                        uponShip = "0P";
                    }
                    else
                    {
                        uponShip = "0W";
                    }
                }
                else if (uponShip == "WP" || uponShip == "W0" || uponShip == "WW")
                {
                    if (shipLocation == "left")
                    {
                        wL++;
                        picWoofL.Image = new Bitmap("images/w" + wL.ToString() + ".png");
                    }
                    else
                    {
                        wR++;
                        picWoofR.Image = new Bitmap("images/w" + wR.ToString() + ".png");
                    }

                    if (uponShip == "WP")
                    {
                        uponShip = "0P";
                    }
                    else if (uponShip == "W0")
                    {
                        uponShip = "00";
                    }
                    else
                    {
                        uponShip = "W0";
                    }
                }
            }
            else
            {//下右邊
                picR.Visible = false;
                if (uponShip == "0P" || uponShip == "PP" || uponShip == "WP")
                {
                    if (shipLocation == "left")
                    {
                        pL++;
                        picManL.Image = new Bitmap("images/p" + pL.ToString() + ".png");
                    }
                    else
                    {
                        pR++;
                        picManR.Image = new Bitmap("images/p" + pR.ToString() + ".png");
                    }

                    if (uponShip == "0P")
                    {
                        uponShip = "00";
                    }
                    else if (uponShip == "PP")
                    {
                        uponShip = "P0";
                    }
                    else
                    {
                        uponShip = "W0";
                    }
                }
                else if (uponShip == "PW" || uponShip == "0W" || uponShip == "WW")
                {
                    if (shipLocation == "left")
                    {
                        wL++;
                        picWoofL.Image = new Bitmap("images/w" + wL.ToString() + ".png");
                    }
                    else
                    {
                        wR++;
                        picWoofR.Image = new Bitmap("images/w" + wR.ToString() + ".png");
                    }

                    if (uponShip == "PW")
                    {
                        uponShip = "P0";
                    }
                    else if (uponShip == "WW")
                    {
                        uponShip = "W0";
                    }
                    else
                    {
                        uponShip = "00";
                    }
                }
            }

            if (uponShip != "PW" || uponShip != "WP" || uponShip != "WW" || uponShip != "PP")
            {
                if (shipLocation == "left")
                {
                    if (pL > 0) { picManL.Enabled = true; }
                    if (wL > 0) { picWoofL.Enabled = true; }
                }
                else
                {
                    if (pR > 0) { picManR.Enabled = true; }
                    if (wR > 0) { picWoofR.Enabled = true; }
                }
            }
        }

        //每次上下船人物變動便啟動upDate來更新兩岸人數
        //船上人數不夠不能按GO

        private void upDate()
        {
            //人數不夠出發不能按GO
            if (uponShip != "00")
            {
                Go.Enabled = true;
            }
            else
            {
                Go.Enabled = false;
            }


            //顯示雙邊人數
            picManR.Image = new Bitmap("images/p" + pR.ToString() + ".png");
            picWoofR.Image = new Bitmap("images/w" + wR.ToString() + ".png");
            picManL.Image = new Bitmap("images/p" + pL.ToString() + ".png");
            picWoofL.Image = new Bitmap("images/w" + wL.ToString() + ".png");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            endTime = DateTime.Now;
            lblTime.Text = ((TimeSpan)((endTime - startTime) + lastTime)).ToString(@"hh\:mm\:ss\.ff");
        }


        //改變船的位置
        //呼叫timer2
        private void Go_Click(object sender, EventArgs e)
        {
            //船的位置轉換
            if (shipLocation == "left"){
                shipLocation = "right";
            }

            else
            {
                shipLocation = "left";
            }

            Go.Enabled = false;
            picL.Enabled = false;
            picR.Enabled = false;
            timer2.Enabled = true;
            Start.Visible = false;
        }

        //呈現船的移動並呼叫afterGo
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (shipLocation == "left") //這裡的shipLocation指的是出發的位置
            {
                if (picShip.Left >= 210)
                {
                    picShip.Left -= 20;
                    picL.Left -= 20;
                    picR.Left -= 20;
                    if (music == true)
                    {
                        music2();
                    }
                }
                else
                {
                    afterGo_Click();
                }
            }
            else
            {
                if (picShip.Left <= 350)
                {
                    picShip.Left += 20;
                    picL.Left += 20;
                    picR.Left += 20;
                    if (music == true)
                    {
                        music2();
                    }
                }
                else
                {
                    afterGo_Click();
                }
            }
            
        }

        private void music2()
        {
            axWindowsMediaPlayer2.URL = "music/shipS.mp3";
        }

        //放下船上的所有人,改變該岸的人數
        private void afterGo_Click()
        {
            if (uponShip != "00")
            {
                timer2.Enabled = false;
                if (uponShip == "0W" || uponShip == "W0" || uponShip == "WW")
                {//無man
                    if (shipLocation == "left")
                    {
                        wL++;
                        if (uponShip == "WW") { wL++; }
                    }
                    else
                    {
                        wR++;
                        if (uponShip == "WW") { wR++; }
                    }
                }
                else
                { //有man
                    if (shipLocation == "left")
                    {
                        pL++;
                        if (uponShip == "PP")
                        {
                            pL++;
                        }
                        else if (uponShip != "0P" && uponShip != "P0")
                        {
                            wL++;
                        }
                    }
                    else
                    {//船靠右岸
                        pR++;
                        if (uponShip == "PP")
                        {
                            pR++;
                        }
                        else if (uponShip != "0P" && uponShip != "P0")
                        {
                            wR++;
                        }
                    }
                }
                uponShip = "00";
                picL.Visible = false;
                picR.Visible = false;
                picL.Enabled = true;
                picR.Enabled = true;
                Start.Visible = true;
                upDate();
                afterDisembark();
            }
        }

        //船靠岸後
        public void afterDisembark()
        {
            //船在哪邊 則另一邊不能按
            if (shipLocation == "left")
            {
                picManR.Enabled = false;
                picWoofR.Enabled = false;
                if (pL > 0)
                {
                    picManL.Enabled = true;
                }
                else
                {
                    picManL.Enabled = false;
                }

                if (wL > 0)
                {
                    picWoofL.Enabled = true;
                }
                else
                {
                    picWoofL.Enabled = false;
                }
            }
            else
            {
                picManL.Enabled = false;
                picWoofL.Enabled = false;
                if (pR > 0)
                {
                    picManR.Enabled = true;
                }
                else
                {
                    picManR.Enabled = false;
                }

                if (wR > 0)
                {
                    picWoofR.Enabled = true;
                }
                else
                {
                    picWoofR.Enabled = false;
                }
            }

            if (pL == 3 && wL == 3)
            {
                timer1.Enabled = false;
                String[] str = lblTime.Text.Split(':');
                String w;
                int m = int.Parse(str[1]);
                double s = double.Parse(str[2]) + (m * 60);
                if (s < 80)
                {
                    w = "YOU WIN!!! 還有什麼能難倒你?!!!!";
                }
                else if (s < 100)
                {
                    w = "YOU WIN!!! 你是過河高手!!!";
                }
                else
                {
                    w = "YOU WIN!!! 還不賴喔!!!";
                }
                MessageBox.Show("總共花了"+s+"秒\n"+w);
               
                reLoad();
            }
            else if (((pL < wL) && pL != 0) || ((pR < wR) && pR != 0))
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOSE！再玩一次吧!");
                reLoad();
            }
        }

        private void 音樂1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Background Music 1 ---- Planning";
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = "music/bm1.mp3";
            bm = true;

        }

        private void 音樂2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Game1";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
            bm = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            stop.Visible = false;
            lblContinue.Visible = true;
            lastTime += (TimeSpan)(endTime - startTime);
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Enabled = true;
            timer2.Enabled = true;
            lblContinue.Visible = false;
            stop.Visible = true;
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            if (bm == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play(); 
            }
        }


    }
}
