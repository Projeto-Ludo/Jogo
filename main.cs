using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(MapWidth * Blocksize, (MapHeight * Blocksize) + (MapHeight * MapHeight));
            Intializemap();
            Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            playerX = 1;
            playerY = 6;

        }
        private const int MapWidth = 15;
        private const int MapHeight = 15;
        private const int Blocksize = 30;
        private int playerX;
        private int playerY;
        private bool[,] map;
        private void Intializemap()
        {
            map = new bool[MapWidth, MapHeight]
            {
                {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,true,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,false,false,false,false,false,false,true,false },
                {false,true,true,true,true,true,false,false,false,true,true,true,true,true,false },
                {false,true,false,false,false,false,false,false,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,true,true,false,false,false,false,false,false },
                {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false }
            };
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    bool isPath = map[x, y];
                    Brush brush = isPath ? Brushes.Green : Brushes.White;
                    Pen pen = isPath ? Pens.DarkGreen : Pens.Black;

                    int xPos = x * Blocksize;
                    int yPos = y * Blocksize;

                    g.FillRectangle(brush, xPos, yPos, Blocksize, Blocksize);
                    g.DrawRectangle(pen, xPos, yPos, Blocksize, Blocksize);

                }
            }
            //Quadrados
            int a1 = 0;
            int a2 = 0;
            int a3 = 180;
            Brush a = Brushes.Green;
            g.FillRectangle(a, a1, a2, a3, a3);

            a1 = 0;
            a2 = 270;
            a = Brushes.Red;
            g.FillRectangle(a, a1, a2, a3, a3);

            //Triangulos
            Point ponto1 = new Point(180, 180);
            Point ponto2 = new Point(270, 180);
            Point ponto3 = new Point(225, 225);
            Point[] pontosTriangulo = { ponto1, ponto2, ponto3 };
            g.DrawPolygon(Pens.Black, pontosTriangulo);
            Brush brus = Brushes.Green;
            g.FillPolygon(brus, pontosTriangulo);

            ponto1 = new Point(180, 270);
            ponto2 = new Point(270, 270);
            ponto3 = new Point(225, 225);
            pontosTriangulo = new Point[] { ponto1, ponto2, ponto3 };
            g.DrawPolygon(Pens.Black, pontosTriangulo);
            brus = Brushes.Blue;
            g.FillPolygon(brus, pontosTriangulo);

            ponto1 = new Point(180, 270);
            ponto2 = new Point(180, 180);
            ponto3 = new Point(225, 225);
            pontosTriangulo = new Point[] { ponto1, ponto2, ponto3 };
            g.DrawPolygon(Pens.Black, pontosTriangulo);
            brus = Brushes.Red;
            g.FillPolygon(brus, pontosTriangulo);

            ponto1 = new Point(270, 180);
            ponto2 = new Point(270, 270);
            ponto3 = new Point(225, 225);
            pontosTriangulo = new Point[] { ponto1, ponto2, ponto3 };
            g.DrawPolygon(Pens.Black, pontosTriangulo);
            brus = Brushes.Yellow;
            g.FillPolygon(brus, pontosTriangulo);

            //Adicionando o jogador
            Brush playerBrush = Brushes.Red;
            Pen playerPen = Pens.DarkRed;
            int playerSize = Blocksize / 2;
            int playerOffset = (Blocksize - playerSize) / 2;
            int playerPosX = playerX * Blocksize + playerOffset;
            int playerPosY = playerY * Blocksize + playerOffset;

            g.FillEllipse(playerBrush, playerPosX, playerPosY, playerSize, playerSize);
            g.DrawEllipse(playerPen, playerPosX, playerPosY, playerSize, playerSize);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            map[5, 0] = true;
            int newPlayerX = playerX;
            int newPlayerY = playerY;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (playerX > 0)
                    {
                        if (map[playerX + 1, playerY] || map[playerX, playerY + 1])
                        {
                            if (playerX == 9 && playerY == 8)
                            {
                                newPlayerX = 8;
                                newPlayerY = 9;
                            }
                            else
                            {
                                newPlayerX = --playerX;
                            }
                        }

                    }
                    break;
                case Keys.Right:
                    if (playerX < MapWidth - 1)
                    {
                        if (map[playerX + 1, playerY] || map[playerX, playerY + 1])
                        {
                            if (playerX == 5 && playerY == 6)
                            {
                                newPlayerX = 6;
                                newPlayerY = 5;
                            }
                            else
                            {
                                newPlayerX = ++playerX;
                            }
                        }
                    }
                    break;
                case Keys.Up:
                    if (playerX >= 6)
                    {
                        if (map[playerX + 1, playerY] || map[playerX, playerY + 1])
                        {
                            if (playerX == 6 && playerY == 9)
                            {
                                newPlayerX = 5;
                                newPlayerY = 9;
                            }
                            else
                            {
                                newPlayerY = --playerY;
                            }
                        }
                    }
                    break;
                case Keys.Down:
                    if (playerY < MapHeight - 1)
                    {
                        if (map[playerX + 1, playerY] || map[playerX, playerY + 1])
                        {
                            if (playerX == 8 && playerY == 5)
                            {
                                newPlayerX = 9;
                                newPlayerY = 6;
                            }
                            else
                            {
                                newPlayerY = ++playerY;
                            }
                        }
                    }
                    break;

                    /*
                      if(map[playerX+1,PlayerY]==true || map[playerX,playerY+1]){
                        A1[5,6];A2[6,5] l
                        B1[8,5];B2[9,6]
                        C1[9,8];C2[8,9]
                        D1[6,9];D2[5,9]
                      }
                    */
            }

            playerX = newPlayerX;
            playerY = newPlayerY;

            Invalidate();
        }
    }
}
