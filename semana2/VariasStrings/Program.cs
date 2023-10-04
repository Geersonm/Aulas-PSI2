using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
            char c = 'a';

            double dd = 0.12345;
            int ii = 18;

            string s = "uma string";
            string m = """uma string entre aspas""";
            string p = @"\uma string sem aspas";
            string n = "\u00A9 e \u2665";
            string c = @"\u00A9 e \u2665 sem UTF";

            string cs = "string" + "conectada" + 2;
            string cr = s + m + x;

            string si = $"{s}interpolada";

            string j = "a" + 2;
            string d = "b" + x;

            string s = String.Format(“Arg { 0}
            e { 1}”, x, y);
            string s = String.Format(“Arg { 1}
            e { 0}”, 5, 10);
            string s = String.Format(“Olá { 0}, No. { 1}”, “mundo”, 3);


            Console.WriteLine(s);
            Console.WriteLine(m);
            Console.WriteLine(p);
            Console.WriteLine(n);
                                                                 Console.WriteLine(c);

            Console.WriteLine(cs);


            Console.WriteLine(“Valor de x é { 0}”, x);

            Console.WriteLine($"(dd:f2)");
            Console.WriteLine($"(dd:p1)");
            Console.WriteLine($"(ii:x)");
            Console.WriteLine($"(ii:c)");



        }
    }
}
