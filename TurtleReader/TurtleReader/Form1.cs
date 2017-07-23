using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;
using System.IO;
using System.Timers;
using System.Threading;
using System.Diagnostics;

namespace TurtleReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void TurtleButton_Click(object sender, EventArgs e)
        {
            string[] Moves = File.ReadAllLines("Moves.txt");
            for (int i = 0; i < Moves.Length; i++)
            {
                switch (Moves[i])
                {
                    case "Up":
                        Turtle.RotateTo(0);
                        Turtle.Forward(25);
                        break;
                    case "Down":
                        Turtle.RotateTo(180);
                        Turtle.Forward(25);
                        break;
                    case "Left":
                        Turtle.RotateTo(-90);
                        Turtle.Forward(25);
                        break;
                    case "Right":
                        Turtle.RotateTo(90);
                        Turtle.Forward(25);
                        break;
                }
                await Task.Delay(500);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Moves.txt");
        }
    }
}
