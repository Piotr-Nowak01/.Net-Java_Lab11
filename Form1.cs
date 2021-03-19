using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class Aplikacja : Form
    {
        public Aplikacja()
        {
            InitializeComponent();
        }
        struct przedmiot
        {
            public int waga;
            public int wartosc;
        };
        private void button1_Click(object sender, EventArgs e)
        {
               
            int n = 20, down = 1, up = 29;
            int max_pojemnosc = 200, curr_pojemnosc = 0;
            int wartosc = 0, iter = 0;
            przedmiot[] itemy = new przedmiot[n];
            RandomNumberGenerator nazwa = new RandomNumberGenerator(2137);
            for (int i = 0; i < n; i++)
            {
                itemy[i].waga = nazwa.nextInt(down, up);
                itemy[i].wartosc = nazwa.nextInt(down, up);
            }
            while (curr_pojemnosc + itemy[iter].waga < max_pojemnosc)
            {
                curr_pojemnosc += itemy[iter].waga;
                wartosc += itemy[iter].wartosc;
                iter++;
            }
            string text = "Wartosc itemow: ";
            text += wartosc.ToString() + "\n";
            text += " Zajeta pojemnosc: ";
            text += curr_pojemnosc.ToString() + "\n";
            textBox1.Text = text;
        }
    }
}
