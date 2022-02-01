using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2_metody_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JePrvocislo(int cislo, bool pravda)
        {
            double cislo2 = cislo / 2;
            bool kontrola = true;

            for (int i = 2; i <= cislo2; i++)
            {
                if (cislo % i == 0)
                {
                    pravda = false;
                    kontrola = false;
                }
            }

            if (kontrola == true)
            {
                pravda = true;
            }

            return pravda;
        }

        private void Prepis(int N)
        {
            Random rnd = new Random();
            int[] pole = new int[N];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(2, 16);

                cisla.AppendText(Convert.ToString(pole[i]));
                cisla.AppendText(Environment.NewLine);

                bool pravda = false;
                pravda = JePrvocislo(pole[i], pravda);

                if (pravda == true)
                {
                    prvocisla.Items.Add(pole[i]);
                    pravda = false;
                }
            }
        }

        private void generovat_Click(object sender, EventArgs e)
        {
            cisla.Clear();
            prvocisla.Items.Clear();

            int N = Convert.ToInt32(vstup_N.Text);
            
            Prepis(N);
        }
    }
}
