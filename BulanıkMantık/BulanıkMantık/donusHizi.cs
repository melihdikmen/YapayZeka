using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulanıkMantık
{
    class donusHizi
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

                if (key == "hassas")
                {

                    pay += bulanikKume[key][0] * 0.514;

                }

                if (key == "normal_hassas")
                {
                    pay += bulanikKume[key][0] * 2.75;
                }

                if (key == "orta")
                {
                    pay += bulanikKume[key][0] * 5;
                }


                if (key == "normal_güçlü")
                {
                    pay += bulanikKume[key][0] * 7.25;
                }


                if (key == "güçlü")
                {
                    pay += bulanikKume[key][0] * 9.5;
                }

                payda += bulanikKume[key][0];

            }



            double sonuc = pay / payda;

            return sonuc;

        }





    }
}
