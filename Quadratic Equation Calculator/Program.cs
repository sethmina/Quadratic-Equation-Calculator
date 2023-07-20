using System.Numerics;

bool newEquation = true;

while (newEquation)
{
    Console.WriteLine("ax\xb2 + bx + c = 0");
    Console.WriteLine("Compare your quadratic equation to above quadratic equation and enter the values of 'a', 'b' and 'c'");

    Console.Write("a: ");
    Complex a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b: ");
    Complex b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c: ");
    Complex c = Convert.ToDouble(Console.ReadLine());


    Complex anwser1 = (-b + System.Numerics.Complex.Sqrt(System.Numerics.Complex.Pow(b , 2) - 4.0 * a * c)) / (2.0 * a);
    Complex anwser2 = (-b - System.Numerics.Complex.Sqrt(System.Numerics.Complex.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a);


    Console.WriteLine($"{a.Real}x\xb2 + {b.Real}x + {c.Real}");
    Console.WriteLine($"x = {anwser1.Real + anwser1.Imaginary} or x = {anwser2.Real + anwser2.Imaginary}");

    Console.WriteLine("Do you have another quadratic equation to slove(y/n)?: ");
    string yesOrNo = Console.ReadLine().ToUpper();

    if (yesOrNo == "Y")
    {
        newEquation = true;
    }
    else
    {
        newEquation = false;
        Console.WriteLine("Thank you!");
    }

}
