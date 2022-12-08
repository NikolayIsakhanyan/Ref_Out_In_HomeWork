using System.Diagnostics.CodeAnalysis;

public class Program
{
    private static void Main(string[] args)
    {

        //int c = 5;//Trberutyun method kancheluc petqa metodic durs arjeqavorvi
        //MyMethod(7, 6, ref c);
        //Console.WriteLine(c);
        //int n;//Chi pahanjum arjeqavorum ,vorovhetev partadira ira nersum arjeqavori
        //My2Method(5, out n);
        //Console.WriteLine(n);
        int a = 5;
        My3Method(a);

    }
    static void MyMethod(int a, int b, ref int c)
    {
        c = c + 1;
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