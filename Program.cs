// See https://aka.ms/new-console-template for more information
using System.Globalization;

Hi:
System.Console.WriteLine("Menyu -------------------------\nAsosiy        |        Chizish");
string menyu = Console.ReadLine();

if(menyu == "1"){
    System.Console.WriteLine("Sizga nimani topish kerak?\n-------------------------------------\n");
    System.Console.WriteLine("Kupning hajmini   |   Turtburchakning P   |   ........");
    string yunalish = Console.ReadLine();

    if(yunalish == "1"){
        System.Console.WriteLine("Kupning tomonlarini kiriting\n");
        System.Console.Write("A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("C: ");
        int c = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"Kupingizning hajmi: {a * b * c}");
    }
    else if(yunalish == "2"){
        System.Console.WriteLine("Turtburchak tomonlarini kiriting\n");
        System.Console.Write("A: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Turtburchakingizning Perimetri: {(a1 + b1)* 2}");
    }
}

{
    if(menyu == "2"){
    System.Console.WriteLine("Sizga nimani topish kerak?\n-------------------------------------\n");
    System.Console.WriteLine("uchburchak  |   Turtburchak  |   ........");
    string yunalish2 = Console.ReadLine();
    

     if(yunalish2 == "1"){
     
         Console.WriteLine("       *\n     *  *\n    *    *\n   *      *\n  *        *\n *          *\n**************");
     }
     else if(yunalish2 =="2"){
      System.Console.WriteLine("********\n*      *\n*      *\n*      *\n*      *\n********");  
     }
     }

}

System.Console.WriteLine("davom ettirishni hohlasangiz ha tuxtatmoqchi bulasangiz yuq deb yozing");
string d = Console.ReadLine();
if(d == "ha"){
    goto Hi;
}
else{
System.Console.WriteLine("Ish TUXTATILDI :)");
}
