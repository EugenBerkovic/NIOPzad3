/*using System;

class Program
{
    static void Main()
    {
      
        int a = 100;
        int b = 3;

     
        int x = a / b;
        int y = a % b;

       
        Console.WriteLine($"{a} dijeljeno s {b} je {x} i ostatak {y}");
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        
        int a = 10, b = 7;
        double c = 12.5, d = 16.7;

       
        double prosjek = (a + b + c + d) / 4.0;

        Console.WriteLine("Prosječna vrijednost je: " + prosjek);
    }
}*/

using System;

class Program
{
    static void Main()
    {
        int x, y, z;

       
        x = int.Parse(Console.ReadLine());

       
        y = int.Parse(Console.ReadLine());

      
        z = int.Parse(Console.ReadLine());

       
        if (x <= 0 || y <= 0 || z <= 0)
        {
            Console.WriteLine("Greška! Sve stranice moraju biti veće od 0.");
        }
       
        else if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
        {
            Console.WriteLine("Unesene vrijednosti jesu stranice pravokutnog trokuta.");
        }
        else
        {
            Console.WriteLine("Unesene vrijednosti nisu stranice pravokutnog trokuta.");
        }
    }
}
