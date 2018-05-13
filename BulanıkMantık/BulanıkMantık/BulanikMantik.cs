using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulanıkMantık
{
    class BulanikMantik
    {
        Hassaslık hassaslık;
        Miktar miktar;
        Kirlilik kirlilik;
        donusHizi donus;
        Sure sure;
        Deterjan det;


        public BulanikMantik(double hassaslık,double miktar,double kirlilik)
        {
            this.hassaslık = new Hassaslık(hassaslık);
            this.miktar = new Miktar(miktar);
           this.kirlilik = new Kirlilik(kirlilik);
        }


      
        public void kurallar()
        {
            donus = new donusHizi();
            sure = new Sure();
            det = new Deterjan();

            List<double> uyelikDerece=new List<double>();

            //1
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("kısa", uyelikDerece[0]);
                det.bulanikKumeAl("çok_az", uyelikDerece[0]);             
               
            }


            //2
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("kısa", uyelikDerece[0]);
                det.bulanikKumeAl("az", uyelikDerece[0]);

            }

            //3
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }


            //4
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }


            //5
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }


            //6
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }


            //7
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }



            //8
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }




            //9
            if (hassaslık.bulanikKume.ContainsKey("hassas") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["hassas"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }


            //10
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_kısa", uyelikDerece[0]);
                det.bulanikKumeAl("az", uyelikDerece[0]);

            }



            //11
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }


            //12
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }



            //13
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_kısa", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }




            //14
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }



            //15
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }



            //16
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }



            //17
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }


            //18
            if (hassaslık.bulanikKume.ContainsKey("orta") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["orta"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("hassas", uyelikDerece[0]);
                sure.bulanikKumeAl("uzun", uyelikDerece[0]);
                det.bulanikKumeAl("çok_fazla", uyelikDerece[0]);

            }


            
            
            //19
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("az", uyelikDerece[0]);

            }


            //20
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }


            
            //21
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("küçük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["küçük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }



            //22
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("orta", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }




            //23
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_uzun", uyelikDerece[0]);
                det.bulanikKumeAl("orta", uyelikDerece[0]);

            }




            //24
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("orta") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["orta"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("orta", uyelikDerece[0]);
                det.bulanikKumeAl("çok_fazla", uyelikDerece[0]);

            }




            //25
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("küçük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["küçük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("normal_uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }




            //26
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("orta"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["orta"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("normal_güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("uzun", uyelikDerece[0]);
                det.bulanikKumeAl("fazla", uyelikDerece[0]);

            }



            //27
            if (hassaslık.bulanikKume.ContainsKey("sağlam") && miktar.bulanikKume.ContainsKey("büyük") && kirlilik.bulanikKume.ContainsKey("büyük"))
            {
                uyelikDerece.Clear();
                uyelikDerece.Add(hassaslık.bulanikKume["sağlam"]);
                uyelikDerece.Add(miktar.bulanikKume["büyük"]);
                uyelikDerece.Add(kirlilik.bulanikKume["büyük"]);
                uyelikDerece.Sort();
                donus.bulanikKumeAl("güçlü", uyelikDerece[0]);
                sure.bulanikKumeAl("uzun", uyelikDerece[0]);
                det.bulanikKumeAl("çok_fazla", uyelikDerece[0]);

            }


        }






        public List<double> Hesapla()
        {
            List<double> sonuc = new List<double>();
           
            sonuc.Add(donus.Hesapla());
            sonuc.Add(sure.Hesapla());
            sonuc.Add( det.Hesapla());

           return sonuc;

        }


    }
}
