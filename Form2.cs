using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongGame
{
    class CActorBack2
    {
        public Rectangle rcSrc;
        public Rectangle rcDst;
        public Bitmap im;

    }

    public class CActorDoor2
    {
        public int X, Y, W, H;
        public Bitmap im;

    }

    public class CActorMan2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public int gravity;
    }
    public class CActorSpikeball2
    {
        public int X, Y, W, H;
        public Bitmap im;


    }

    public class CActorplane2
    {
        public int X, Y;
        public int W, H;
        public Bitmap im;
    }
    public class CActorLaser2
    {
        public int X, Y;
        public int W, H;
        public Bitmap im;
    }
    public class CActorEnemy2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }

    public class CActorGround2
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorLife2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorWarning2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }

    public class CActorMoveCoin2
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorCoin2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public int ctC;

    }
    public class CActorCoinBar2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorMoveGem
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorGem
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorMoveFlag2
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorFlag2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorPendule2
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }
    public class CActorElevator2
    {
        public int X, Y;
        public int W, H;
        public Bitmap im;

    }
    public class CActorSpike2
    {
        public int X, Y;
        public int W, H;
        public Bitmap im;

    }
    public class CActorBridge2
    {
        public int X, Y;
        public int W, H;
        public Bitmap im;

    }

    public class CActorBullets2
    {
        public int X, Y;
        public int W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public bool isMove;
        public int bSide;

    }
    public class CActorWin
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorGameover
    {
        public int X, Y, W, H;
        public Bitmap im;

    }


    public partial class Form2 : Form
    {
        Bitmap off;
        Timer tt = new Timer();
        int YScroll = 1435, XScroll = 0, ctTick2 = 0;
        bool keyLeft = false, keyRight = false, keySpace = false, keySmall = false, keyEnter = false, keyS = false, keyF = false;
        int w = 0, a = 10, b = 105, e = 0, p = 0, eSide = 0;
        int jump = 0, gravityFall = 10, mF = 0, flip = 0;
        bool onGround = false;
        bool elevatorUp = true, man2elevator = false, slowDown = false, spikemove = true, spikeballUp = true, spikeballDown = true, tookGem = false, laserOn = false;
        bool smallMan = false;
        int previousElevator2Y;
        int mW = 0, mJ = 0, mSide = 0;
        int kill2 = 0, ctf = 0, ctcoin = 0, ctG = 0, bulletSide = 0, de = 0;
        bool singleB = false;
        int ctW2 = 0;
        int yLaser1 = 1910, yLaser2 = 1910, ctCreateL = 0, ctRemoveL = 0;
        bool createLaser = false, removeLaser = false;

        List<CActorBack2> back2 = new List<CActorBack2>();
        List<CActorGround2> ground2 = new List<CActorGround2>();
        List<CActorMan2> man2 = new List<CActorMan2>();
        List<CActorSpikeball2> spikeball2 = new List<CActorSpikeball2>();
        List<CActorplane2> plane2 = new List<CActorplane2>();
        List<CActorLaser2> laser21 = new List<CActorLaser2>();
        List<CActorLaser2> laser22 = new List<CActorLaser2>();
        List<CActorWin> win2 = new List<CActorWin>();
        List<CActorGameover> gameover2 = new List<CActorGameover>();
        List<CActorDoor2> door2 = new List<CActorDoor2>();

        List<CActorEnemy2> enemy2 = new List<CActorEnemy2>();
        List<CActorPendule2> pendule2 = new List<CActorPendule2>();
        List<CActorElevator2> elevator2 = new List<CActorElevator2>();
        List<CActorSpike2> spike2 = new List<CActorSpike2>();
        List<CActorBridge2> bridge2 = new List<CActorBridge2>();
        List<CActorCoinBar2> coinBar2 = new List<CActorCoinBar2>();

        //coin on the 1st tower
        List<CActorCoin2> coin2TF = new List<CActorCoin2>();
        //coins on the block
        List<CActorMoveCoin2> moveCoin2 = new List<CActorMoveCoin2>();
        List<CActorCoin2> coin2 = new List<CActorCoin2>();
        //coin on the 2nd tower
        List<CActorCoin2> coin2TS = new List<CActorCoin2>();
        //finish flag
        List<CActorFlag2> flag2 = new List<CActorFlag2>();
        //gem
        List<CActorGem> gem = new List<CActorGem>();
        //bullets
        List<CActorBullets2> multipleBullets2 = new List<CActorBullets2>();
        List<CActorBullets2> singleBullets2 = new List<CActorBullets2>();


        List<CActorLife2> life2 = new List<CActorLife2>();
        List<CActorWarning2> warning2 = new List<CActorWarning2>();


        public Form2()
        {
            this.Size = new Size(400, 600);
            //this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(450, 0);
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            tt.Interval = 100;
            tt.Start();
            tt.Tick += Tt_Tick2;
        }

        private void Tt_Tick2(object sender, EventArgs e)
        {
            this.Text = $"x: {man2[0].X} ,,, y: {man2[0].Y}";

            if (man2[0].X == 840)
            {
                XScroll = man2[0].X - 70;

            }
            //if (man2[0].X == 1400)
            //{
            //    XScroll = man2[0].X - 70;
            //}

            if (keyRight)
            {
                if (man2[0].X + man2[0].W + 5 < 2265)
                {
                    if (!slowDown)
                    {
                        XScroll += 5;
                        if (mW == 0)
                        {
                            man2[0].iFrame = 1;
                            man2[0].X += 5;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man2[0].iFrame = 2;
                            man2[0].X += 5;
                            mW = 0;
                        }
                    }
                    else if (slowDown)
                    {
                        XScroll += 2;
                        if (mW == 0)
                        {
                            man2[0].iFrame = 1;
                            man2[0].X += 2;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man2[0].iFrame = 2;
                            man2[0].X += 2;
                            mW = 0;
                        }
                    }
                }
                mSide = 0;
            }

            if (keyLeft)
            {
                if (man2[0].X - 25 > 0)
                {
                    if (!slowDown)
                    {

                        XScroll -= 5;
                        if (mW == 0)
                        {
                            man2[0].iFrame = 8;
                            man2[0].X -= 5;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man2[0].iFrame = 9;
                            man2[0].X -= 5;
                            mW = 0;
                        }
                    }
                    else if (slowDown)
                    {
                        XScroll -= 2;
                        if (mW == 0)
                        {
                            man2[0].iFrame = 8;
                            man2[0].X -= 2;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man2[0].iFrame = 9;
                            man2[0].X -= 2;
                            mW = 0;
                        }
                    }
                }
                mSide = 1;

            }

            if (keySpace)
            {
                jump = 1;
                mJ = 0;
            }

            if (jump == 1)
            {
                ManJump2();

            }

            if (keySmall && ((man2[0].Y <= 1892 && man2[0].Y >= 1888) || (man2[0].Y <= 1927 && man2[0].Y >= 1923)))
            {
                if (ctcoin >= 4 && !smallMan)
                {
                    smallMan = true;
                }
                else if (smallMan && ctcoin > 4)
                {
                    smallMan = false;
                }
            }


            if (smallMan)
            {
                man2[0].W = 25;
                man2[0].H = 35;
            }
            else
            {
                man2[0].W = 50;
                man2[0].H = 70;
            }

            if (keyEnter)
            {
                if (mSide == 0)
                {
                    bulletSide = 0;
                }
                else
                {
                    bulletSide = 1;
                }

                CreateMultipleBullets(bulletSide);

            }

            if (keyS && !singleB)
            {
                if (mSide == 0)
                {
                    bulletSide = 0;
                }
                else
                {
                    bulletSide = 1;
                }

                CreateSingleBullet(bulletSide);

                singleB = true;

            }



            if (singleB)
            {
                for (int i = 0; i < singleBullets2.Count; i++)
                {
                    if (singleBullets2[i].X >= 1300 || singleBullets2[i].X <= 0)
                    {
                        singleB = false;
                        singleBullets2.RemoveAt(i);
                    }
                }
            }

            if (keyF)
            {
                flip = 1;
                mF = 0;
            }
            if (flip == 1)
            {
                ManFlip2();
            }


            MoveSingleBullet();
            MoveMultipleBullets();


            if (keyLeft || keyRight)
            {
                if (XScroll < 0)
                {
                    XScroll += 5;

                }
                else
                {
                    if ((XScroll + this.ClientSize.Width) < 2265)
                    {
                        back2[0].rcSrc.X = XScroll;
                    }
                    else
                    {
                        XScroll -= 5;
                    }
                }

                if (man2[0].Y <= 1600)
                {
                    YScroll = 1430;
                }
                else
                {
                    YScroll = 1435;
                }

                if (YScroll < 0)
                {
                    YScroll = 1435;
                }
                else
                {
                    if ((YScroll + this.ClientSize.Height) < (back2[0].im.Height))
                    {
                        back2[0].rcSrc.Y = YScroll;
                    }
                    else
                    {
                        YScroll = 1430;
                    }
                }
            }

            if (enemy2.Count > 0)
            {
                MoveEnemy2();
            }

            MoveFlag2();
            MoveCoinTF();
            MoveCoin2();
            MoveCoinTS();
            TakeCoin2();
            MoveMan2Coin();
            MoveGem();
            MovePendule2();
            MoveElevator2();
            Man2inElevator();
            MoveSpike2();
            Man2TookGem();
            Movespikeball2();
            Man2Die();
            Gravity2();
            UpdateLife2();
            UpdateCoinBar2();


            if (warning2.Count > 0)
            {
                MoveWarning2();
            }

            MoveLaser();
            ctTick2++;

            DrawDubb(this.CreateGraphics());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    keyRight = false;
                    man2[0].iFrame = 0;
                    break;

                case Keys.Left:
                    keyLeft = false;
                    man2[0].iFrame = 8;
                    break;

                case Keys.Space:
                    keySpace = false;
                    break;

                case Keys.C:
                    keySmall = false;
                    break;

                case Keys.Enter:
                    keyEnter = false;
                    break;

                case Keys.S:
                    keyS = false;
                    break;

                case Keys.F:
                    keyF = false;
                    break;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: //hero move right
                    keyRight = true;
                    break;

                case Keys.Left: //hero move left
                    keyLeft = true;
                    break;

                case Keys.Space: //hero jump
                    keySpace = true;
                    break;

                case Keys.Enter: //multiple bullets
                    keyEnter = true;
                    break;

                case Keys.C: //make man2 smaller
                    keySmall = true;
                    break;

                case Keys.S: //single bullet
                    keyS = true;
                    break;

                case Keys.F: //hero flip
                    keyF = true;
                    break;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            CreateBack2();

            CreateDoor2();
            CreateGround2();
            CreatePlane2();
            CreateLaser21();
            CreateLaser22();


            CreateEnemy2();
            CreateFlag2();
            CreateCoin2TF();
            CreateCoin2TS();
            CreateGem();
            CreatePendule2();
            CreateElevator2();
            CreateSpike2();
            CreateSpikeball2();
            CreateCoinBar2();
            CreateLife2();
            CreateWarning2();

            CreateMan2();
            CreateCoin2();


        }

        void MoveLaser()
        {
            if (ctTick2 % 30 == 0 && !createLaser && !removeLaser)
            {
                createLaser = true;
                ctCreateL = 0;
                yLaser1 = 1910;
                yLaser2 = 1910;
            }

            if (createLaser && ctCreateL < 10)
            {
                CreateLaser21();
                CreateLaser22();

                yLaser1 -= 50;
                yLaser2 -= 50;
                ctCreateL++;
                if (ctCreateL >= 10)
                {
                    createLaser = false;
                    laserOn = true;
                }
            }

            if (ctTick2 % 10 == 0 && laserOn && !removeLaser)
            {
                removeLaser = true;
                ctRemoveL = 0;
            }

            if (removeLaser && ctRemoveL < 11)
            {
                if (laser21.Count > 0)
                {
                    laser21.RemoveAt(laser21.Count - 1);
                }
                if (laser22.Count > 0)
                {
                    laser22.RemoveAt(laser22.Count - 1);
                }
                ctRemoveL++;
                if (ctRemoveL >= 11)
                {
                    removeLaser = false;
                    laserOn = false;
                    yLaser1 = 1910;
                    yLaser2 = 1910;

                }
            }
        }

        void Man2Die()
        {
            if (man2[0].X >= pendule2[0].X && man2[0].X <= pendule2[0].X + pendule2[0].W && man2[0].Y <= 1892 && man2[0].Y >= 1888)
            {
                man2[0].X = 990;
                slowDown = true;

            }

            for (int i = 0; i < laser21.Count; i++)
            {
                if (laser21[i].X >= man2[0].X && laser21[i].X + laser21[i].W <= man2[0].X + man2[0].W)
                {
                    man2[0].X = 50;
                    XScroll = 0;

                    kill2++;
                }
            }
            for (int i = 0; i < laser22.Count; i++)
            {
                if (laser22[i].X >= man2[0].X && laser22[i].X + laser22[i].W <= man2[0].X + man2[0].W)
                {
                    man2[0].X = 50;
                    XScroll = 0;
                    kill2++;
                }
            }


            for (int i = 0; i < spikeball2.Count; i++)
            {
                if (spikeball2[i].Y + spikeball2[i].H >= man2[0].Y && man2[0].X >= spikeball2[i].X && man2[0].X + man2[0].W <= spikeball2[i].X + spikeball2[i].W)
                {

                    man2[0].X = 350;
                    man2[0].Y = 1862;
                    kill2++;
                }
            }

            if (man2[0].X >= flag2[0].X && ctcoin == 9)
            {
                CActorWin pnn = new CActorWin();
                pnn.X = 90;
                pnn.Y = 100;
                pnn.W = 210;
                pnn.H = 200;
                pnn.im = new Bitmap("win.png");
                win2.Add(pnn);

            }

            if (enemy2.Count > 0)
            {
                if (man2[0].X >= enemy2[0].X && man2[0].X <= enemy2[0].X + enemy2[0].W && man2[0].Y >= enemy2[0].Y && man2[0].Y <= enemy2[0].Y + enemy2[0].H)
                {
                    man2[0].X = 590;
                }
            }

            //ta7t spikes
            if (man2[0].X >= spike2[0].X && man2[0].X + man2[0].W <= spike2[0].X + spike2[0].W && man2[0].Y <= spike2[0].Y && man2[0].Y + man2[0].H / 2 + 20 >= spike2[0].Y)
            {
                kill2 = 3;
            }

            //fo2 spikes
            if (man2[0].X >= spike2[1].X && man2[0].X + man2[0].W <= spike2[1].X + spike2[1].W && man2[0].Y >= spike2[1].Y && man2[0].Y + man2[0].H >= spike2[1].Y + spike2[1].H)
            {
                kill2 = 3;

            }

        }

        void CreateMan2()
        {
            CActorMan2 pnn = new CActorMan2();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap im = new Bitmap("m" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 50;
            pnn.Y = 1890;
            //pnn.X = 1200;
            //pnn.Y = 1800;
            pnn.W = 50;
            pnn.H = 70;
            pnn.gravity = 0;

            man2.Add(pnn);
        }

        void ManJump2()
        {
            if (mSide == 0)
            {
                if (mJ == 0)
                {
                    man2[0].iFrame = 3;
                    man2[0].Y -= 60;
                    mJ = 1;
                }
                else if (mJ == 1)
                {
                    man2[0].iFrame = 3;
                    man2[0].Y -= 60;
                    mJ = 2;
                }
                else if (mJ == 2)
                {
                    man2[0].iFrame = 4;
                    man2[0].X += 50;
                    mJ = 3;
                }
                else if (mJ == 3)
                {
                    man2[0].iFrame = 0;
                    mJ = 0;
                    jump = 0;
                }
            }
            else if (mSide == 1)
            {
                if (mJ == 0)
                {
                    man2[0].iFrame = 11;
                    man2[0].Y -= 60;
                    mJ = 1;
                }
                else if (mJ == 1)
                {
                    man2[0].iFrame = 11;
                    man2[0].Y -= 60;
                    mJ = 2;
                }
                else if (mJ == 2)
                {
                    man2[0].iFrame = 12;
                    man2[0].X -= 50;
                    mJ = 3;
                }
                else if (mJ == 3)
                {
                    man2[0].iFrame = 8;
                    mJ = 0;
                    jump = 0;
                }
            }
        }

        void ManFlip2()
        {
            int newX, newY;
            if (mSide == 0)
            {
                if (mF == 0)
                {
                    newY = man2[0].Y - 70;

                    man2[0].iFrame = 16;
                    man2[0].W = 70;
                    man2[0].H = 50;
                    man2[0].Y = newY;

                    mF++;
                }
                else if (mF == 1)
                {
                    newX = man2[0].X + 40;

                    man2[0].iFrame = 17;
                    man2[0].W = 50;
                    man2[0].H = 70;
                    man2[0].X = newX;
                    XScroll += 20;

                    mF++;
                }
                else if (mF == 2)
                {
                    man2[0].iFrame = 18;
                    man2[0].W = 70;
                    man2[0].H = 50;
                    mF++;
                }
                else if (mF == 3)
                {
                    man2[0].iFrame = 0;
                    man2[0].W = 50;
                    man2[0].H = 70;
                    mF = 0;
                    flip = 0;
                }
            }
            else if (mSide == 1)
            {
                if (mF == 0)
                {
                    newY = man2[0].Y - 70;

                    man2[0].iFrame = 18;
                    man2[0].W = 70;
                    man2[0].H = 50;
                    man2[0].Y = newY;

                    mF++;
                }
                else if (mF == 1)
                {
                    newX = man2[0].X - 40;
                    man2[0].iFrame = 17;
                    man2[0].W = 50;
                    man2[0].H = 70;
                    man2[0].X = newX;
                    XScroll -= 20;

                    mF++;
                }
                else if (mF == 2)
                {
                    man2[0].iFrame = 16;
                    man2[0].W = 70;
                    man2[0].H = 50;
                    mF++;
                }
                else if (mF == 3)
                {
                    man2[0].iFrame = 8;
                    man2[0].W = 50;
                    man2[0].H = 70;
                    mF = 0;
                    flip = 0;
                }
            }
        }

        void Gravity2()
        {
            man2[0].gravity += gravityFall;

            man2[0].Y += man2[0].gravity;
            if (jump == 0)
            {
                onGround = false;
            }
            for (int i = 0; i < ground2.Count; i++)
            {
                if (man2[0].Y + man2[0].H > ground2[i].Y && man2[0].Y < ground2[i].Y + ground2[i].H &&
                    man2[0].X + man2[0].W > ground2[i].X && man2[0].X + 5 < ground2[i].X + ground2[i].W)
                {
                    onGround = true;
                    man2[0].Y = ground2[i].Y - man2[0].H;
                    man2[0].gravity = 0;
                    break;
                }

                if (man2elevator)
                {
                    onGround = true;
                    man2[0].Y = elevator2[0].Y + elevator2[0].H - man2[0].H - 40;
                    man2[0].gravity = 0;
                    break;

                }
            }

            for (int i = 0; i < bridge2.Count; i++)
            {
                if (man2[0].Y + man2[0].H > bridge2[i].Y && man2[0].Y < bridge2[i].Y + bridge2[i].H &&
                    man2[0].X + man2[0].W > bridge2[i].X && man2[0].X < bridge2[i].X + bridge2[i].W)
                {
                    onGround = true;
                    man2[0].Y = bridge2[i].Y - man2[0].H;
                    man2[0].gravity = 0;
                    break;
                }
                else
                {
                    onGround = false;
                    man2[0].gravity = 1;
                }
            }


            if (!onGround)
            {
                man2[0].gravity += gravityFall;
            }
        }

        void CreateCoinBar2()
        {
            CActorCoinBar2 pnn = new CActorCoinBar2();
            pnn.X = 20;
            pnn.Y = 45;
            pnn.W = 115;
            pnn.H = 30;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 10; i++)
            {
                Bitmap im = new Bitmap("cBar" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;

            coinBar2.Add(pnn);
        }

        void UpdateCoinBar2()
        {
            if (ctcoin == 0)
            {
                coinBar2[0].iFrame = 0;
            }
            else if (ctcoin == 1)
            {
                coinBar2[0].iFrame = 1;
            }
            else if (ctcoin == 2)
            {
                coinBar2[0].iFrame = 2;
            }
            else if (ctcoin == 3)
            {
                coinBar2[0].iFrame = 3;
            }
            else if (ctcoin == 4)
            {
                coinBar2[0].iFrame = 4;
            }
            else if (ctcoin == 5)
            {
                coinBar2[0].iFrame = 5;
            }
            else if (ctcoin == 6)
            {
                coinBar2[0].iFrame = 6;
            }
            else if (ctcoin == 7)
            {
                coinBar2[0].iFrame = 7;
            }
            else if (ctcoin == 8)
            {
                coinBar2[0].iFrame = 8;
            }
            else if (ctcoin == 9)
            {
                coinBar2[0].iFrame = 9;
            }

        }

        void CreateMultipleBullets(int bulletSide)
        {
            CActorBullets2 pnn = new CActorBullets2();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("bullet" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.Y = man2[0].Y + 15;
            pnn.W = 50;
            pnn.H = 20;
            if (bulletSide == 0)
            {
                pnn.iFrame = 0;
                pnn.X = man2[0].X + 60;
            }
            else
            {
                pnn.iFrame = 1;
                pnn.X = man2[0].X;
            }
            pnn.isMove = true;
            pnn.bSide = bulletSide;
            multipleBullets2.Add(pnn);

        }

        void MoveMultipleBullets()
        {
            for (int i = 0; i < multipleBullets2.Count; i++)
            {
                if (enemy2.Count > 0)
                {
                    if (multipleBullets2[i].X + multipleBullets2[i].W >= enemy2[0].X + 5 && multipleBullets2[i].Y >= enemy2[0].Y && multipleBullets2[i].Y + multipleBullets2[i].H <= enemy2[0].Y + enemy2[0].H)
                    {
                        multipleBullets2.RemoveAt(i);
                        for (int k = 0; k < 4; k++)
                        {
                            enemy2Die();
                        }
                    }
                }
            }
            for (int i = 0; i < multipleBullets2.Count; i++)
            {
                if (multipleBullets2[i].X + multipleBullets2[i].W > 1350)
                {
                    multipleBullets2.RemoveAt(i);

                }

            }
            for (int i = 0; i < multipleBullets2.Count; i++)
            {
                if (multipleBullets2[i].isMove == true)
                {
                    if (multipleBullets2[i].bSide == 0)
                    {
                        multipleBullets2[i].X += 5;
                    }
                    else
                    {
                        multipleBullets2[i].X -= 5;

                    }
                }

            }

        }

        void CreateSingleBullet(int bulletSide)
        {
            CActorBullets2 pnn = new CActorBullets2();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("bullet" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.Y = man2[0].Y + 15;
            pnn.W = 50;
            pnn.H = 20;
            if (bulletSide == 0)
            {
                pnn.iFrame = 0;
                pnn.X = man2[0].X + 60;
            }
            else
            {
                pnn.iFrame = 1;
                pnn.X = man2[0].X;
            }
            pnn.isMove = true;
            pnn.bSide = bulletSide;
            singleBullets2.Add(pnn);

        }

        void MoveSingleBullet()
        {
            for (int i = 0; i < singleBullets2.Count; i++)
            {
                if (enemy2.Count > 0)
                {
                    if (singleBullets2[i].X + singleBullets2[i].W >= enemy2[0].X + 5 && singleBullets2[i].Y >= enemy2[0].Y && singleBullets2[i].Y + singleBullets2[i].H <= enemy2[0].Y + enemy2[0].H)
                    {
                        singleBullets2.RemoveAt(i);
                        for (int k = 0; k < 4; k++)
                        {
                            enemy2Die();
                        }
                    }
                }
            }
            for (int i = 0; i < singleBullets2.Count; i++)
            {
                if (singleBullets2[i].isMove == true)
                {
                    if (singleBullets2[i].bSide == 0)
                    {
                        singleBullets2[i].X += 5;
                    }
                    else
                    {
                        singleBullets2[i].X -= 5;

                    }
                }
            }

        }

        void enemy2Die()
        {
            if (de == 0)
            {
                enemy2[0].iFrame = 8;
                de = 1;
            }
            else if (de == 1)
            {
                enemy2[0].iFrame = 9;
                de = 2;
            }
            else if (de == 2)
            {
                enemy2[0].iFrame = 10;
                de = 3;
            }
            else if (de == 3)
            {
                enemy2.RemoveAt(0);
                de = 0;
            }

        }

        void CreateDoor2()
        {
            CActorDoor2 pnn;

            pnn = new CActorDoor2();
            pnn.X = 15;
            pnn.Y = 1807;
            pnn.W = 130;
            pnn.H = 150;
            pnn.im = new Bitmap("door2.png");
            door2.Add(pnn);
        }

        void CreateGround2()
        {
            CActorGround2 pnn;

            pnn = new CActorGround2();
            pnn.X = -1;
            pnn.Y = 1960;
            pnn.W = 350;
            pnn.H = 40;
            pnn.im = new Bitmap("ground2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 350;
            pnn.Y = 1862;
            pnn.W = 90;
            pnn.H = 140;
            pnn.im = new Bitmap("tower2.png");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 440;
            pnn.Y = 1960;
            pnn.W = 150;
            pnn.H = 40;
            pnn.im = new Bitmap("ground2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 700;
            pnn.Y = 1960;
            pnn.W = 150;
            pnn.H = 40;
            pnn.im = new Bitmap("ground2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 840;
            pnn.Y = 1862;
            pnn.W = 90;
            pnn.H = 140;
            pnn.im = new Bitmap("tower2.png");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 930;
            pnn.Y = 1960;
            pnn.W = 570;
            pnn.H = 40;
            pnn.im = new Bitmap("ground2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 1500;
            pnn.Y = 1960;
            pnn.W = 650;
            pnn.H = 40;
            pnn.im = new Bitmap("ground2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 1970;
            pnn.Y = 1600;
            pnn.W = 300;
            pnn.H = 400;
            pnn.im = new Bitmap("groundtall2.png");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 550;
            pnn.Y = 1790;
            pnn.W = 200;
            pnn.H = 30;
            pnn.im = new Bitmap("block2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 950;
            pnn.Y = 1730;
            pnn.W = 200;
            pnn.H = 30;
            pnn.im = new Bitmap("block2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 1150;
            pnn.Y = 1730;
            pnn.W = 200;
            pnn.H = 30;
            pnn.im = new Bitmap("block2.bmp");
            ground2.Add(pnn);


            pnn = new CActorGround2();
            pnn.X = -1;
            pnn.Y = 1700;
            pnn.W = 200;
            pnn.H = 30;
            pnn.im = new Bitmap("block2.bmp");
            ground2.Add(pnn);

            pnn = new CActorGround2();
            pnn.X = 199;
            pnn.Y = 1700;
            pnn.W = 160;
            pnn.H = 30;
            pnn.im = new Bitmap("block2.bmp");
            ground2.Add(pnn);


        }
        void CreatePlane2()
        {
            CActorplane2 pnn = new CActorplane2();
            pnn.X = 450;
            pnn.Y = 1920;
            pnn.W = 90;
            pnn.H = 50;
            pnn.im = new Bitmap("plane2.png");
            pnn.im.MakeTransparent();
            plane2.Add(pnn);

            pnn = new CActorplane2();
            pnn.X = 730;
            pnn.Y = 1920;
            pnn.W = 90;
            pnn.H = 50;
            pnn.im = new Bitmap("plane2.png");
            pnn.im.MakeTransparent();
            plane2.Add(pnn);
        }

        void CreateLaser21()
        {
            CActorLaser2 pnn = new CActorLaser2();
            pnn.X = 477;
            pnn.Y = yLaser1;
            pnn.W = 40;
            pnn.H = 50;
            pnn.im = new Bitmap("laser2.png");
            pnn.im.MakeTransparent();
            laser21.Add(pnn);

        }
        void CreateLaser22()
        {

            CActorLaser2 pnn = new CActorLaser2();
            pnn.X = 757;
            pnn.Y = yLaser2;
            pnn.W = 40;
            pnn.H = 50;
            pnn.im = new Bitmap("laser2.png");
            pnn.im.MakeTransparent();
            laser22.Add(pnn);

        }
        void CreateEnemy2()
        {
            CActorEnemy2 pnn = new CActorEnemy2();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 11; i++)
            {
                Bitmap im = new Bitmap("e" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 1000;
            pnn.Y = 1640;
            pnn.W = 40;
            pnn.H = 100;

            enemy2.Add(pnn);
        }

        void MoveEnemy2()
        {
            if (enemy2[0].X >= 1240)
            {
                eSide = 1;
            }

            else if (enemy2[0].X <= 1000)
            {
                eSide = 0;
            }


            if (eSide == 0)
            {
                if (e == 0)
                {
                    enemy2[0].iFrame = 0;
                    enemy2[0].X += 3;
                    e = 1;
                }
                else if (e == 1)
                {
                    enemy2[0].iFrame = 1;
                    enemy2[0].X += 3;
                    e = 2;
                }
                else if (e == 2)
                {
                    enemy2[0].iFrame = 2;
                    enemy2[0].X += 3;
                    e = 3;
                }
                else if (e == 3)
                {
                    enemy2[0].iFrame = 3;
                    enemy2[0].X += 3;
                    e = 4;
                }
                else if (e == 4)
                {
                    enemy2[0].iFrame = 1;
                    enemy2[0].X += 3;
                    e = 0;
                }
            }
            else if (eSide == 1) // Move left
            {
                if (e == 0)
                {
                    enemy2[0].iFrame = 5;
                    enemy2[0].X -= 3;
                    e = 1;
                }
                else if (e == 1)
                {
                    enemy2[0].iFrame = 6;
                    enemy2[0].X -= 3;
                    e = 2;
                }
                else if (e == 2)
                {
                    enemy2[0].iFrame = 7;
                    enemy2[0].X -= 3;
                    e = 3;
                }
                else if (e == 3)
                {
                    enemy2[0].iFrame = 6;
                    enemy2[0].X -= 3;
                    e = 4;
                }
                else if (e == 4)
                {
                    enemy2[0].iFrame = 5;
                    enemy2[0].X -= 3;
                    e = 0;
                }
            }


        }

        void CreateSpikeball2()
        {
            for (int i = 0; i < 2; i++)
            {
                CActorSpikeball2 pnn = new CActorSpikeball2();
                pnn.X = a;
                pnn.Y = 1560;
                pnn.W = 60;
                pnn.H = 60;
                pnn.im = new Bitmap("spikeball1.png");

                spikeball2.Add(pnn);

                a += 190;
            }
            for (int i = 2; i < 3; i++)
            {
                CActorSpikeball2 pnn = new CActorSpikeball2();
                pnn.X = b;
                pnn.Y = 1450;
                pnn.W = 60;
                pnn.H = 60;
                pnn.im = new Bitmap("spikeball1.png");

                spikeball2.Add(pnn);

                b += 250;
            }
        }
        void Movespikeball2()
        { // Spikeball 0 and 1 
            if (spikeball2[0].Y <= 1440)
            {
                spikeballUp = false;
            }
            else if (spikeball2[0].Y >= 1620)
            {
                spikeballUp = true;
            }

            if (spikeballUp)
            {
                spikeball2[0].Y -= 3;
                spikeball2[1].Y -= 3;
            }
            else
            {
                spikeball2[0].Y += 3;
                spikeball2[1].Y += 3;
            }

            // Spikeball 2
            if (spikeball2[2].Y >= 1620)
            {
                spikeballDown = false;
            }
            else if (spikeball2[2].Y <= 1440)
            {
                spikeballDown = true;
            }

            if (spikeballDown)
            {
                spikeball2[2].Y += 3;
            }
            else
            {
                spikeball2[2].Y -= 3;
            }


        }
        void CreateCoin2()
        {
            CActorCoin2 pnn = new CActorCoin2();

            pnn.X = 580;
            pnn.Y = 1750;
            pnn.W = 35;
            pnn.H = 60;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 0;
            coin2.Add(pnn);


            pnn = new CActorCoin2();
            pnn.X = 680;
            pnn.Y = 1750;
            pnn.W = 35;
            pnn.H = 60;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);

            pnn = new CActorCoin2();
            pnn.X = 200;
            pnn.Y = 1920;
            pnn.W = 35;
            pnn.H = 80;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);

            pnn = new CActorCoin2();
            pnn.X = 70;
            pnn.Y = 1620;
            pnn.W = 35;
            pnn.H = 80;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);

            pnn = new CActorCoin2();
            pnn.X = 180;
            pnn.Y = 1620;
            pnn.W = 35;
            pnn.H = 80;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);
            pnn = new CActorCoin2();
            pnn.X = 1040;
            pnn.Y = 1920;
            pnn.W = 45;
            pnn.H = 80;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);
            pnn = new CActorCoin2();
            pnn.X = 1220;
            pnn.Y = 1920;
            pnn.W = 40;
            pnn.H = 80;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2.Add(pnn);
        }
        void MoveCoin2()
        {
            for (int i = 0; i < coin2.Count; i++)
            {
                if (coin2[i].ctC == 0)
                {
                    coin2[i].iFrame = 0;
                }
                else if (coin2[i].ctC == 1)
                {
                    coin2[i].iFrame = 1;

                }
                else if (coin2[i].ctC == 2)
                {
                    coin2[i].iFrame = 2;

                }
                else if (coin2[i].ctC == 3)
                {
                    coin2[i].iFrame = 1;

                }

                coin2[i].ctC++;
                if (coin2[i].ctC == 4)
                {
                    coin2[i].ctC = 0;
                }
            }
        }
        void CreateCoin2TS()
        {
            CActorCoin2 pnn = new CActorCoin2();
            pnn.X = 870;
            pnn.Y = 1800;
            pnn.W = 35;
            pnn.H = 50;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 1;
            coin2TS.Add(pnn);



        }
        void MoveCoinTS()
        {
            for (int i = 0; i < coin2TS.Count; i++)
            {
                if (coin2TS[i].ctC == 0)
                {
                    coin2TS[i].iFrame = 0;
                }
                else if (coin2TS[i].ctC == 1)
                {
                    coin2TS[i].iFrame = 1;

                }
                else if (coin2TS[i].ctC == 2)
                {
                    coin2TS[i].iFrame = 2;

                }
                else if (coin2TS[i].ctC == 3)
                {
                    coin2TS[i].iFrame = 1;

                }

                coin2TS[i].ctC++;
                if (coin2TS[i].ctC == 4)
                {
                    coin2TS[i].ctC = 0;
                }
            }
        }
        void CreateCoin2TF()
        {
            CActorCoin2 pnn = new CActorCoin2();
            pnn.X = 375;
            pnn.Y = 1800;
            pnn.W = 35;
            pnn.H = 50;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("cL2" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctC = 0;
            coin2TF.Add(pnn);


        }
        void MoveCoinTF()
        {
            for (int i = 0; i < coin2TF.Count; i++)
            {
                if (coin2TF[i].ctC == 0)
                {
                    coin2TF[i].iFrame = 0;
                }
                else if (coin2TF[i].ctC == 1)
                {
                    coin2TF[i].iFrame = 1;

                }
                else if (coin2TF[i].ctC == 2)
                {
                    coin2TF[i].iFrame = 2;

                }
                else if (coin2TF[i].ctC == 3)
                {
                    coin2TF[i].iFrame = 1;

                }

                coin2TF[i].ctC++;
                if (coin2TF[i].ctC == 4)
                {
                    coin2TF[i].ctC = 0;
                }
            }
        }
        void TakeCoin2()
        {
            for (int i = 0; i < coin2TF.Count; i++)//coin on the 1st tower
            {
                if (coin2TF[i].X >= man2[0].X && coin2TF[i].X + coin2TF[i].W <= man2[0].X + man2[0].W && man2[0].Y <= coin2TF[i].Y + coin2TF[i].H && man2[0].Y + man2[0].H >= coin2TF[i].Y)
                {
                    CreateMoveCoin2(coin2TF[i]);
                    coin2TF.RemoveAt(i);
                    ctcoin++;
                }
            }
            for (int i = 0; i < coin2.Count; i++)//middle
            {
                if (coin2[i].X >= man2[0].X && coin2[i].X + coin2[i].W <= man2[0].X + man2[0].W && man2[0].Y <= coin2[i].Y + coin2[i].H && man2[0].Y + man2[0].H >= coin2[i].Y)
                {
                    CreateMoveCoin2(coin2[i]);
                    coin2.RemoveAt(i);
                    ctcoin++;
                }
            }

            for (int i = 0; i < coin2TS.Count; i++)//coin on the 2nd tower
            {
                if (coin2TS[i].X >= man2[0].X && coin2TS[i].X + coin2TS[i].W <= man2[0].X + man2[0].W && man2[0].Y <= coin2TS[i].Y + coin2TS[i].H && man2[0].Y + man2[0].H >= coin2TS[i].Y)
                {
                    CreateMoveCoin2(coin2TS[i]);
                    coin2TS.RemoveAt(i);
                    ctcoin++;
                }

            }

        }

        void MoveMan2Coin()
        {
            for (int i = 0; i < moveCoin2.Count; i++)
            {
                moveCoin2[i].Y -= 50;

                if (moveCoin2[i].Y <= 0)
                {
                    moveCoin2.RemoveAt(i);
                }
            }
        }

        void CreateMoveCoin2(CActorCoin2 coin)
        {
            CActorMoveCoin2 pnn = new CActorMoveCoin2();
            pnn.X = coin.X;
            pnn.Y = coin.Y;
            pnn.W = 20;
            pnn.H = 20;
            pnn.im = new Bitmap("cL21.png");

            moveCoin2.Add(pnn);
        }

        void CreateGem()
        {
            CActorGem pnn = new CActorGem();
            pnn.X = 1270;
            pnn.Y = 1685;
            pnn.W = 70;
            pnn.H = 50;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("G" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            gem.Add(pnn);

        }
        void MoveGem()
        {
            for (int i = 0; i < gem.Count; i++)
            {
                if (ctG == 0)
                {
                    gem[i].iFrame = 0;
                }
                else if (ctG == 1)
                {
                    gem[i].iFrame = 1;

                }
                else if (ctG == 2)
                {
                    gem[i].iFrame = 2;

                }
                else if (ctG == 3)
                {
                    gem[i].iFrame = 1;

                }

                ctG++;
                if (ctG == 4)
                {
                    ctG = 0;
                }
            }
        }
        void Man2TookGem()
        {
            for (int i = 0; i < gem.Count; i++)
            {
                if (man2[0].X >= gem[i].X && man2[0].X + man2[0].W <= gem[i].X + gem[i].W && man2[0].Y <= 1663 && man2[0].Y >= 1657)
                {
                    tookGem = true;
                    gem.RemoveAt(0);
                    CreateBridge2();


                }
            }
        }

        void CreateLife2()
        {
            CActorLife2 pnn = new CActorLife2();
            pnn.X = this.ClientSize.Width - 120;
            pnn.Y = 40;
            pnn.W = 110;
            pnn.H = 35;
            pnn.imgs = new List<Bitmap>();
            for (int k = 0; k < 4; k++)
            {
                Bitmap im = new Bitmap("l" + (k + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }

            pnn.iFrame = 0;

            life2.Add(pnn);
        }
        void UpdateLife2()
        {
            if (kill2 == 0)
            {
                life2[0].iFrame = 0;
            }
            else if (kill2 == 1)
            {
                life2[0].iFrame = 1;
            }
            else if (kill2 == 2)
            {
                life2[0].iFrame = 2;

            }
            else if (kill2 == 3)
            {
                life2[0].iFrame = 3;

                CActorGameover pnn = new CActorGameover();
                pnn.X = 90;
                pnn.Y = 250;
                pnn.W = 210;
                pnn.H = 50;
                pnn.im = new Bitmap("lost.png");
                gameover2.Add(pnn);

                tt.Stop();
            }
        }


        void CreateWarning2()
        {
            CActorWarning2 pnn = new CActorWarning2();
            pnn.X = this.ClientRectangle.Width - 160;
            pnn.Y = 40;
            pnn.W = 35;
            pnn.H = 35;
            pnn.imgs = new List<Bitmap>();
            for (int k = 0; k < 3; k++)
            {
                Bitmap im = new Bitmap("warn" + (k + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }

            pnn.iFrame = 0;

            warning2.Add(pnn);
        }

        void MoveWarning2()
        {
            if (ctW2 == 0)
            {
                warning2[0].iFrame = 0;
            }
            else if (ctW2 == 1)
            {
                warning2[0].iFrame = 1;

            }
            else if (ctW2 == 2)
            {
                warning2[0].iFrame = 2;

            }
            else if (ctW2 == 3)
            {
                warning2[0].iFrame = 1;
            }

            ctW2++;
            if (ctW2 == 4)
            {
                ctW2 = 0;

            }
        }



        void CreateFlag2()
        {
            CActorFlag2 pnn = new CActorFlag2();
            pnn.X = 2100;
            pnn.Y = 1436;
            pnn.W = 200;
            pnn.H = 170;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("f" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            flag2.Add(pnn);
        }
        void MoveFlag2()
        {
            for (int i = 0; i < flag2.Count; i++)
            {
                if (ctf == 0)
                {
                    flag2[i].iFrame = 0;
                }
                else if (ctf == 2)
                {
                    flag2[i].iFrame = 1;

                }
                else if (ctf == 4)
                {
                    flag2[i].iFrame = 2;

                }
                else if (ctf == 6)
                {
                    flag2[i].iFrame = 1;

                }

                ctf++;
                if (ctf == 6)
                {
                    ctf = 0;
                }
            }
        }

        void CreatePendule2()
        {
            CActorPendule2 pnn = new CActorPendule2();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 5; i++)
            {
                Bitmap im = new Bitmap("p" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 1;
            pnn.X = 1100;
            pnn.Y = 1730;
            pnn.W = 80;
            pnn.H = 190;

            pendule2.Add(pnn);
        }
        void MovePendule2()
        {
            if (p == 0)
            {
                pendule2[0].iFrame = 0;
                p = 1;
            }
            else if (p == 1)
            {
                pendule2[0].iFrame = 1;
                p = 2;

            }
            else if (p == 2)
            {
                pendule2[0].iFrame = 2;
                p = 3;

            }
            else if (p == 3)
            {
                pendule2[0].iFrame = 1;
                p = 4;

            }
            else if (p == 4)
            {
                pendule2[0].iFrame = 0;
                p = 5;

            }
            else if (p == 5)
            {
                pendule2[0].iFrame = 3;
                p = 6;

            }
            else if (p == 6)
            {
                pendule2[0].iFrame = 4;
                p = 7;

            }
            else if (p == 7)
            {
                pendule2[0].iFrame = 3;
                p = 0;

            }
        }
        void CreateElevator2()
        {
            CActorElevator2 pnn = new CActorElevator2();
            pnn.X = 1800;
            pnn.Y = 1820;
            pnn.W = 170;
            pnn.H = 200;
            pnn.im = new Bitmap("elevator2.png");
            pnn.im.MakeTransparent();
            elevator2.Add(pnn);


        }
        void MoveElevator2()
        {

            if (elevator2[0].Y <= 1450)
            {
                elevatorUp = false;
            }

            if (elevator2[0].Y >= 1760)
            {
                elevatorUp = true;
            }


            if (elevatorUp)
            {
                elevator2[0].Y -= 5;
            }
            else
            {
                elevator2[0].Y += 5;
            }
        }
        void Man2inElevator()
        {
            if (man2[0].Y >= elevator2[0].Y && man2[0].Y <= elevator2[0].Y + elevator2[0].H && man2[0].X >= elevator2[0].X && man2[0].X + man2[0].W / 2 <= elevator2[0].X + elevator2[0].W)
            {
                man2elevator = true;
            }
            else
            {
                man2elevator = false;
            }


            if (man2elevator)
            {
                int dY = elevator2[0].Y - previousElevator2Y;

                man2[0].Y += dY;

                //YScroll += dY;
            }

            previousElevator2Y = elevator2[0].Y;

        }

        void CreateSpike2()
        {
            CActorSpike2 pnn = new CActorSpike2();
            pnn.X = 1470;
            pnn.Y = 1920;
            pnn.W = 220;
            pnn.H = 40;
            pnn.im = new Bitmap("spike1.png");
            pnn.im.MakeTransparent();
            spike2.Add(pnn);

            pnn = new CActorSpike2();
            pnn.X = 1470;
            pnn.Y = 1860;
            pnn.W = 220;
            pnn.H = 40;
            pnn.im = new Bitmap("spike2.png");
            pnn.im.MakeTransparent();
            spike2.Add(pnn);


        }
        void MoveSpike2()
        {
            //spike fo2
            if (spike2[1].X >= 1550)
            {
                spikemove = false;
            }

            if (spike2[1].X <= 1160)
            {
                spikemove = true;
            }

            if (spikemove)
            {
                spike2[1].X += 5;
            }
            else
            {
                spike2[1].X -= 5;
            }

            //spike ta7t
            if (spike2[0].X <= 1250)
            {
                spikemove = false;
            }

            if (spike2[0].X >= 1450)
            {
                spikemove = true;
            }


            if (spikemove)
            {
                spike2[0].X -= 5;
            }
            else
            {
                spike2[0].X += 5;
            }
        }

        void CreateBridge2()
        {

            if (tookGem == true)
            {
                CActorBridge2 pnn = new CActorBridge2();
                pnn.X = 1340;
                pnn.Y = 1730;
                pnn.W = 460;
                pnn.H = 30;
                pnn.im = new Bitmap("Bridge.png");
                bridge2.Add(pnn);
            }

        }

        void CreateBack2()
        {
            CActorBack2 pnn = new CActorBack2();
            pnn.im = new Bitmap("back2.jpg");
            pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            pnn.rcSrc = new Rectangle(XScroll, YScroll, this.ClientSize.Width, this.ClientSize.Height);
            back2.Add(pnn);
        }

        void DrawScene(Graphics g)
        {
            for (int i = 0; i < back2.Count; i++)
            {
                g.DrawImage(back2[i].im, back2[i].rcDst, back2[i].rcSrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < pendule2.Count; i++)
            {
                g.DrawImage(pendule2[i].imgs[pendule2[i].iFrame], pendule2[i].X - XScroll, pendule2[i].Y - YScroll, pendule2[i].W, pendule2[i].H);
            }
            for (int i = 0; i < ground2.Count; i++)
            {
                g.DrawImage(ground2[i].im, ground2[i].X - XScroll, ground2[i].Y - YScroll, ground2[i].W, ground2[i].H);
            }
            for (int i = 0; i < door2.Count; i++)
            {
                g.DrawImage(door2[i].im, door2[i].X - XScroll, door2[i].Y - YScroll, door2[i].W, door2[i].H);
            }
            for (int i = 0; i < man2.Count; i++)
            {
                g.DrawImage(man2[i].imgs[man2[i].iFrame], man2[i].X - XScroll, man2[i].Y - YScroll, man2[i].W, man2[i].H);

            }

            for (int i = 0; i < laser21.Count; i++)
            {
                g.DrawImage(laser21[i].im, laser21[i].X - XScroll, laser21[i].Y - YScroll, laser21[i].W, laser21[i].H);
            }
            for (int i = 0; i < laser22.Count; i++)
            {
                g.DrawImage(laser22[i].im, laser22[i].X - XScroll, laser22[i].Y - YScroll, laser22[i].W, laser22[i].H);
            }

            for (int i = 0; i < plane2.Count; i++)
            {
                g.DrawImage(plane2[i].im, plane2[i].X - XScroll, plane2[i].Y - YScroll, plane2[i].W, plane2[i].H);
            }
            for (int i = 0; i < enemy2.Count; i++)
            {
                g.DrawImage(enemy2[i].imgs[enemy2[i].iFrame], enemy2[i].X - XScroll, enemy2[i].Y - YScroll, enemy2[i].W, enemy2[i].H);
            }
            for (int i = 0; i < coin2.Count; i++)
            {
                g.DrawImage(coin2[i].imgs[coin2[i].iFrame], coin2[i].X - XScroll, coin2[i].Y - YScroll, coin2[i].W, coin2[i].W);
            }
            for (int i = 0; i < coin2TF.Count; i++)
            {
                g.DrawImage(coin2TF[i].imgs[coin2TF[i].iFrame], coin2TF[i].X - XScroll, coin2TF[i].Y - YScroll, coin2TF[i].W, coin2TF[i].H);
            }
            for (int i = 0; i < coin2TS.Count; i++)
            {
                g.DrawImage(coin2TS[i].imgs[coin2TS[i].iFrame], coin2TS[i].X - XScroll, coin2TS[i].Y - YScroll, coin2TS[i].W, coin2TS[i].H);
            }

            for (int i = 0; i < moveCoin2.Count; i++)
            {
                g.DrawImage(moveCoin2[i].im, moveCoin2[i].X - XScroll, moveCoin2[i].Y - YScroll, moveCoin2[i].W, moveCoin2[i].H);
            }
            for (int i = 0; i < flag2.Count; i++)
            {
                g.DrawImage(flag2[i].imgs[flag2[i].iFrame], flag2[i].X - XScroll, flag2[i].Y - YScroll, flag2[i].W, flag2[i].H);
            }
            for (int i = 0; i < gem.Count; i++)
            {
                g.DrawImage(gem[i].imgs[gem[i].iFrame], gem[i].X - XScroll, gem[i].Y - YScroll, gem[i].W, gem[i].H);
            }

            for (int i = 0; i < elevator2.Count; i++)
            {
                g.DrawImage(elevator2[i].im, elevator2[i].X - XScroll, elevator2[i].Y - YScroll, elevator2[i].W, elevator2[i].H);
            }
            for (int i = 0; i < spike2.Count; i++)
            {
                g.DrawImage(spike2[i].im, spike2[i].X - XScroll, spike2[i].Y - YScroll, spike2[i].W, spike2[i].H);
            }
            for (int i = 0; i < bridge2.Count; i++)
            {
                g.DrawImage(bridge2[i].im, bridge2[i].X - XScroll, bridge2[i].Y - YScroll, bridge2[i].W, bridge2[i].H);
            }
            for (int i = 0; i < singleBullets2.Count; i++)
            {
                g.DrawImage(singleBullets2[i].imgs[singleBullets2[i].iFrame], singleBullets2[i].X - XScroll, singleBullets2[i].Y - YScroll, singleBullets2[i].W, singleBullets2[i].H);
            }
            for (int i = 0; i < multipleBullets2.Count; i++)
            {
                g.DrawImage(multipleBullets2[i].imgs[multipleBullets2[i].iFrame], multipleBullets2[i].X - XScroll, multipleBullets2[i].Y - YScroll, multipleBullets2[i].W, multipleBullets2[i].H);
            }
            for (int i = 0; i < spikeball2.Count; i++)
            {
                g.DrawImage(spikeball2[i].im, spikeball2[i].X - XScroll, spikeball2[i].Y - YScroll, spikeball2[i].W, spikeball2[i].H);
            }

            for (int i = 0; i < life2.Count; i++)
            {
                g.DrawImage(life2[i].imgs[life2[i].iFrame], life2[i].X, life2[i].Y, life2[i].W, life2[i].H);

            }

            if (kill2 > 0)
            {
                for (int i = 0; i < warning2.Count; i++)
                {
                    g.DrawImage(warning2[i].imgs[warning2[i].iFrame], warning2[i].X, warning2[i].Y, warning2[i].W, warning2[i].H);
                }
            }
            for (int i = 0; i < coinBar2.Count; i++)
            {
                g.DrawImage(coinBar2[i].imgs[coinBar2[i].iFrame], coinBar2[i].X, coinBar2[i].Y, coinBar2[i].W, coinBar2[i].H);
            }

            for (int i = 0; i < win2.Count; i++)
            {
                g.DrawImage(win2[i].im, win2[i].X, win2[i].Y, win2[i].W, win2[i].H);
            }

            for (int i = 0; i < gameover2.Count; i++)
            {
                g.DrawImage(gameover2[i].im, gameover2[i].X, gameover2[i].Y, gameover2[i].W, gameover2[i].H);
            }

        }

        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

    }
}
