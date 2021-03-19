using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class Program
    {
        struct przedmiot
        {
            public int waga;
            public int wartosc;
        }
        static void Main(string[] args)
        {
            int n = 20, down = 1, up = 29;
            int max_pojemnosc = 200, curr_pojemnosc = 0;
            int wartosc = 0, iter = 0;
            przedmiot[] itemy = new przedmiot[n]; 
            RandomNumberGenerator nazwa = new RandomNumberGenerator(2137);
            for(int i=0; i<n;i++)
            {
                itemy[i].waga = nazwa.nextInt(down,up);
                itemy[i].wartosc = nazwa.nextInt(down,up);
            }
            while(curr_pojemnosc + itemy[iter].waga < max_pojemnosc)
            {
                curr_pojemnosc += itemy[iter].waga;
                wartosc += itemy[iter].wartosc;
                iter++;
            }
            Console.WriteLine("Wartość itemów = {0}. Obecna waga = {1}", wartosc, curr_pojemnosc);
        }
    }
}