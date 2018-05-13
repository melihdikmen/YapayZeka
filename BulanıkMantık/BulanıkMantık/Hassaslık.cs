using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulanıkMantık
{
    class Hassaslık
    {
         double deger;

         public Hassaslık(double deger)
         {
             this.deger = deger;
             durumBelirle();
         }



        public Dictionary<string, double> bulanikKume = new Dictionary<string, double>();

        
        
        public void durumBelirle()
        {
            if (deger >= 0 && deger <= 4)
            {
                
                bulanikKume.Add("sağlam",uyelikDerecesi("sağlam"));
            }

             if (deger >= 3 && deger <= 7)
            {
                bulanikKume.Add("orta",uyelikDerecesi("orta"));
            }

            if (deger >= 5.5 && deger <= 10)
            {
                bulanikKume.Add("hassas",uyelikDerecesi("hassas"));
            }
        }






        public double uyelikDerecesi(String bulanikKume)
        {
            double sonuc = 0;

            if (bulanikKume == "sağlam")
            {
                if (deger >= 0 && deger <= 2)
                {
                    sonuc = 1;
                }

                else if (deger > 2 && deger <= 4)
                {
                    sonuc = Math.Abs((deger / 2 )- 2);
                }
            }


            if (bulanikKume == "orta")
            {
                if (deger >= 3 && deger < 5)
                {
                    sonuc =deger / 2.0 - 3.0 / 2.0;
                }

                else if (deger >5 && deger <= 7)
                {
                    sonuc = Math.Abs((deger / 2.0) - (7.0/ 2.0));
                }

                else if (deger == 5)
                {
                    sonuc = 1;
                }
            }


            if (bulanikKume == "hassas")
            {
                if (deger >= 5.5&& deger < 8)
                {
                    sonuc = (0.4 * deger) - 2.2;
                }

                else if (deger >=8 && deger <= 10)
                {
                    sonuc=1;
                }
            }



            return sonuc;
        }




    }
}
