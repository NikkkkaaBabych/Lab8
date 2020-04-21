using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_1
{

    class transport
    {
        protected double prybutoc;
        protected double vytraty;
        public virtual void chyst_prybutoc()
        {
            double chyst_prybutoc = prybutoc - vytraty;
            Console.WriteLine("prybutoc {0}", chyst_prybutoc);
        }
        public void input()
        {
            Console.WriteLine("prybutoc");
            prybutoc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vytraty");
            vytraty = Convert.ToDouble(Console.ReadLine());
        }
    }
    class vantash : transport
    {
        string vyd_vantash;
        double massa;
        public void Input()
        {
            base.input();
            Console.WriteLine("vyd_vantash");
            vyd_vantash = Console.ReadLine();
            Console.WriteLine("massa");
            massa = Convert.ToDouble(Console.ReadLine());
        }
    }
    class pasash : transport
    {
        string pryznach;
        int kilkist_misc;
        public override void chyst_prybutoc()
        {
            base.chyst_prybutoc();
            Console.WriteLine("vartist dla 1 pasazshiru = {0}", prybutoc / kilkist_misc);
        }
        public void Input()
        {
            base.input();
            Console.WriteLine("pryznach");
            pryznach = Console.ReadLine();
            Console.WriteLine("kilkist_misc");
            kilkist_misc = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pasash P = new pasash();
            P.Input();
            P.chyst_prybutoc();
            vantash V = new vantash();
            V.Input();
            V.chyst_prybutoc();
            Console.ReadKey();
        }
    }
}
