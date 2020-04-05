using System;

namespace tj
{
    class Program
    {
        static void Main()
        {
          Console.WriteLine("Если хотите поменять Сомони на ДОЛАР или на ЕВРО или на РУБЛЬ  намите 1:");
          Console.WriteLine("Если хотите поменять ДОЛАР или на ЕВРО или на РУБЛЬ на СОМОНИ намите 2:");
          int n1=Int32.Parse(Console.ReadLine());
          if(n1==1)
          {
          Converter Kurs=new Converter(10.2183,11.0174,0.1316);
          Console.WriteLine($"Если хотите обменять СОМОНИ на ДОЛАР нажмите на 1: ");
          Console.WriteLine($"Если хотите обменять СОМОНИ на ЕВРО нажмите на 2: ");
          Console.WriteLine($"Если хотите обменять СОМОНИ на РУБЛЬ нажмите на 3: ");
          int n=Int32.Parse(Console.ReadLine());
          Console.WriteLine("Введите сумму которую хотите поменять");
          double S=Int32.Parse(Console.ReadLine());
          switch(n)
          {
              case 1:
              Kurs.obmendollar(S);
              break;
              case 2:
              Kurs.obmendevro(S);
              break;
              case 3:
              Kurs.obmenrub(S);
              break;

               
               
              
          }
          }
          
        }
    }
    class Converter
    {
     public double usd{set;get;}
     public double eur{set;get;}
     public double rub{set;get;}
     public Converter(double usd, double eur, double rub)
     {
       this.usd=usd;
       this.eur=eur;
       this.rub=rub;
     }
     public void obmendollar(double m)
     {
        double S1=m/this.usd;
        Console.WriteLine($"Ваша сумма относительно сегоднячного курса ДОЛАРА будеть {S1}$");
     }
    public void obmendevro(double m)
     {
        double S1=m/this.eur;
        Console.WriteLine($"Ваша сумма относительно сегоднячного курса ЕВРО будеть {S1} евро");
     }
      public void obmenrub(double m)
     {
        double S1=m/this.rub;
        Console.WriteLine($"Ваша сумма относительно сегоднячного курса долара будеть {S1} рубль");
     }

    }
}
