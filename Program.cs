public class HelloWorld
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Geef een String om om te draaien");
        String input = Console.ReadLine();

        Console.WriteLine("Welke loop wil je gebruiken?\n" +
            "1: for-loop\n" +
            "2: while-loop\n" +
            "3: do-while-loop\n" +
            "4: recursie");

        int i;
        String output = "";

        string reverseString(string str)
        {
            if (str.Length < 1)
            {
                return output;
            }
            else
            {
                //voeg de laatste karakter toe aan de uitvoer string
                output += str[str.Length-1];
                //roep de functie opnieuw op met dezelfde string zonder de laatste karakter (recursie)
                return reverseString(str.Substring(0, str.Length - 1));
            }
        }

        switch(Console.ReadLine())
        {
            case "1":
                Console.WriteLine("option 1");

                for (i = input.Length-1; i >= 0; i--)
                {
                    output += input[i];
                }
                break;

            case "2":
                i = input.Length-1;
                Console.WriteLine("option 1");
                while(i >= 0)
                {
                    output += input[i];
                    i--;
                }
                break;

            case "3":
                i = input.Length - 1;
                Console.WriteLine("option 1");
                do
                {
                    output += input[i];
                    i--;
                } while (i >= 0);
                break;

            case "4":
                output = reverseString(input);
                break;

            default:
                Console.WriteLine("Optie niet herkend");
                break;
        }

        Console.WriteLine("Uitvoer:\n" + output);

    }

}