using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Test_20211109
{
    class Banka
    {
        public string Jmeno;
        public int LimitVklad;
        public int LimitPlatba;
        public int Stav = 0;

        public Banka(string jmeno, int limit_vklad, int limit_platba)
        {
            this.Jmeno = jmeno;
            this.LimitVklad = limit_vklad;
            this.LimitPlatba = limit_platba;
        }

       public void Vklad(int castka)
        {
            if(castka > LimitVklad)
            {
                MessageBox.Show(" Tolik nemůžeš vložit.");
            }
            else if (castka < LimitVklad)
            {
                Stav += castka;
                MessageBox.Show($"Vložil jsi {castka}");
            }
        }
        public void Vyber(int castka)
        {
            if (castka > Stav)
            {
                MessageBox.Show(" Tolik peněz nemůžeš vybrat.");
            }
            else if (castka < LimitVklad)
            {
                Stav += castka;
                MessageBox.Show($"Vybral jsi {castka}");
            }
        }

        public void Platba(int castka)
        {
            if (castka >= LimitPlatba && castka == 0)
            {
                MessageBox.Show($" Tvoje platba přesahuje maximální limit {LimitPlatba}.");
            }
        }
    }
}
