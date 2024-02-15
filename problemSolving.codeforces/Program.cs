
using System.Text;

namespace problemSolving.codeforces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("[1] to generate a random number\t\t[2] to generate a random string\t\t[0] to EXIT");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("Enter the minimum: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.Write("Enter the maximum: ");
                    int max = int.Parse(Console.ReadLine());
                    GenerateRandomNumber(min, max);
                }
                else if (option == "2")
                {
                    Console.Write("Enter the length of the string you want: ");
                    int length = int.Parse(Console.ReadLine());
                    bool wantCaps = true;
                    bool wantNums = true;
                    bool wantSymbols = true;
                    GenerateRandomString(length, wantCaps, wantNums, wantSymbols);
                }
                else if (option == "0")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option ! Try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("=================================");
            }
        }
        private static void GenerateRandomString(int length, bool caps, bool nums, bool symbols)
        {
            const string capsBuffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowsBuffer = "abcdefghijklmnopqrstuvwxyz";
            const string numsBuffer = "0123456789";
            const string symbolsBuffer = "!@#$%^&*";
            StringBuilder sb = new();
            var rnd = new Random();
            while (sb.Length <= length)
            {
                sb.Append(lowsBuffer[rnd.Next(0, lowsBuffer.Length)]);
                if (sb.Length == length) break;
                if (caps == true)
                    sb.Append(capsBuffer[rnd.Next(0, lowsBuffer.Length)]);
                if (sb.Length == length) break;
                if (nums == true)
                    sb.Append(numsBuffer[rnd.Next(0, numsBuffer.Length)]);
                if (sb.Length == length) break;
                if (symbols == true)
                    sb.Append(symbolsBuffer[rnd.Next(0, symbolsBuffer.Length)]);
                if (sb.Length == length) break;
            }
            Console.WriteLine(sb);
        }

        private static void GenerateRandomNumber(int min, int max)
        {
            var rnd = new Random();
            int num = rnd.Next(min, max);
            Console.WriteLine(num);
        }
    }
}


