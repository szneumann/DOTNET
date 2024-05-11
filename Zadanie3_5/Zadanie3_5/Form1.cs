using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Zadanie3_5
{
    public partial class Form1 : Form
    {
        private const int Szerokosc = 1200; // Szerokość okna
        private const int Wysokosc = 500; // Wysokość okna
        private const int Margines = 1; // Margines od krawędzi okna
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Główne okno
            Text = "Szymon Neumann Sinusoida";
            Size = new Size(Szerokosc, Wysokosc);
            Paint += Form1_Paint; // Dodanie obsługi zdarzenia 
        }

        private void RysujXY()
        {
            using (Graphics g = CreateGraphics())
            {
                Pen osYPen = new Pen(Color.Black, 3); // Ustawienie koloru i grubości linii osi
                Pen osXPen = new Pen(Color.Red, 3); // Ustawienie koloru i grubości linii osi

                Pen osYMAXPen = new Pen(Color.OrangeRed, 1); // Ustawienie koloru i grubości linii osi
                Pen osYMINPen = new Pen(Color.OrangeRed, 1); // Ustawienie koloru i grubości linii osi


                // Rysowanie osi X
                g.DrawLine(osXPen, Margines, Wysokosc / 2, Szerokosc - Margines, Wysokosc / 2);
                // Rysowanie osi Y
                g.DrawLine(osYPen, Szerokosc / 2, Margines, Szerokosc / 2, Wysokosc - Margines);
                //g.DrawLine(osYMAXPen, Szerokosc / 2, Margines, Szerokosc / 2, Wysokosc - Margines + 100);
                g.DrawLine(osYMAXPen, Margines, 100 + Wysokosc / 2, Szerokosc - Margines, 100 + Wysokosc / 2);
                g.DrawLine(osYMINPen, Margines, -100 + Wysokosc / 2, Szerokosc - Margines, -100 + Wysokosc / 2);

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Rysowanie osi X i Y
            RysujXY();
            // Rysowanie sinusoidy
            PlotSinusoid(e.Graphics);
        }

        private void PlotSinusoid(Graphics g)
        {
            float step = 0.1f; // Krok dla argumentu sinusoidy

            for (float x = -Szerokosc / 2; x < Szerokosc / 2; x += step)
            {
                float y = (float)(Wysokosc / 2 - Math.Sin(x / 50) * 100); // Wzór sinusoidy

                // Obliczenie odległości punktu od osi Y
                float distanceFromYAxis = Math.Abs(y - Wysokosc / 2);

                // Określenie koloru w zależności od odległości od osi Y
                Color pointColor = Color.FromArgb(255, (int)(255 * (distanceFromYAxis / 100)), 120, 0);

                Pen pen = new Pen(pointColor, 2); // Ustawienie koloru i grubości linii
                g.DrawRectangle(pen, Szerokosc / 2 + x, y, 1, 1); // Rysowanie punktu
                Console.WriteLine(distanceFromYAxis);
            }

        }
    }
}