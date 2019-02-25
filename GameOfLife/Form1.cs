using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numOfCells = 80;
        private int cellSize = 6;
        private int iterations = 0;
        private int currentAliveCells;
        private bool showGrid = true;
        private Timer timer = new Timer();

        private bool[,] cells;

        private void Form1_Load(object sender, EventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel1, new object[] { true });

            SetBoard();
            
            timer.Interval = (75); // in ms
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void SetBoard()
        {
            iterations = 0;
            cells = new bool[numOfCells, numOfCells];
            Random random = new Random();
            int number;

            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    number = random.Next(0, 20);
                    cells[i, j] = ((number == 0) ? true : false);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //refresh here...
            if(iterations++ == 150) SetBoard();
            iterationsNumLabel.Text = iterations.ToString();

            currentAliveCells = 0;
            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    if (cells[i, j])
                    {
                        currentAliveCells++;
                    }
                }
            }
            aliveCountNumLabel.Text = currentAliveCells.ToString();
            panel1.Refresh();
        }

        public void NewStep()
        {
            for (int i = 0; i < numOfCells; i++)
            {
                for(int j = 0; j < numOfCells; j++)
                {
                    int aliveNeighbors = LiveOrDie(i, j);

                    if (cells[i, j])
                    {
                        if(aliveNeighbors < 2)
                        {
                            cells[i, j] = false;
                        }
                        if(aliveNeighbors > 3)
                        {
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (aliveNeighbors == 3)
                        {
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }

        public int LiveOrDie(int x, int y)
        {
            int aliveCount = 0;

            for(int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if(!((i < 0 || j < 0) || (i >= numOfCells || j >= numOfCells)))
                    {
                        if (cells[i, j] == true) aliveCount++;
                    }
                }
            }

            return aliveCount;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Pen p = new Pen(Color.Black);

            if (showGrid)
            {
                for (int y = 0; y <= numOfCells; ++y)
                {
                    g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
                }

                for (int x = 0; x <= numOfCells; ++x)
                {
                    g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
                }
            }

            for (int i = 0; i < numOfCells; i++)
            {
                for (int j = 0; j < numOfCells; j++)
                {
                    if (cells[i, j])
                    {
                        using (Brush brush = new SolidBrush(Color.FromArgb(255, 108, 19, 43)))
                        {
                            g.FillRectangle(brush, i * cellSize, j * cellSize, cellSize, cellSize);
                        }
                    }
                }
            }
            NewStep();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void TimerSpeedTrackBar_Click(object sender, EventArgs e)
        {
            timer.Interval = (timerSpeedTrackBar.Value);
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            SetBoard();
        }

        private void GridVisibilityButton_Click(object sender, EventArgs e)
        {
            showGrid = !showGrid;
        }
    }
}
