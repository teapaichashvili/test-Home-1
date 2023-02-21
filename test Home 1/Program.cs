/* axali amocana
 */

class
    TeaPaichashvili
{
    static void Main(string[] args)

    {
        // Davaleba # 1
        Console.Write("sheiyvanot pirveli ricxvi (X):");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("sheiyvanot meore ricxvi (y):");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("sheiyvanot mesame ricxvi (z):");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Migebuli shedegi (x + z * y)= ");
        Console.WriteLine(x + z * y);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba # 2
        Console.Write("sheiyvanot tqveni saxeli");
        string saxeli = Console.ReadLine();
        Console.Write("sheiyvanot tqveni gvari");
        string gvari = Console.ReadLine();
        Console.Write("sheiyvanot tkveni asaki");
        int asaki = Int32.Parse(Console.ReadLine());
        Console.Write("sheiyvanot tkveni simaglen (m): ");
        float simagle = float.Parse(Console.ReadLine());
        Console.Write("sheiyvanot tkveni wona (kg): ");
        float wona = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Tqveni monacemebi: ");
        Console.WriteLine(saxeli + "" + gvari + "," + "" + asaki + "wlis" + "," + "" + simagle + "cm" + "," + "" + wona + "kg");
        Console.WriteLine();
        Console.WriteLine();

        //Davaleba # 3

        Console.Write("sheiyvanot tqveni wona (kg): ");
        float weight = float.Parse(Console.ReadLine());
        Console.Write("sheiyvanot tqveni simagle (m): ");
        float height = float.Parse(Console.ReadLine());
        float bmi = weight / (height * height);
        Console.WriteLine();
        Console.WriteLine("Tkveni BMI (kg/m2) aris: " + bmi);
        Console.WriteLine();
        Console.WriteLine();

        //Davaleba #4

        string vertical = "|";
        string horizontal = "- - -";
        Console.WriteLine();
        Console.WriteLine("" + "" + "" + vertical + "" + "" + "" + vertical);
        Console.WriteLine("" + "1" + "" + vertical + "" + "2" + "" + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine("" + "4" + "" + vertical + "" + "5" + "" + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine("" + "7" + "" + vertical + "" + "8" + "" + vertical + "9");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine("" + "" + "" + vertical + "" + "" + "" + vertical);
    }
}