internal class Program
{
    private static void Main(string[] args)
    {
        ///////////////////////////////////////////////////////////
        //Console.Write("X= ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Y= ");
        //int y = Convert.ToInt32(Console.ReadLine());
        //int z = x + y;
        //Console.WriteLine("Sum= "+ z);
        ////////////////////////////////////////////////////////////

        //byte b = 25;
        //byte bb = 100;
        //byte bbb = Convert.ToByte(b + bb);
        //sbyte bs = Convert.ToSByte(b + bb);
        //Console.WriteLine("Byte= " + bbb);
        ////byte b4 = b + bb; Why is error here????????????

        //uint i1 = 2147483600u;
        //uint i2 = 3154565651u;
        //uint i3 = i1 + i2;
        //var x = i1 + i2;
        //Console.WriteLine("Uint= " + i3); // Uint = 1007081955
        //Console.WriteLine(i3);
        //// Uint = 1007081955 խի եմ սենց թիվ ստանում՞՞՞՞՞

        //char ch1 = 'a'; // 97
        //char ch2 = 'b'; // 98
        //char ch3 = 'c'; // 99
        //Console.WriteLine(ch1 + ch2 + ch3); // 294

        //Console.WriteLine(ch2); // b
        //Console.WriteLine(ch3); // c

        //decimal d1 = 12000000000000000000;
        //decimal d2 = 2300000000000000000;
        //decimal d3 = d1 + d2;
        //Console.WriteLine(d3);

        //float f1 = 4.5f;
        //double dd2 = 4.5d;
        //decimal dm3 = 4.5m;

        //Console.WriteLine(dd2);

        byte a = 13;
        byte b = 25;
        int aa1 = a & b;
        int aa2 = a | b;
        int aa3 = a ^ b;
        int aa4 = a >> 3;
        int aa5 = a << 3;
        Console.WriteLine(aa1); // 9
        Console.WriteLine(aa2); // 29
        Console.WriteLine(aa3); // 20
        Console.WriteLine(aa4); // 20
        Console.WriteLine(aa5); // 20

        bool bool1 = true;
        bool bool2 = false;
        bool bool3 = bool1 & bool2;
        bool bool4 = bool1 | bool2;
        bool bool5 = bool1 ^ bool2;
        Console.WriteLine(bool3); // false
        Console.WriteLine(bool4); // true
        Console.WriteLine(bool5); // true ??????
        Console.ReadKey();
    }
}