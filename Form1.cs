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
    class CActorBack
    {
        public Rectangle rcSrc;
        public Rectangle rcDst;
        public Bitmap im;

    }

    public class CActorMan
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public int gravity;
    }

    public class CActorSnail
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }

    public class CActorBird
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }

    public class CActorEggs
    {
        public int X, Y, W, H;
        public Bitmap im;
        public bool isMove;

    }

    public class CActorWater
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorTree
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorGround
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorLife
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorWarning
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }

    public class CActorCoin
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public int ctMC;

    }
    public class CActorCoinBar
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;

    }
    public class CActorMoveCoin
    {
        public int X, Y, W, H;
        public Bitmap im;

    }

    public class CActorWall
    {
        public int X, Y, W, H;
        public Bitmap im;

    }

    public class CActorElevator
    {
        public int X, Y, W, H;
        public Bitmap im;
        public int dirX, dirY, Speed;

    }
    public class CActorLadder
    {
        public int X, Y, W, H;
        public Bitmap im;

    }

    public class CActorPlatform
    {
        public int X, Y, W, H;
        public Bitmap im;
        public int dirX, Speed;

    }

    public class CActorKey
    {
        public int X, Y, W, H;
        public Bitmap im;

    }

    public class CActorDoor
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }

    public class CActorMonster
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }
    public class CActorFire
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorBow
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
    }
    public class CActorArrow
    {
        public int X, Y, W, H;
        public List<Bitmap> imgs;
        public int iFrame;
        public bool isMove;
        public int aSide;

    }

    public class CActorStart
    {
        public int X, Y, W, H;
        public Bitmap im;

    }
    public class CActorFinal
    {
        public int X, Y, W, H;
        public Bitmap im;
        public string score;
        public string text1;

    }

    public partial class Form1 : Form
    {
        Bitmap off;
        Timer tt = new Timer();
        int YScroll = 1435, XScroll = 0, ctTick = 0, startGame = 0, go = 0;
        bool keyLeft = false, keyRight = false, keyUp = false, keyDown = false, keySpace = false, keyEnter = false, keyF = false, keyS = false, keyP = false, keyM = false;
        int w = 0, s = 0, sSide = 0;
        int jump = 0, climbUp = 0, climbDown = 0, gravityFall = 10;
        bool onGround = false;
        int mW = 0, mJ = 0, mSide = 0, flip = 0, mF = 0, mCu = 0, mCd = 0;
        int kill = 0, ctW = 0, coinsCol = 0;
        int eSide = 0;
        bool onElevator = false, onLadder = false;
        int ctMon = 0, monsterShot = 0;
        bool drawLaser = false;
        bool showDoor = false;
        bool winLevel1 = false;
        int bSide = 0, b = 0;
        int holdBow = 0, arrowSide = 0;
        bool singleA = false;
        int previousElevatorX = 0;
        int previousElevatorY = 0;
        bool shield = false, shield2 = false;
        int shieldX = 0, shieldY = 0, shieldW = 0, shieldH = 0;
        int shield2X = 0, shield2Y = 0, shield2W = 0, shield2H = 0;
        bool holdPlatform = false;
        bool isOnce = false;

        List<CActorBack> back = new List<CActorBack>();
        List<CActorGround> ground = new List<CActorGround>();
        List<CActorTree> tree = new List<CActorTree>();
        List<CActorSnail> snail = new List<CActorSnail>();
        List<CActorBird> bird = new List<CActorBird>();
        List<CActorEggs> eggs = new List<CActorEggs>();
        List<CActorWater> water = new List<CActorWater>();
        List<CActorMan> man = new List<CActorMan>();
        List<CActorLife> life = new List<CActorLife>();
        List<CActorWarning> warning = new List<CActorWarning>();
        List<CActorCoin> coin = new List<CActorCoin>();
        List<CActorCoinBar> coinBar = new List<CActorCoinBar>();
        List<CActorMoveCoin> moveCoin = new List<CActorMoveCoin>();
        List<CActorWall> wall = new List<CActorWall>();
        List<CActorElevator> elevator = new List<CActorElevator>();
        List<CActorLadder> ladder = new List<CActorLadder>();
        List<CActorMonster> monster = new List<CActorMonster>();
        List<CActorFire> fire = new List<CActorFire>();

        List<CActorBow> bow = new List<CActorBow>();
        List<CActorArrow> multipleArrow = new List<CActorArrow>();
        List<CActorArrow> singleArrow = new List<CActorArrow>();
        List<CActorPlatform> platform = new List<CActorPlatform>();
        List<CActorKey> key = new List<CActorKey>();
        List<CActorDoor> door = new List<CActorDoor>();

        List<CActorStart> start = new List<CActorStart>();
        List<CActorFinal> final = new List<CActorFinal>();


        public Form1()
        {
            this.Size = new Size(400, 600);
            //this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(450, 0);
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            this.MouseDown += Form1_MouseDown;

            tt.Interval = 100;
            tt.Start();
            tt.Tick += Tt_Tick;

        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (startGame == 1)
            {
                if (man[0].X == 960)
                {
                    XScroll = man[0].X - 70;
                }

                if (man[0].X == 1181)
                {
                    XScroll = man[0].X - 70;
                }

                if (man[0].X == 1400)
                {
                    XScroll = man[0].X - 70;
                }

                if (keyRight)
                {
                    int newX = man[0].X + 5;
                    if (newX + man[0].W < 1535 && !CheckCollision(newX, man[0].Y))
                    {
                        XScroll += 5;
                        if (mW == 0)
                        {
                            man[0].iFrame = 1;
                            man[0].X = newX;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man[0].iFrame = 2;
                            man[0].X = newX;
                            mW = 0;
                        }
                        if (holdBow == 1)
                        {
                            if (bow.Count > 0)
                            {
                                bow[0].X += 5;
                            }
                        }
                    }
                    mSide = 0;
                    holdPlatform = false;

                }

                if (keyLeft)
                {
                    int newX = man[0].X - 5;
                    if (newX > 0 && !CheckCollision(newX, man[0].Y))
                    {
                        XScroll -= 5;
                        if (mW == 0)
                        {
                            man[0].iFrame = 8;
                            man[0].X = newX;
                            mW = 1;
                        }
                        else if (mW == 1)
                        {
                            man[0].iFrame = 9;
                            man[0].X = newX;
                            mW = 0;
                        }
                        if (holdBow == 1)
                        {
                            if (bow.Count > 0)
                            {
                                bow[0].X -= 5;
                            }
                        }
                    }
                    mSide = 1;
                    holdPlatform = false;

                }

                if (keySpace)
                {
                    jump = 1;
                    mJ = 0;
                    holdPlatform = false;

                }

                if (jump == 1)
                {
                    ManJump();
                }

                if (keyF)
                {
                    flip = 1;
                    mF = 0;
                    holdPlatform = false;

                }

                if (flip == 1)
                {
                    ManFlip();
                }

                if (keyEnter)
                {
                    if (bow.Count > 0)
                    {
                        if (man[0].X >= 1150 && man[0].X <= 1600 && man[0].Y <= 1585 && man[0].Y >= 1575)
                        {
                            if (holdBow == 1)
                            {
                                if (mSide == 0)
                                {
                                    arrowSide = 0;
                                }
                                else
                                {
                                    arrowSide = 1;
                                }

                                CreateMultipleArrow(arrowSide);
                            }
                        }
                    }
                }

                if (keyS && !singleA)
                {
                    if (bow.Count > 0)
                    {
                        if (man[0].X >= 1150 && man[0].X <= 1600 && man[0].Y <= 1585 && man[0].Y >= 1575)
                        {
                            if (holdBow == 1)
                            {
                                if (mSide == 0)
                                {
                                    arrowSide = 0;
                                }
                                else
                                {
                                    arrowSide = 1;
                                }
                                CreateSingleArrow(arrowSide);
                                singleA = true;
                            }
                        }
                    }
                }

                if (singleA)
                {
                    if (singleArrow[0].X > 300 || singleArrow[0].X < 0)
                    {
                        singleA = false;
                        singleArrow.RemoveAt(0);
                    }
                }

                if (keyP && man[0].Y <= 1582 && man[0].Y >= 1578 && man[0].X > -1 && man[0].X + man[0].W <= 500)
                {
                    if (coinsCol >= 2 && !shield)
                    {
                        shield = true;
                    }
                    else if (shield && coinsCol > 2)
                    {
                        shield = false;
                    }
                }

                if (keyP && man[0].Y <= 1582 && man[0].Y >= 1578 && man[0].X >= 1120 && man[0].X + man[0].W <= 1600)
                {
                    if (coinsCol >= 3 && !shield2)
                    {
                        shield2 = true;
                    }
                    else if (shield2 && coinsCol > 3)
                    {
                        shield2 = false;
                    }
                }

                if (keyUp && ladder[0].X >= man[0].X && ladder[0].X + ladder[0].W <= man[0].X + man[0].W && man[0].Y > ladder[0].Y && man[0].Y < ladder[0].Y + ladder[0].H)
                {
                    climbUp = 1;
                    climbDown = 0;
                    onLadder = true;
                }
                if (climbUp == 1)
                {
                    ManClimbUp();
                }

                if (keyDown && ladder[0].X >= man[0].X && ladder[0].X + ladder[0].W <= man[0].X + man[0].W && man[0].Y <= 1582 && man[0].Y >= 1578)
                {
                    climbDown = 1;
                    climbUp = 0;
                    onLadder = true;
                }
                if (climbDown == 1)
                {
                    ManClimbDown();
                }


                if (keyM)
                {
                    if (man[0].Y >= 1885 && man[0].Y <= 1895 && man[0].X + man[0].W > platform[0].X)
                    {
                        holdPlatform = true;
                    }
                    else
                    {
                        holdPlatform = false;
                    }
                }

                if (holdPlatform)
                {
                    man[0].iFrame = 7;
                    man[0].X += platform[0].Speed * platform[0].dirX;
                }

                if (bow.Count > 0)
                {
                    if (holdBow == 1)
                    {
                        if (mSide == 0)
                        {
                            bow[0].X = man[0].X + 20;
                            bow[0].Y = man[0].Y + 10;
                            bow[0].iFrame = 0;
                        }
                        else
                        {
                            bow[0].X = man[0].X - 10;
                            bow[0].Y = man[0].Y + 10;
                            bow[0].iFrame = 1;
                        }
                    }
                }

                if (bow.Count > 0)
                {
                    if (monsterShot >= 3)
                    {
                        bow.RemoveAt(0);
                    }
                }
                if (man[0].Y >= elevator[0].Y && man[0].Y <= elevator[0].Y + elevator[0].H && man[0].X >= elevator[0].X && man[0].X + man[0].W / 2 <= elevator[0].X + elevator[0].W)
                {
                    onElevator = true;
                }
                else
                {
                    onElevator = false;
                }
                if (onElevator)
                {

                    int dX = elevator[0].X - previousElevatorX;
                    int dY = elevator[0].Y - previousElevatorY;

                    man[0].X += dX;
                    man[0].Y += dY;

                    XScroll += dX;

                }

                previousElevatorX = elevator[0].X;
                previousElevatorY = elevator[0].Y;



                this.Text = $"x: {man[0].X} ,,, y: {man[0].Y}";



                if (keyUp || keyDown || keyLeft || keyRight)
                {
                    if (XScroll < 0)
                    {
                        XScroll += 5;
                    }
                    else
                    {
                        if ((XScroll + this.ClientSize.Width) < 1535)
                        {
                            back[0].rcSrc.X = XScroll;
                        }
                        else
                        {
                            XScroll -= 5;
                        }
                    }

                    if (man[0].Y <= 1600)
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
                        if ((YScroll + this.ClientSize.Height) < (back[0].im.Height))
                        {
                            back[0].rcSrc.Y = YScroll;
                        }
                        else
                        {
                            YScroll = 1430;
                        }
                    }
                }

                if (key.Count > 0)
                {
                    if (key[0].X >= man[0].X && key[0].X + key[0].W <= man[0].X + man[0].W && man[0].Y <= 1778 && man[0].Y >= 1772)
                    {
                        key.RemoveAt(0);
                        showDoor = true;
                    }
                }

                if (showDoor == true && man[0].X <= door[0].X - 50 && man[0].Y <= 1892 && man[0].Y >= 1888)
                {
                    door[0].iFrame = 1;
                }
                if (!isOnce)
                {
                    if (winLevel1)
                    {
                        WinLevel1();
                        isOnce = true;
                    }
                }
                if (man[0].X >= door[0].X && man[0].X <= door[0].X + door[0].W && man[0].Y >= door[0].Y && man[0].Y <= door[0].Y + door[0].H && coinsCol == 9)
                {

                    winLevel1 = true;


                }

                if (ctTick % 20 == 0)
                {
                    CreateEggs();
                }

                MoveWater();
                MoveSnail();
                MoveBird();
                MoveEggs();

                if (bow.Count > 0)
                {
                    MoveSingleArrow();
                    MoveMultipleArrow();
                }
                else
                {
                    for (int i = 0; i < multipleArrow.Count; i++)
                    {
                        multipleArrow.RemoveAt(i);
                    }

                    for (int i = 0; i < singleArrow.Count; i++)
                    {
                        singleArrow.RemoveAt(i);
                    }
                }


                if (monster.Count > 0)
                {
                    MoveMonster();
                }

                ManDie();
                Gravity();
                UpdateLife();
                UpdateCoinBar();

                for (int i = 0; i < coin.Count; i++)
                {
                    MoveCoin(i);
                }

                CheckCoin();

                MoveManCoin();


                if (warning.Count > 0)
                {
                    MoveWarning();
                }

                if (elevator.Count > 0)
                {
                    MoveElevator();
                }

                if (platform.Count > 0)
                {
                    MovePlatform();
                }

                ctTick++;
            }
            DrawDubb(this.CreateGraphics());
        }

        void WinLevel1()
        {
            winLevel1 = false;
            isOnce = true;
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X >= start[0].X - XScroll && e.X <= start[0].X - XScroll + start[0].W && e.Y >= start[0].Y - YScroll && e.Y <= start[0].Y + 200 - YScroll)
                {
                    startGame = 1;
                    start.RemoveAt(1);
                }
            }
            DrawDubb(this.CreateGraphics());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    keyRight = false;
                    man[0].iFrame = 0;
                    break;

                case Keys.Left:
                    keyLeft = false;
                    man[0].iFrame = 8;
                    break;

                case Keys.Up:
                    keyUp = false;
                    break;

                case Keys.Down:
                    keyDown = false;
                    break;

                case Keys.Space:
                    keySpace = false;
                    break;

                case Keys.Enter:
                    keyEnter = false;
                    break;

                case Keys.F:
                    keyF = false;
                    break;

                case Keys.S:
                    keyS = false;
                    break;

                case Keys.P:
                    keyP = false;
                    break;

                case Keys.M:
                    keyM = false;
                    break;

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: //move hero right
                    keyRight = true;
                    break;

                case Keys.Left: //move hero left
                    keyLeft = true;
                    break;

                case Keys.Up: //ladder up
                    keyUp = true;
                    break;

                case Keys.Down: //ladder down
                    keyDown = true;
                    break;

                case Keys.Space: //normal jump
                    keySpace = true;
                    break;

                case Keys.Enter: //multiple arrows
                    keyEnter = true;
                    break;

                case Keys.H: //hold bow
                    if (man[0].X >= 1150 && man[0].X <= 1600 && man[0].Y <= 1585 && man[0].Y >= 1575)
                    {
                        holdBow = 1;
                    }
                    break;

                case Keys.F: //flip
                    keyF = true;
                    break;

                case Keys.S: //single arrow
                    keyS = true;
                    break;

                case Keys.P: //draw shield protection
                    keyP = true;
                    break;

                case Keys.M: //move with platform
                    keyM = true;
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
            CreateBack();
            CreateTree();
            CreateSnail();
            CreateBird();
            CreateGround();
            CreateWater();
            CreateMan();
            CreateLife();
            CreateStart();
            CreateWarning();
            CreateCoin();
            CreateCoinBar();
            CreateWall();
            CreateElevator();
            CreateLadder();
            CreateMonster();
            CreateFire();
            CreateBow();
            CreateKey();
            CreateDoor();
            CreatePlatform();
        }

        bool CheckCollision(int newX, int newY)
        {
            for (int i = 0; i < wall.Count; i++)
            {
                if (newX < wall[i].X + wall[i].W && newX + man[0].W > wall[i].X && newY < wall[i].Y + wall[i].H && newY + man[0].H > wall[i].Y)
                {
                    return true;
                }
            }

            return false;
        }

        void CreateMan()
        {
            CActorMan pnn = new CActorMan();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap im = new Bitmap("m" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 35;
            pnn.Y = 1890;
            pnn.W = 50;
            pnn.H = 70;
            pnn.gravity = 0;

            //pnn.Y = 1580;
            //pnn.X = 1360;
            //pnn.X = 1080;
            man.Add(pnn);
        }

        void ManJump()
        {
            int newX, newY;
            if (mSide == 0)
            {
                if (mJ == 0 || mJ == 1)
                {
                    newY = man[0].Y - 60;
                    if (!CheckCollision(man[0].X, newY))
                    {
                        man[0].iFrame = 3;
                        man[0].Y = newY;
                    }
                    mJ++;
                }
                else if (mJ == 2)
                {
                    newX = man[0].X + 25;
                    if (!CheckCollision(newX, man[0].Y))
                    {
                        man[0].iFrame = 4;
                        man[0].X = newX;
                    }
                    mJ++;
                }
                else if (mJ == 3)
                {
                    man[0].iFrame = 0;
                    mJ = 0;
                    jump = 0;
                }
            }
            else if (mSide == 1)
            {
                if (mJ == 0 || mJ == 1)
                {
                    newY = man[0].Y - 60;
                    if (!CheckCollision(man[0].X, newY))
                    {
                        man[0].iFrame = 11;
                        man[0].Y = newY;
                    }
                    mJ++;
                }
                else if (mJ == 2)
                {
                    newX = man[0].X - 25;
                    if (!CheckCollision(newX, man[0].Y))
                    {
                        man[0].iFrame = 12;
                        man[0].X = newX;
                    }
                    mJ++;
                }
                else if (mJ == 3)
                {
                    man[0].iFrame = 8;
                    mJ = 0;
                    jump = 0;
                }
            }
        }

        void ManFlip()
        {
            int newX, newY;
            if (mSide == 0)
            {
                if (mF == 0)
                {
                    newY = man[0].Y - 70;
                    if (!CheckCollision(man[0].X, newY))
                    {
                        man[0].iFrame = 16;
                        man[0].W = 70;
                        man[0].H = 50;
                        man[0].Y = newY;
                    }
                    mF++;
                }
                else if (mF == 1)
                {
                    newX = man[0].X + 40;
                    if (!CheckCollision(newX, man[0].Y))
                    {
                        man[0].iFrame = 17;
                        man[0].W = 50;
                        man[0].H = 70;
                        man[0].X = newX;
                        XScroll += 20;
                    }
                    mF++;
                }
                else if (mF == 2)
                {
                    man[0].iFrame = 18;
                    man[0].W = 70;
                    man[0].H = 50;
                    mF++;
                }
                else if (mF == 3)
                {
                    man[0].iFrame = 0;
                    man[0].W = 50;
                    man[0].H = 70;
                    mF = 0;
                    flip = 0;
                }
            }
            else if (mSide == 1)
            {
                if (mF == 0)
                {
                    newY = man[0].Y - 70;
                    if (!CheckCollision(man[0].X, newY))
                    {
                        man[0].iFrame = 18;
                        man[0].W = 70;
                        man[0].H = 50;
                        man[0].Y = newY;
                    }
                    mF++;
                }
                else if (mF == 1)
                {
                    newX = man[0].X - 40;
                    if (!CheckCollision(newX, man[0].Y))
                    {
                        man[0].iFrame = 17;
                        man[0].W = 50;
                        man[0].H = 70;
                        man[0].X = newX;
                        XScroll -= 20;
                    }
                    mF++;
                }
                else if (mF == 2)
                {
                    man[0].iFrame = 16;
                    man[0].W = 70;
                    man[0].H = 50;
                    mF++;
                }
                else if (mF == 3)
                {
                    man[0].iFrame = 8;
                    man[0].W = 50;
                    man[0].H = 70;
                    mF = 0;
                    flip = 0;
                }
            }
        }

        void ManDie()
        {
            for (int i = 0; i < snail.Count; i++)
            {
                if (snail[i].X >= man[0].X && snail[i].X + snail[i].W <= man[0].X + man[0].W && man[0].Y <= snail[i].Y + snail[i].H && man[0].Y + man[0].H >= snail[i].Y)
                {
                    man[0].X = 35;
                    man[0].Y = 1885;
                    XScroll = 0;
                    kill++;
                }
            }

            for (int i = 0; i < water.Count; i++)
            {
                if (man[0].X >= water[i].X && man[0].X + man[0].W <= water[i].X + water[i].W && man[0].Y > 2000)
                {
                    kill = 3;
                }
            }

            //7ofra
            if (man[0].X >= 1250 && man[0].X <= 1350 && man[0].Y > 2000)
            {
                kill = 3;
            }

            if (monster.Count > 0)
            {
                if (!shield2)
                {
                    if (monster[0].iFrame == 0 && man[0].X >= 1120 && man[0].X <= 1600 && man[0].Y <= 1585 && man[0].Y >= 1575 && man[0].X + man[0].W >= fire[0].X && man[0].X + man[0].W <= fire[0].X + fire[0].W)
                    {
                        man[0].X = 1080;
                        man[0].Y = 1890;
                        kill++;
                    }
                }
            }

            for (int i = 0; i < eggs.Count; i++)
            {
                if (!shield)
                {
                    if (eggs[i].X >= man[0].X && eggs[i].X + eggs[i].W <= man[0].X + man[0].W && man[0].Y <= eggs[i].Y + eggs[i].H && man[0].Y + man[0].H >= eggs[i].Y)
                    {
                        man[0].X = 430;
                        man[0].Y = 1580;
                        kill++;
                    }
                }

            }

        }

        void ManClimbUp()
        {
            if (mCu == 0)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                man[0].X -= 5;
                mCu = 1;
            }
            else if (mCu == 1)
            {

                man[0].iFrame = 7;
                mCu = 2;

            }
            else if (mCu == 2)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                mCu = 3;

            }
            else if (mCu == 3)
            {
                man[0].iFrame = 7;
                mCu = 4;

            }
            else if (mCu == 4)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                mCu = 5;

            }
            else if (mCu == 5)
            {
                man[0].iFrame = 7;
                mCu = 6;

            }
            else if (mCu == 6)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                mCu = 7;
            }
            else if (mCu == 7)
            {
                man[0].iFrame = 7;
                mCu = 8;
            }
            else if (mCu == 8)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                mCu = 9;
            }
            else if (mCu == 9)
            {
                man[0].iFrame = 7;
                mCu = 10;
            }
            else if (mCu == 10)
            {
                man[0].iFrame = 6;
                man[0].Y -= 60;
                mCu = 11;
            }
            else if (mCu == 11)
            {
                man[0].iFrame = 7;
                mCu = 12;
            }
            else if (mCu == 12)
            {
                man[0].iFrame = 0;
                climbUp = 0;
                mCu = 0;
            }

        }
        void ManClimbDown()
        {
            if (mCd == 0)
            {
                man[0].iFrame = 6;
                man[0].Y += 75;
                man[0].X -= 5;
                mCd = 1;
            }
            else if (mCd == 1)
            {

                man[0].iFrame = 7;
                mCd = 2;

            }
            else if (mCd == 2)
            {
                man[0].iFrame = 6;
                man[0].Y += 75;
                mCd = 3;

            }
            else if (mCd == 3)
            {
                man[0].iFrame = 7;
                mCd = 4;

            }
            else if (mCd == 4)
            {
                man[0].iFrame = 6;
                man[0].Y += 75;
                mCd = 5;

            }
            else if (mCd == 5)
            {
                man[0].iFrame = 7;
                mCd = 6;

            }
            else if (mCd == 6)
            {
                man[0].iFrame = 6;
                man[0].Y += 75;
                mCd = 7;
            }
            else if (mCd == 7)
            {
                man[0].iFrame = 0;
                climbDown = 0;
                mCd = 0;
            }

        }

        void Gravity()
        {
            man[0].gravity += gravityFall;

            man[0].Y += man[0].gravity;
            if (jump == 0 || flip == 0)
            {
                onGround = false;
            }

            for (int i = 0; i < ground.Count; i++)
            {
                if (man[0].Y + man[0].H > ground[i].Y && man[0].Y < ground[i].Y + ground[i].H &&
                    man[0].X + man[0].W > ground[i].X && man[0].X + 5 < ground[i].X + ground[i].W)
                {
                    onGround = true;
                    man[0].Y = ground[i].Y - man[0].H;
                    man[0].gravity = 0;
                    break;
                }

                if (onElevator)
                {
                    onGround = true;
                    man[0].Y = elevator[0].Y + elevator[0].H - man[0].H - 11;
                    man[0].gravity = 0;
                    break;

                }

                if (holdPlatform)
                {
                    onGround = true;
                    man[0].Y = platform[0].Y - 5;
                    man[0].gravity = 0;
                    break;
                }
            }
            if (onLadder)
            {
                onGround = true;
                man[0].gravity = 0;

                if (!keyUp && !keyDown)
                {
                    man[0].gravity = 0;
                }
            }

            if (!onGround)
            {
                man[0].gravity += gravityFall;
            }
        }

        void CreateSnail()
        {
            CActorSnail pnn = new CActorSnail();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap im = new Bitmap("s" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 250;
            pnn.Y = 1940;
            pnn.W = 20;
            pnn.H = 15;

            snail.Add(pnn);
        }

        void MoveSnail()
        {
            if (snail[0].X <= 190)
            {
                sSide = 1;
            }
            else if (snail[0].X + snail[0].W >= 280)
            {
                sSide = 0;
            }
            if (sSide == 0)
            {
                if (s == 0)
                {
                    snail[0].iFrame = 0;
                    snail[0].X -= 3;
                    s = 1;
                }
                else if (s == 1)
                {
                    snail[0].iFrame = 1;
                    snail[0].X -= 3;
                    s = 2;
                }
                else if (s == 2)
                {
                    snail[0].iFrame = 2;
                    snail[0].X -= 3;
                    s = 0;
                }
            }
            else if (sSide == 1)
            {
                if (s == 0)
                {
                    snail[0].iFrame = 3;
                    snail[0].X += 3;
                    s = 1;
                }
                else if (s == 1)
                {
                    snail[0].iFrame = 4;
                    snail[0].X += 3;
                    s = 2;
                }
                else if (s == 2)
                {
                    snail[0].iFrame = 5;
                    snail[0].X += 3;
                    s = 0;
                }
            }
        }

        void CreateBird()
        {
            CActorBird pnn = new CActorBird();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap im = new Bitmap("bird" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 250;
            pnn.Y = 1450;
            pnn.W = 60;
            pnn.H = 40;

            bird.Add(pnn);
        }

        void MoveBird()
        {
            if (bird[0].X <= 250)
            {
                bSide = 1;
            }
            else if (bird[0].X + bird[0].W >= 360)
            {
                bSide = 0;
            }
            if (bSide == 0)
            {
                if (b == 0)
                {
                    bird[0].iFrame = 3;
                    bird[0].X -= 3;
                    b = 1;
                }
                else if (b == 1)
                {
                    bird[0].iFrame = 4;
                    bird[0].X -= 3;
                    b = 2;
                }
                else if (b == 2)
                {
                    bird[0].iFrame = 5;
                    bird[0].X -= 3;
                    b = 0;
                }
            }
            else if (bSide == 1)
            {
                if (b == 0)
                {
                    bird[0].iFrame = 0;
                    bird[0].X += 3;
                    b = 1;
                }
                else if (b == 1)
                {
                    bird[0].iFrame = 1;
                    bird[0].X += 3;
                    b = 2;
                }
                else if (b == 2)
                {
                    bird[0].iFrame = 2;
                    bird[0].X += 3;
                    b = 0;
                }
            }
        }

        void CreateEggs()
        {
            CActorEggs pnn = new CActorEggs();
            pnn.im = new Bitmap("egg.png");
            pnn.X = bird[0].X + bird[0].W / 2;
            pnn.Y = bird[0].Y + bird[0].H;
            pnn.W = 15;
            pnn.H = 20;
            pnn.isMove = true;
            eggs.Add(pnn);
        }
        void MoveEggs()
        {
            for (int i = 0; i < eggs.Count; i++)
            {
                if (eggs[i].Y + eggs[i].H == 1650)
                {
                    eggs.RemoveAt(i);
                }

                if (eggs[i].isMove == true)
                {
                    eggs[i].Y += 5;
                }
            }

        }
        void CreateTree()
        {
            CActorTree pnn;

            pnn = new CActorTree();
            pnn.X = -43;
            pnn.Y = 1865;
            pnn.W = 100;
            pnn.H = 105;
            pnn.im = new Bitmap("tree.png");

            tree.Add(pnn);
        }

        void CreateGround()
        {
            CActorGround pnn;

            pnn = new CActorGround();
            pnn.X = -1;
            pnn.Y = 1960;
            pnn.W = 350;
            pnn.H = 40;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 660;
            pnn.Y = 1960;
            pnn.W = 590;
            pnn.H = 40;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 1350;
            pnn.Y = 1960;
            pnn.W = 600;
            pnn.H = 40;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 360;
            pnn.Y = 1890;
            pnn.W = 90;
            pnn.H = 40;
            pnn.im = new Bitmap("highground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 475;
            pnn.Y = 1815;
            pnn.W = 90;
            pnn.H = 40;
            pnn.im = new Bitmap("highground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 610;
            pnn.Y = 1765;
            pnn.W = 360;
            pnn.H = 20;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = -1;
            pnn.Y = 1650;
            pnn.W = 500;
            pnn.H = 15;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 1140;
            pnn.Y = 1650;
            pnn.W = 400;
            pnn.H = 15;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);

            pnn = new CActorGround();
            pnn.X = 1425;
            pnn.Y = 1845;
            pnn.W = 120;
            pnn.H = 15;
            pnn.im = new Bitmap("ground.png");
            ground.Add(pnn);


        }

        void CreateWater()
        {
            CActorWater pnn = new CActorWater();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("w" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 350;
            pnn.Y = 1975;
            pnn.W = 310;
            pnn.H = 30;

            water.Add(pnn);
        }
        void MoveWater()
        {
            if (w == 0)
            {
                water[0].iFrame = 0;
                w = 1;
            }
            else if (w == 1)
            {
                water[0].iFrame = 1;
                w = 2;
            }
            else if (w == 2)
            {
                water[0].iFrame = 2;
                w = 0;
            }

        }

        void CreateLife()
        {
            CActorLife pnn = new CActorLife();
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

            life.Add(pnn);
        }
        void UpdateLife()
        {
            if (kill == 0)
            {
                life[0].iFrame = 0;
            }
            else if (kill == 1)
            {
                life[0].iFrame = 1;
            }
            else if (kill == 2)
            {
                life[0].iFrame = 2;

            }
            else if (kill == 3)
            {
                life[0].iFrame = 3;
                CActorFinal pnn = new CActorFinal();
                pnn.X = 90;
                pnn.Y = 250;
                pnn.W = 210;
                pnn.H = 50;
                pnn.im = new Bitmap("lost.png");
                final.Add(pnn);

                tt.Stop();
            }
        }

        void CreateWarning()
        {
            CActorWarning pnn = new CActorWarning();
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

            warning.Add(pnn);
        }

        void MoveWarning()
        {
            if (ctW == 0)
            {
                warning[0].iFrame = 0;
            }
            else if (ctW == 1)
            {
                warning[0].iFrame = 1;

            }
            else if (ctW == 2)
            {
                warning[0].iFrame = 2;

            }
            else if (ctW == 3)
            {
                warning[0].iFrame = 1;
            }

            ctW++;
            if (ctW == 4)
            {
                ctW = 0;

            }
        }

        void CreateKey()
        {
            CActorKey pnn = new CActorKey();
            pnn.X = 1475;
            pnn.Y = 1815;
            pnn.W = 30;
            pnn.H = 30;
            pnn.im = new Bitmap("key.png");
            key.Add(pnn);
        }

        void CreateDoor()
        {
            CActorDoor pnn = new CActorDoor();
            pnn.X = 1455;
            pnn.Y = 1865;
            pnn.W = 85;
            pnn.H = 95;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("door" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            door.Add(pnn);
        }

        void CreateCoin()
        {
            CActorCoin pnn = new CActorCoin();
            pnn.X = 90;
            pnn.Y = 1625;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 2;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 145;
            pnn.Y = 1625;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 1;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 500;
            pnn.Y = 1790;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 0;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 950;
            pnn.Y = 1740;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 2;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 700;
            pnn.Y = 1935;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 1;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 800;
            pnn.Y = 1935;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 0;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 900;
            pnn.Y = 1935;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 1;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 1430;
            pnn.Y = 1625;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 2;
            coin.Add(pnn);

            pnn = new CActorCoin();
            pnn.X = 1467;
            pnn.Y = 1625;
            pnn.W = 25;
            pnn.H = 25;
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 3; i++)
            {
                Bitmap im = new Bitmap("c" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.ctMC = 0;
            coin.Add(pnn);

        }
        void CreateCoinBar()
        {
            CActorCoinBar pnn = new CActorCoinBar();
            pnn.X = 20;
            pnn.Y = 45;
            pnn.W = 105;
            pnn.H = 30;

            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 10; i++)
            {
                Bitmap im = new Bitmap("cBar" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;

            coinBar.Add(pnn);
        }
        void CheckCoin()
        {
            for (int i = 0; i < coin.Count; i++)
            {
                if (coin[i].X >= man[0].X && coin[i].X + coin[i].W <= man[0].X + man[0].W && man[0].Y + 45 == coin[i].Y)
                {
                    coinsCol++;
                    CreateMoveCoin(i);
                    coin.RemoveAt(i);
                }
            }
        }
        void MoveCoin(int i)
        {
            if (coin[i].ctMC == 0)
            {
                coin[i].iFrame = 0;
                coin[i].ctMC = 1;
            }
            else if (coin[i].ctMC == 1)
            {
                coin[i].iFrame = 1;
                coin[i].ctMC = 2;

            }
            else if (coin[i].ctMC == 2)
            {
                coin[i].iFrame = 2;
                coin[i].ctMC = 3;

            }
            else if (coin[i].ctMC == 3)
            {
                coin[i].iFrame = 1;
                coin[i].ctMC = 0;

            }

        }
        void UpdateCoinBar()
        {
            if (coinsCol == 0)
            {
                coinBar[0].iFrame = 0;
            }
            else if (coinsCol == 1)
            {
                coinBar[0].iFrame = 1;
            }
            else if (coinsCol == 2)
            {
                coinBar[0].iFrame = 2;
            }
            else if (coinsCol == 3)
            {
                coinBar[0].iFrame = 3;
            }
            else if (coinsCol == 4)
            {
                coinBar[0].iFrame = 4;
            }
            else if (coinsCol == 5)
            {
                coinBar[0].iFrame = 5;
            }
            else if (coinsCol == 6)
            {
                coinBar[0].iFrame = 6;
            }
            else if (coinsCol == 7)
            {
                coinBar[0].iFrame = 7;
            }
            else if (coinsCol == 8)
            {
                coinBar[0].iFrame = 8;
            }
            else if (coinsCol == 9)
            {
                coinBar[0].iFrame = 9;
            }

        }
        void CreateMoveCoin(int i)
        {
            CActorMoveCoin pnn = new CActorMoveCoin();
            pnn.X = coin[i].X;
            pnn.Y = coin[i].Y;
            pnn.W = 20;
            pnn.H = 20;
            pnn.im = new Bitmap("c1.png");

            moveCoin.Add(pnn);
        }
        void MoveManCoin()
        {
            for (int i = 0; i < moveCoin.Count; i++)
            {
                moveCoin[i].Y -= 50;

                if (moveCoin[i].Y <= 0)
                {
                    moveCoin.RemoveAt(i);
                }
            }
        }
        void CreateWall()
        {
            CActorWall pnn = new CActorWall();
            pnn.X = 800;
            pnn.Y = 1565;
            pnn.W = 20;
            pnn.H = 200;
            pnn.im = new Bitmap("wall.png");
            wall.Add(pnn);
        }

        void CreateElevator()
        {
            CActorElevator pnn = new CActorElevator();
            pnn.X = 700;
            pnn.Y = 1665;
            pnn.W = 80;
            pnn.H = 100;
            pnn.im = new Bitmap("elevator.png");
            pnn.dirX = 0;
            pnn.dirY = -1;
            pnn.Speed = 5;
            elevator.Add(pnn);
        }
        void MoveElevator()
        {
            if (elevator[0].dirX == 1 && elevator[0].dirY == 0)
            {
                elevator[0].X += elevator[0].Speed;
            }
            else if (elevator[0].dirX == -1 && elevator[0].dirY == 0)
            {
                elevator[0].X -= elevator[0].Speed;
            }
            else if (elevator[0].dirY == 1 && elevator[0].dirX == 0)
            {
                elevator[0].Y += elevator[0].Speed;
            }
            else if (elevator[0].dirY == -1 && elevator[0].dirX == 0)
            {
                elevator[0].Y -= elevator[0].Speed;
            }

            if (elevator[0].Y >= 1665 && elevator[0].X <= 700)
            {
                elevator[0].dirX = 0;
                elevator[0].dirY = -1;

            }
            else if (elevator[0].Y <= 1450 && elevator[0].X <= 700 && elevator[0].dirX == 0 && elevator[0].dirY == -1)
            {
                elevator[0].dirX = -1;
                elevator[0].dirY = 0;
                eSide = 1;
            }
            else if (elevator[0].Y <= 1450 && elevator[0].X <= 700 && elevator[0].dirX == -1 && elevator[0].dirY == 0 && eSide == 0)
            {
                elevator[0].dirX = 0;
                elevator[0].dirY = 1;
            }
            else if (elevator[0].Y <= 1450 && elevator[0].X <= 500)
            {
                elevator[0].dirX = 1;
                elevator[0].dirY = 0;

            }
            else if (elevator[0].Y <= 1450 && elevator[0].X >= 830 && elevator[0].dirX == 1 && elevator[0].dirY == 0)
            {

                elevator[0].dirX = 0;
                elevator[0].dirY = 1;
            }
            else if (elevator[0].Y <= 1450 && elevator[0].X >= 830 && elevator[0].dirX == 0 && elevator[0].dirY == -1)
            {
                elevator[0].dirX = -1;
                elevator[0].dirY = 0;
            }

            else if (elevator[0].Y >= 1665 && elevator[0].X >= 830)
            {
                elevator[0].dirX = 0;
                elevator[0].dirY = -1;
                eSide = 0;
            }

        }

        void CreatePlatform()
        {
            CActorPlatform pnn = new CActorPlatform();
            pnn.X = 1220;
            pnn.Y = 1880;
            pnn.W = 45;
            pnn.H = 10;
            pnn.im = new Bitmap("platform.png");
            pnn.dirX = 1;
            pnn.Speed = 3;
            platform.Add(pnn);
        }

        void MovePlatform()
        {
            if (platform[0].dirX == 1)
            {
                platform[0].X += platform[0].Speed;
            }
            else if (platform[0].dirX == -1)
            {
                platform[0].X -= platform[0].Speed;
            }

            if (platform[0].X <= 1225)
            {
                platform[0].dirX = 1;
            }
            else if (platform[0].X >= 1350)
            {
                platform[0].dirX = -1;
            }
        }

        void CreateLadder()
        {
            CActorLadder pnn = new CActorLadder();
            pnn.X = 1150;
            pnn.Y = 1650;
            pnn.W = 27;
            pnn.H = 319;
            pnn.im = new Bitmap("ladder.png");
            ladder.Add(pnn);
        }

        void CreateMonster()
        {
            CActorMonster pnn = new CActorMonster();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("monster" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 1325;
            pnn.Y = 1550;
            pnn.W = 70;
            pnn.H = 100;

            monster.Add(pnn);
        }

        void MoveMonster()
        {
            if (ctMon < 15)
            {
                monster[0].iFrame = 0;

                drawLaser = true;

            }
            else if (ctMon < 30)
            {
                drawLaser = false;
                monster[0].iFrame = 1;
            }
            else if (ctMon == 45)
            {
                ctMon = 0;
            }

            ctMon++;
        }

        void CreateFire()
        {
            CActorFire pnn = new CActorFire();
            pnn.im = new Bitmap("fire.png");
            pnn.X = monster[0].X - 135;
            pnn.Y = monster[0].Y + 35;
            pnn.W = 180;
            pnn.H = 10;

            fire.Add(pnn);
        }

        void CreateBow()
        {
            CActorBow pnn = new CActorBow();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("bow" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            pnn.iFrame = 0;
            pnn.X = 1200;
            pnn.Y = 1600;
            pnn.W = 45;
            pnn.H = 55;

            bow.Add(pnn);
        }

        void CreateMultipleArrow(int arrowSide)
        {
            CActorArrow pnn = new CActorArrow();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("arrow" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            if (arrowSide == 0)
            {
                pnn.iFrame = 0;
                if (bow.Count > 0)
                {
                    pnn.X = bow[0].X + bow[0].W;
                }
            }
            else
            {
                if (bow.Count > 0)
                {
                    pnn.X = bow[0].X;
                }
                pnn.iFrame = 1;
            }
            if (bow.Count > 0)
            {
                pnn.Y = bow[0].Y + bow[0].H / 2 - 5;
            }
            pnn.W = 30;
            pnn.H = 10;
            pnn.isMove = true;
            pnn.aSide = arrowSide;
            multipleArrow.Add(pnn);
        }

        void MoveMultipleArrow()
        {
            for (int i = 0; i < multipleArrow.Count; i++)
            {
                if (monster.Count > 0)
                {
                    if (multipleArrow[i].X + multipleArrow[i].W == monster[0].X + 5 && multipleArrow[i].Y >= monster[0].Y && multipleArrow[i].Y + multipleArrow[i].H <= monster[0].Y + monster[0].H)
                    {
                        multipleArrow.RemoveAt(i);
                        monsterShot++;

                        if (monsterShot >= 3)
                        {
                            monster.RemoveAt(0);
                        }
                    }
                }
            }
            for (int i = 0; i < multipleArrow.Count; i++)
            {
                if (multipleArrow[i].isMove == true)
                {
                    if (multipleArrow[i].aSide == 0)
                    {
                        multipleArrow[i].X += 5;
                    }
                    else
                    {
                        multipleArrow[i].X -= 5;

                    }
                }
            }

        }

        void CreateSingleArrow(int arrowSide)
        {
            CActorArrow pnn = new CActorArrow();
            pnn.imgs = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap im = new Bitmap("arrow" + (i + 1) + ".png");
                im.MakeTransparent();
                pnn.imgs.Add(im);
            }
            if (arrowSide == 0)
            {
                pnn.iFrame = 0;
                if (bow.Count > 0)
                {
                    pnn.X = bow[0].X + bow[0].W;
                }
            }
            else
            {
                if (bow.Count > 0)
                {
                    pnn.X = bow[0].X;
                }
                pnn.iFrame = 1;
            }
            if (bow.Count > 0)
            {
                pnn.Y = bow[0].Y + bow[0].H / 2 - 5;
            }
            pnn.W = 30;
            pnn.H = 10;
            pnn.isMove = true;
            pnn.aSide = arrowSide;
            singleArrow.Add(pnn);
        }

        void MoveSingleArrow()
        {
            for (int i = 0; i < singleArrow.Count; i++)
            {
                if (monster.Count > 0)
                {
                    if (singleArrow[i].X + singleArrow[i].W == monster[0].X + 5 && singleArrow[i].Y >= monster[0].Y && singleArrow[i].Y + singleArrow[i].H <= monster[0].Y + monster[0].H)
                    {
                        singleArrow.RemoveAt(i);
                        monsterShot++;

                        if (monsterShot >= 3)
                        {
                            monster.RemoveAt(0);
                        }
                    }
                }


                if (singleArrow[i].isMove == true)
                {
                    if (singleArrow[i].aSide == 0)
                    {
                        singleArrow[i].X += 5;
                    }
                    else
                    {
                        singleArrow[i].X -= 5;

                    }
                }
            }

        }
     

        void CreateStart()
        {
            CActorStart pnn = new CActorStart();
            pnn.X = 90;
            pnn.Y = 1865;
            pnn.W = 90;
            pnn.H = 100;
            pnn.im = new Bitmap("start.png");

            start.Add(pnn);

            pnn = new CActorStart();
            pnn.X = 100;
            pnn.Y = 1865;
            pnn.W = 45;
            pnn.H = 55;
            pnn.im = new Bitmap("finger.png");

            start.Add(pnn);
        }

        void CreateBack()
        {
            CActorBack pnn = new CActorBack();
            pnn.im = new Bitmap("back.jpg");
            pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            pnn.rcSrc = new Rectangle(XScroll, YScroll, this.ClientSize.Width, this.ClientSize.Height);
            back.Add(pnn);
        }


        void DrawScene(Graphics g)
        {
            for (int i = 0; i < back.Count; i++)
            {
                g.DrawImage(back[i].im, back[i].rcDst, back[i].rcSrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < ground.Count; i++)
            {
                g.DrawImage(ground[i].im, ground[i].X - XScroll, ground[i].Y - YScroll, ground[i].W, ground[i].H);
            }

            for (int i = 0; i < tree.Count; i++)
            {
                g.DrawImage(tree[i].im, tree[i].X - XScroll, tree[i].Y - YScroll, tree[i].W, tree[i].H);
            }

            for (int i = 0; i < water.Count; i++)
            {
                g.DrawImage(water[i].imgs[water[i].iFrame], water[i].X - XScroll, water[i].Y - YScroll, water[i].W, water[i].H);

            }
            for (int i = 0; i < snail.Count; i++)
            {
                g.DrawImage(snail[i].imgs[snail[i].iFrame], snail[i].X - XScroll, snail[i].Y - YScroll, snail[i].W, snail[i].H);
            }
            for (int i = 0; i < bird.Count; i++)
            {
                g.DrawImage(bird[i].imgs[bird[i].iFrame], bird[i].X - XScroll, bird[i].Y - YScroll, bird[i].W, bird[i].H);
            }
            for (int i = 0; i < eggs.Count; i++)
            {
                g.DrawImage(eggs[i].im, eggs[i].X - XScroll, eggs[i].Y - YScroll, eggs[i].W, eggs[i].H);
            }

            for (int i = 0; i < start.Count; i++)
            {
                g.DrawImage(start[i].im, start[i].X - XScroll, start[i].Y - YScroll, start[i].W, start[i].H);
            }
            for (int i = 0; i < life.Count; i++)
            {
                g.DrawImage(life[i].imgs[life[i].iFrame], life[i].X, life[i].Y, life[i].W, life[i].H);

            }

            if (kill > 0)
            {
                for (int i = 0; i < warning.Count; i++)
                {
                    g.DrawImage(warning[i].imgs[warning[i].iFrame], warning[i].X, warning[i].Y, warning[i].W, warning[i].H);
                }
            }
            for (int i = 0; i < coinBar.Count; i++)
            {
                g.DrawImage(coinBar[i].imgs[coinBar[i].iFrame], coinBar[i].X, coinBar[i].Y, coinBar[i].W, coinBar[i].H);
            }
            for (int i = 0; i < coin.Count; i++)
            {
                g.DrawImage(coin[i].imgs[coin[i].iFrame], coin[i].X - XScroll, coin[i].Y - YScroll, coin[i].W, coin[i].W);
            }


            for (int i = 0; i < key.Count; i++)
            {
                g.DrawImage(key[i].im, key[i].X - XScroll, key[i].Y - YScroll, key[i].W, key[i].H);

            }

            for (int i = 0; i < ladder.Count; i++)
            {
                g.DrawImage(ladder[i].im, ladder[i].X - XScroll, ladder[i].Y - YScroll, ladder[i].W, ladder[i].H);

            }


            for (int i = 0; i < monster.Count; i++)
            {
                if (drawLaser)
                {
                    g.DrawImage(fire[i].im, fire[i].X - XScroll, fire[i].Y - YScroll, fire[i].W, fire[i].H);

                }

                g.DrawImage(monster[i].imgs[monster[i].iFrame], monster[i].X - XScroll, monster[i].Y - YScroll, monster[i].W, monster[i].H);

            }

            if (showDoor)
            {
                for (int i = 0; i < door.Count; i++)
                {
                    g.DrawImage(door[i].imgs[door[i].iFrame], door[i].X - XScroll, door[i].Y - YScroll, door[i].W, door[i].H);

                }
            }

            for (int i = 0; i < platform.Count; i++)
            {
                g.DrawImage(platform[i].im, platform[i].X - XScroll, platform[i].Y - YScroll, platform[i].W, platform[i].H);

            }

            for (int i = 0; i < man.Count; i++)
            {
                if (shield)
                {
                    shieldX = man[i].X - 20 - XScroll;
                    shieldY = man[i].Y - 10 - YScroll;
                    shieldW = man[i].W + 40;
                    shieldH = man[i].H + 20;
                    g.DrawRectangle(new Pen(Color.Yellow, 5), shieldX, shieldY, shieldW, shieldW);
                }

                if (shield2)
                {
                    shield2X = man[i].X - 20 - XScroll;
                    shield2Y = man[i].Y - 10 - YScroll;
                    shield2W = man[i].W + 40;
                    shield2H = man[i].H + 20;
                    g.DrawRectangle(new Pen(Color.Red, 5), shield2X, shield2Y, shield2W, shield2W);
                }

                g.DrawImage(man[i].imgs[man[i].iFrame], man[i].X - XScroll, man[i].Y - YScroll, man[i].W, man[i].H);
            }

            for (int i = 0; i < bow.Count; i++)
            {
                g.DrawImage(bow[i].imgs[bow[i].iFrame], bow[i].X - XScroll, bow[i].Y - YScroll, bow[i].W, bow[i].H);

            }

            for (int i = 0; i < singleArrow.Count; i++)
            {
                g.DrawImage(singleArrow[i].imgs[singleArrow[i].iFrame], singleArrow[i].X - XScroll, singleArrow[i].Y - YScroll, singleArrow[i].W, singleArrow[i].H);

            }

            for (int i = 0; i < multipleArrow.Count; i++)
            {
                g.DrawImage(multipleArrow[i].imgs[multipleArrow[i].iFrame], multipleArrow[i].X - XScroll, multipleArrow[i].Y - YScroll, multipleArrow[i].W, multipleArrow[i].H);

            }

            for (int i = 0; i < wall.Count; i++)
            {
                g.DrawImage(wall[i].im, wall[i].X - XScroll, wall[i].Y - YScroll, wall[i].W, wall[i].H);

            }
            for (int i = 0; i < moveCoin.Count; i++)
            {
                g.DrawImage(moveCoin[i].im, moveCoin[i].X - XScroll, moveCoin[i].Y - YScroll, moveCoin[i].W, moveCoin[i].H);
            }
            for (int i = 0; i < elevator.Count; i++)
            {
                g.DrawImage(elevator[i].im, elevator[i].X - XScroll, elevator[i].Y - YScroll, elevator[i].W, elevator[i].H);

            }

            for (int i = 0; i < final.Count; i++)
            {
                g.DrawImage(final[i].im, final[i].X, final[i].Y, final[i].W, final[i].H);

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
