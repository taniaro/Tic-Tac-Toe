using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CrossZeroGame
{
    public enum levels
    {
        easy,
        medium,
        hard
    }
    public partial class Form1 : Form
    {
        private Image Pacman = Properties.Resources.pacman1;
        private Image Ghost = Properties.Resources.ghost1;
        public Image usrimg;
        public Image compimg;
        private int usr_step = 1;
        private int comp_step = 2;
        private int GameStatus;
        const int sz = 3;
        public int[,] pf = new int[sz,sz];
        public PictureBox[,] pics = new PictureBox[sz, sz];

        public levels GameMode;
        public Form1()
        {
            InitializeComponent();
            pics[0, 0] = Box1;
            pics[1, 0] = Box2;
            pics[2, 0] = Box3;
            pics[0, 1] = Box4;
            pics[1, 1] = Box5;
            pics[2, 1] = Box6;
            pics[0, 2] = Box7;
            pics[1, 2] = Box8;
            pics[2, 2] = Box9;

            tabControl1.SelectTab(tabPage1);
        }

        //вибір героя
        private void goToChoosingLevel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            usrimg = userChoosePacman.Checked ? Pacman : Ghost;
            compimg = !userChoosePacman.Checked ? Pacman : Ghost;
        }

        //вибір рівня
        private void StartGame_Click(object sender, EventArgs e)
        {
            if (easyLevel.Checked) GameMode = levels.easy;
            else if (middleLevel.Checked) GameMode = levels.medium;
            else if (hardLevel.Checked) GameMode = levels.hard;
            tabControl1.SelectTab(tabPage3);
            Play();
        }

        //початок гри
        private void Play()
        {
            for(int i=0; i<sz; i++)
            {
                for(int j=0; j<sz; j++)
                {
                    pf[i,j] = 0;
                }
            }
            Box1.BackgroundImage = null;
            Box2.BackgroundImage = null;
            Box3.BackgroundImage = null;
            Box4.BackgroundImage = null;
            Box5.BackgroundImage = null;
            Box6.BackgroundImage = null;
            Box7.BackgroundImage = null;
            Box8.BackgroundImage = null;
            Box9.BackgroundImage = null;
            GameStatus = 0;
            timer1.Enabled = true;
        }

        //крок користувача
        private void UserStep(int n1, int n2)
        {
            if (pf[n1, n2] == 0)
                pf[n1, n2] = usr_step;
            if (GamePlay.CheckVictory(pf, sz) == 0)
            {
                GameStatus = 1;
                timer1.Enabled = true;
            }
            else
                ShowVictoryMessage(GamePlay.CheckVictory(pf, sz));
        }

        //вибір кроку комп'ютера
        private void CompStep()
        {
            switch (GameMode)
            {
                case levels.easy:
                    GamePlay.EasyCompStep(pf, pics, comp_step, compimg);
                    break;
                case levels.medium:
                    GamePlay.MediumCompStep(pf, sz, pics, comp_step, usr_step, compimg);
                    break;
                case levels.hard:
                    GamePlay.HardCompStep(pf, sz, pics, comp_step, usr_step, compimg);
                    break;
                default:
                    break;
            }
        }
          
        //виведення повідомлення про перемогу
        private void ShowVictoryMessage(int m)
        {
            timer1.Enabled = false;
            string message1="";
            if (m == 1)
                message1 = "Ви виграли!";
            if(m == 2)
                message1 = "Перемога комп'ютера!";
            if(m == 3)
                message1 = "Нічия!";

            string message2 = " Грати ще?";
            string message = message1 + message2;
            string caption = "Результат гри";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if(result == DialogResult.Yes)
            {
                GameStatus = 2;
                tabControl1.SelectTab(tabPage1);
            }
            if (result == DialogResult.No)
                Application.Exit();
        }

        //таймер для керування режимом гри(хід користувача, компа, чи нова гра)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameStatus == 2)
                Play();

            if (GameStatus == 0)
                timer1.Enabled = false;
            if (GameStatus == 1)
            {
                CompStep();
                GameStatus = 0;

                if (GamePlay.CheckVictory(pf, sz) != 0)
                {
                    ShowVictoryMessage(GamePlay.CheckVictory(pf, sz));
                }
            }
        }

        //кліки по картинках
        private void Box1_Click(object sender, EventArgs e)
        {
            if(GameStatus == 0 && pf[0, 0] == 0)
            {
                Box1.BackgroundImage = usrimg;
                Box1.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(0,0);
            }
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[1, 0] == 0)
            {
                Box2.BackgroundImage = usrimg;
                Box2.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(1, 0);
            }
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[2,0] == 0)
            {
                Box3.BackgroundImage = usrimg;
                Box3.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(2,0);
            }
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[0,1] == 0)
            {
                Box4.BackgroundImage = usrimg;
                Box4.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(0,1);
            }
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[1,1] == 0)
            {
                Box5.BackgroundImage = usrimg;
                Box5.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(1,1);
            }
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[2,1] == 0)
            {
                Box6.BackgroundImage = usrimg;
                Box6.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(2,1);
            }
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[0,2] == 0)
            {
                Box7.BackgroundImage = usrimg;
                Box7.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(0,2);
            }
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[1,2] == 0)
            {
                Box8.BackgroundImage = usrimg;
                Box8.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(1,2);
            }
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            if (GameStatus == 0 && pf[2,2] == 0)
            {
                Box9.BackgroundImage = usrimg;
                Box9.BackgroundImageLayout = ImageLayout.Zoom;
                UserStep(2,2);
            }
        }


    }
}
