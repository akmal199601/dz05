using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
               Converter money = new Converter();
             money.Валюта( );
          
            Employee emplo = new Employee(); 
          
             emplo.infoAboutEmployee("Воздухан","Пайрав","Типа Программист","5 лет",3000,0.14);

             emplo.infoAboutEmployee("Азизов","Акмал","Программист","4 Года",10000,0.14);
             emplo.infoAboutEmployee("Хуршед","Эгамов","Программист","12 лет",15000,0.14);


            

           Console.ReadKey();

        }
    }
      //Задача №1
    class Converter 
    { 
        
        public double somon {get;set;}
        public double usd  {get;set;}
        public double eur {get;set;}
        public double rub {get;set;}

        public void Валюта ()
        {
            
           System.Console.WriteLine("Введите сумму");
           double sum = double.Parse(Console.ReadLine());
           System.Console.WriteLine("Нажмите 1 для конвертации от usd к som ");
             System.Console.WriteLine("Нажмите 2 для конвертации от som к usd");
              System.Console.WriteLine("Нажмите 3 для конвертации от eur к som ");
              System.Console.WriteLine("Нажмите 4 для конвертации от som к eur ");
              System.Console.WriteLine("Нажмите 5 для конвертации от rub к som");
              System.Console.WriteLine("Нажмите 6 для конвертации от som к rub");
        
            string валюта = Console.ReadLine();
            switch(валюта)
            {
                case "1":
                {
                  System.Console.WriteLine("usd к som = " + Math.Round( sum*10.22,2 ) + "som");

                }break;
                case "2":
                {
                  System.Console.WriteLine("som к usd = " + Math.Round (sum/10.22,2) + " usd");
                  
                }break;
                case "3":
                {
                  System.Console.WriteLine("eur к som = " + Math.Round(sum*11.04,2) +  " som");

                }break;
                case "4":
                {
                  System.Console.WriteLine("som к eur = " + Math.Round(sum/11.04,2) + " eur");
                  
                }break;case "5":
                {
                  System.Console.WriteLine("rub к som = " + Math.Round(sum*0.13,2) + " som");

                }break;
                case "6":
                {
                  System.Console.WriteLine("som к rub = " + Math.Round(sum/0.13,2) + " rub");
                  
                }break;
        
            }
           System.Console.WriteLine("---------------------");

        }

    }               
          
        }
    
