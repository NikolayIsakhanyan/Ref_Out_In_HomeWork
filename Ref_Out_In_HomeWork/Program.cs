using Ref_Out_In_HomeWork;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    private static void Main(string[] args)
    {

        try
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());

            int c = a / b;
            Console.WriteLine(c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Data);

        }
        finally
        {
            Console.WriteLine("Errora normal gres kashxati");
        }

    }

    static void My2Method(int d, out int n)
    {
        n = 5;
        n = n + 1;
    }
    static void My3Method(in int sum)
    {
        //int sum = 5;//Chi toghi, drancic tarbervuma vor drsic metodoin trvacy mnuma hastatun 
        Console.WriteLine(sum);
    }
}














//int c = 5;//Trberutyun method kancheluc petqa metodic durs arjeqavorvi
//MyMethod(7, 6, ref c);
//Console.WriteLine(c);
//int n;//Chi pahanjum arjeqavorum ,vorovhetev partadira ira nersum arjeqavori
//My2Method(5, out n);
//Console.WriteLine(n);
// int a = 5;
//My3Method(a);//Methody kancheluc partadir chi in grl vonc grum eyn refum u out um
//Konstructor1 Esa = new Konstructor1(5, 8);