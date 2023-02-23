/* axali amocana
 */

class
    TeaPaichashvili
{
    static void Main(string[] args)

    {
        // Homework # 1
        Console.Write("x");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("y");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("z");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Sum (x + z * y)= ");
        Console.WriteLine(x + z * y);
        Console.WriteLine();
        Console.WriteLine();


        //Homework # 2
        Console.Write("name");
        string name = Console.ReadLine();
        Console.Write("last name");
        string lastName = Console.ReadLine();
        Console.Write("Age");
        int Age= Int32.Parse(Console.ReadLine());
        Console.Write("height ");
        float Height = float.Parse(Console.ReadLine());
        Console.Write("weight");
        int weight= int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(name + " " + lastName);
        Console.WriteLine("Your age is: " + Age);
        Console.WriteLine("Your height is: " + Height);
        Console.WriteLine("Your weight is: " + weight);



        //Homework # 3



        Console.WriteLine("Please Enter your height in CM : ");
        float height1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter your weight in KG: ");
        float weight1 = float.Parse(Console.ReadLine());

        float Bmi = weight1 / ((height1 / 100) * (height1 / 100));
        Console.WriteLine("Your Bmi is equel " + Bmi);



        //Homework #4

        

        string vertical = "|";
        string horizontal = "_";
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("1" + vertical + "2" + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("4" + vertical + "5" + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("7" + vertical + "8" + vertical + "9");
    }
}