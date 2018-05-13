using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulanıkMantık
{
    class Sure
    {

        Dictionary<string, List<double>> bulanikKume = new Dictionary<string, List<double>>();

        double pay, payda;



        public void bulanikKumeAl(string kume, double mindeger)
        {
            if (bulanikKume.ContainsKey(kume))
            {
                bulanikKume[kume].Add(mindeger);
            }


            else
            {
                bulanikKume.Add(kume, new List<double>());
                bulanikKume[kume].Add(mindeger);
            }

        }



        public double Hesapla()
        {
            foreach (var key in bulanikKume.Keys)
            {
                bulanikKume[key].Sort();
                bulanikKume[key].Reverse();

                if (key == "kısa")
                {

                    pay += bulanikKume[key][0] * 22.3;

                }

                if (key == "normal_kısa")
                {
                    pay += bulanikKume[key][0] * 39.9;
                }

                if (key == "orta")
                {
                    pay += bulanikKume[key][0] * 57.5;
                }


                if (key == "normal_uzun")
                {
                    pay += bulanikKume[key][0] * 75.1;
                }


                if (key == "uzun")
                {
                    pay += bulanikKume[key][0] * 92.7;
                }

                payda += bulanikKume[key][0];

            }



            double sonuc = pay / payda;

            return sonuc;

        }
    }
}
