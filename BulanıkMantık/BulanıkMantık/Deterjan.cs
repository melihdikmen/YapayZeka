using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulanıkMantık
{
    class Deterjan
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

                if (key == "çok_az")
                {

                    pay += bulanikKume[key][0] * 20;

                }

                if (key == "az")
                {
                    pay += bulanikKume[key][0] * 85;
                }

                if (key == "orta")
                {
                    pay += bulanikKume[key][0] * 150;
                }


                if (key == "fazla")
                {
                    pay += bulanikKume[key][0] * 215;
                }


                if (key == "çok_fazla")
                {
                    pay += bulanikKume[key][0] * 280;
                }

                payda += bulanikKume[key][0];

            }



            double sonuc = pay / payda;

            return sonuc;

        }
    }
}
