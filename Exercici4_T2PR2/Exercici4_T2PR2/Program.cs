using System;

class Program
{
    static void Main(string[] args)
    {
        const string MsgWidth = "Introdueix l'amplada del rectangle:";
        const string MsgHeight = "Introdueix l'altura del rectangle:";
        const string MsgAreaRect = "L'àrea del rectangle és: ";
        const string MsgRadius = "Introdueix el radi del cercle:";
        const string MsgCircum = "La circumferència del cercle és: ";
        const string MsgBiggerArea = "L'àrea és més gran de ";
        const string MsgAreaBetweenOne = "L'àrea està entre els valors ";
        const string MsgAreaBetweenTwo = "i ";
        const string MsgLittleArea = "L'àrea és menor o igual a ";
        const int ValueOneArea = 50;
        const int ValueTwoArea = 20;

        double width = 0;
        double height = 0;
        double area;
        double radius = 0;
        double circumference;

        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine(MsgWidth);
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MsgHeight);
        height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        area = width * height;
        Console.WriteLine($"{MsgAreaRect}{area}");

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine(MsgRadius);
        radius = Convert.ToDouble(Console.ReadLine());
        circumference = 2 * Math.PI * radius;
        Console.WriteLine($"{MsgCircum}{circumference}");

        // Imprimeix un missatge basat en el valor de l'àrea
        if (area > ValueOneArea)
        {
            Console.WriteLine($"{MsgBiggerArea}{ValueOneArea}");
        }
        else if (area > ValueTwoArea)
        {
            Console.WriteLine($"{MsgAreaBetweenOne}{ValueTwoArea}{MsgAreaBetweenTwo}{ValueOneArea}");
        }
        else
        {
            Console.WriteLine($"{MsgLittleArea}{ValueTwoArea}");
        }
    }
}