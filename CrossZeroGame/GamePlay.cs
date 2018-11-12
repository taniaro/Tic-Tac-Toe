using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossZeroGame
{
    //methods for the computer's game side
    public static class GamePlay
    {
        //victory combinations checking
        public static int CheckVictory(int[,] pf, int sz)
        {
            //columns
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if ((pf[i, j] == 1) && (pf[i, j + 1] == 1) && (pf[i, j + 2] == 1))
                        return 1;
                    else
                    if ((pf[i, j] == 2) && (pf[i, j + 1] == 2) && (pf[i, j + 2] == 2))
                        return 2;
                }
            }
            //rows
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    if ((pf[i, j] == 1) && (pf[i + 1, j] == 1) && (pf[i + 2, j] == 1))
                        return 1;
                    else
                    if ((pf[i, j] == 2) && (pf[i + 1, j] == 2) && (pf[i + 2, j] == 2))
                        return 2;
                }
            }
            //diagonals
            if (pf[0, 0] == pf[1, 1] && pf[1, 1] == pf[2, 2])
                return pf[0, 0];
            if (pf[0, 2] == pf[1, 1] && pf[1, 1] == pf[2, 0])
                return pf[0, 2];
            //game is going - return 0
            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    if (pf[i, j] == 0) return 0;
                }
            }
            //tie - return 3
            return 3;
        }


        //warning for medium level
        public static Tuple<int, int> DiagonalWarning(int n, int[,] pf, int sz)
        {
            int p1 = -1; int p2 = -1;

            if (pf[0, 0] == n && pf[1, 1] == n && pf[2, 2] == 0) { p1 = 2; p2 = 2; }
            if (pf[0, 0] == 0 && pf[1, 1] == n && pf[2, 2] == n) { p1 = 0; p2 = 0; }
            if (pf[0, 2] == n && pf[1, 1] == n && pf[2, 0] == 0) { p1 = 2; p2 = 0; }
            if (pf[0, 2] == 0 && pf[1, 1] == n && pf[2, 0] == n) { p1 = 0; p2 = 2; }

            return Tuple.Create(p1, p2);
        }


        //warning for hard level
        public static Tuple<int, int> MegaWarning(int n, int[,] pf, int sz)
        {
            int p1 = -1, p2 = -1;
            for (int i = 0; i < sz; i++)
            {
                if (pf[i, 0] == n && pf[i, 1] == n && pf[i, 2] == 0)
                { p1 = i; p2 = 2; }
                else if (pf[i, 0] == n && pf[i, 1] == 0 && pf[i, 2] == n)
                { p1 = i; p2 = 1; }
                else if (pf[i, 0] == 0 && pf[i, 1] == n && pf[i, 2] == n)
                { p1 = i; p2 = 0; }
            }

            for (int i = 0; i < sz; i++)
            {
                if (pf[0, i] == n && pf[1, i] == n && pf[2, i] == 0)
                { p1 = 2; p2 = i; }
                else if (pf[0, i] == n && pf[1, i] == 0 && pf[2, i] == n)
                { p1 = 1; p2 = 0; }
                else if (pf[0, i] == 0 && pf[1, i] == n && pf[2, i] == n)
                { p1 = 0; p2 = i; }
            }

            var r = DiagonalWarning(n, pf, sz);
            if (p1 == -1 && p2 == -1)
            { p1 = r.Item1; p2 = r.Item2; }
            return Tuple.Create(p1, p2);
        }

        //for easy level - placing the random position
        public static void PlaceRandom(int[,] pf, PictureBox[,] pics, int comp_step, Image compimg )
        {
            Random rn = new Random();
            bool done = false;
            int s1, s2;
            do
            {
                s1 = rn.Next(0, 3);
                s2 = rn.Next(0, 3);
                if (pf[s1, s2] == 0)
                {
                    pf[s1, s2] = comp_step;
                    done = true;
                }
            } while (done != true);

            pics[s1, s2].BackgroundImage = compimg;
            pics[s1, s2].BackgroundImageLayout = ImageLayout.Zoom;
        }


        //for medium and hard level - computer protect diagonals
        public static void PlaceDiagonal(int[,] pf, PictureBox[,] pics, int comp_step, Image compimg, out bool isplace)
        {
            isplace = false;
            if (pf[1, 1] == 0)
            {
                pf[1, 1] = comp_step;
                isplace = true;
                pics[1, 1].BackgroundImage = compimg;
                pics[1, 1].BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (pf[0, 0] == 0 || pf[0, 2] == 0 || pf[2, 0] == 0 || pf[2, 2] == 0)
            {
                Random rn = new Random();
                int[] d = { 0, 2 };
                bool done = false;
                int s1, s2;
                do
                {
                    int p1 = rn.Next(0, d.Length);
                    int p2 = rn.Next(0, d.Length);
                    s1 = d[p1];
                    s2 = d[p2];
                    if (pf[s1, s2] == 0)
                    {
                        pf[s1, s2] = comp_step;
                        done = true;
                    }
                }
                while (done != true);
                pics[s1, s2].BackgroundImage = compimg;
                pics[s1, s2].BackgroundImageLayout = ImageLayout.Zoom;
                isplace = true;
            }
        }

        //computer's step on the easy level
        public static void EasyCompStep(int[,] pf, PictureBox[,] pics, int comp_step, Image compimg)
        {
            PlaceRandom(pf, pics, comp_step, compimg);
        }

        //computer's step on the medium level
        public static void MediumCompStep(int[,] pf, int sz, PictureBox[,] pics, int comp_step, int usr_step, Image compimg)
        {
            //looking for 2 elements on diagonals with computer's icon
            var a = DiagonalWarning(comp_step, pf, sz);
            int a1 = a.Item1; int a2 = a.Item2;
            if (a1 != -1 && a2 != -1)
            {
                pf[a1, a2] = comp_step;
                pics[a1, a2].BackgroundImage = compimg;
                pics[a1, a2].BackgroundImageLayout = ImageLayout.Zoom;
                return;
            }
            //looking for 2 elements on diagonals with user's icon
            a = DiagonalWarning(usr_step, pf, sz);
            a1 = a.Item1; a2 = a.Item2;
            if (a1 != -1 && a2 != -1)
            {
                pf[a1, a2] = comp_step;
                pics[a1, a2].BackgroundImage = compimg;
                pics[a1, a2].BackgroundImageLayout = ImageLayout.Zoom;
                return;
            }
            //if no = placing on diagonal
            if (a1 == -1 && a2 == -1)
            {
                bool isplace;
                PlaceDiagonal(pf, pics, comp_step, compimg, out isplace);
                if (isplace == false)
                    PlaceRandom(pf, pics, comp_step, compimg);
            }

        }

        //computer's step on the hard level
        public static void HardCompStep(int[,] pf, int sz, PictureBox[,] pics, int comp_step, int usr_step, Image compimg)
        {
            //looking for 2 elements on diagonals/rows/columns with computer's icon
            var a = MegaWarning(comp_step, pf, sz);
            int a1 = a.Item1; int a2 = a.Item2;

            if (a1 != -1 && a2 != -1)
            {
                pf[a1, a2] = comp_step;
                pics[a1, a2].BackgroundImage = compimg;
                pics[a1, a2].BackgroundImageLayout = ImageLayout.Zoom;
                return;
            }
            //looking for 2 elements on diagonals/rows/columns with user's icon
            a = MegaWarning(usr_step, pf, sz);
            a1 = a.Item1; a2 = a.Item2;
            if (a1 != -1 && a2 != -1)
            {
                pf[a1, a2] = comp_step;
                pics[a1, a2].BackgroundImage = compimg;
                pics[a1, a2].BackgroundImageLayout = ImageLayout.Zoom;
                return;
            }

            //if no = placing on diagonal or random
            if (a1 == -1 && a2 == -1)
            {
                bool place_in_diagonal;
                PlaceDiagonal(pf, pics, comp_step, compimg, out place_in_diagonal);
                if (place_in_diagonal == false)
                    PlaceRandom(pf, pics, comp_step, compimg);
            }
        }

    }
}
