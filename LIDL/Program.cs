using LIDL;
using OO_Samples_008_Lidl_01;
using OO_Samples_008_Lidl_03;

namespace OO_Sample_008_Lidl_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person1 = new Person("Hans", "Meier");
            Kunde kunde1 = new Kunde("Fritz", "Mueller", 100, "KEY100", 1000.0 );
            Lagerist lagerist1 = new Lagerist("Joe", "Manser", 101, "KEY101", 180);
            Kleinkind kleinkind1 = new Kleinkind("Kiddy", "Kid", 102, "KEY102", 3 );
            ChatBot chatbot1 = new ChatBot();

            // person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kleinkind1.Esse();
            kleinkind1.Trage();


            Console.WriteLine(kunde1.Umsatz);   //ist public
            // Console.WriteLine(kunde1.IdentNr);  //ist protected
            // Console.WriteLine(kunde1.Key);      //ist private
        }
    }
}