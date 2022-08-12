using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksSheds
{
    public class Sheds
    {
        public int nSheds, stacks;
        public Sheds(int n, int s)
        {
            nSheds = n;
            stacks = s;
        }

        public void needs (int ducks)
        {
            int sheds = 0;
            bool completed = false;
            while (!completed)
            {
                sheds++;
                if (ducks <= 30)
                {
                    completed = true;
                    lastStacks(ducks);
                }
                ducks = ducks - 30;
            }
            this.nSheds = sheds;
        }

        public void lastStacks (int ducks)
        {
            if (ducks <= 12)
            {
                this.stacks = 1;
            } else if (ducks > 12 && ducks <= 22)
            {
                this.stacks = 2;
            } else if (ducks > 22 && ducks <=30)
            {
                this.stacks = 3;
            }
        }

        public int getSheds()
        {
            return this.nSheds;
        }
        public int getStacks()
        {
            return this.stacks;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int ducks = 0;
            string val;
            Sheds sheds = new Sheds(0, 0);
            Console.WriteLine("Jumlah Bebek: ");
            val = Console.ReadLine();
            ducks = Convert.ToInt32(val);
            if (ducks <= 0)
            {
                Console.WriteLine("Invalid");
            } else
            {
                sheds.needs(ducks);
                Console.WriteLine("Jumlah kandang yang diperlukan: " + sheds.getSheds());
                Console.WriteLine("Jumlah susun pada kandang terakhir: " + sheds.getStacks());
            }
            Console.ReadLine();
        }
    }
}
