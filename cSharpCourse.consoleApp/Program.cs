using cSharpCourse.consoleApp.MathExpressionEvaluator;
namespace cSharpCourse.consoleApp
{
    internal class Program
    {
        private const float PI = 3.14f;
        private static readonly int _minutes;
        static Program()
        {
            _minutes = 60;
        }

        static void Main(string[] args)
        {
            // ASCII table
            /*for (char i = 'a', j = 'A', k = '0'; i <= 'z'; i++, j++, k++)
            {
                int x = i;
                int y = j;
                int z = k;
                Console.WriteLine($"{i} ==> {x}\t{j} ==> {y}\t{k} ==> {z}");
            }*/
            // calculate avearage, min and max of an array   --> method
            /*            Console.Write("Enter the size of the array: ");
                        int arrSize = int.Parse(Console.ReadLine());
                        int[] arr = new int[arrSize];
                        for (int i = 0; i < arrSize; i++)
                        {
                            Console.Write($"Enter element number #{i + 1}: ");
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("The Average = " + CalculateAverge(arr));
                        Console.WriteLine("The minimum vlue = " + FindMin(arr));
                        Console.WriteLine("The maximum vlue = " + FindMax(arr));*/
            // find if the input string is palindrome or not --> method
            /*            while (true)
                        {
                            Console.WriteLine("Enter a string");
                            string str = Console.ReadLine();
                            Console.WriteLine(IsBalindrome(str));
                        }
            */
            // String formatting
            /*int salary = 5000;
            string str = "Hello {0:0.0}";
            Console.WriteLine(str);
            str = string.Format(str, salary);
            Console.WriteLine(str);*/
            // String Builder
            /*            StringBuilder str = new();
                        str.Append("Hello World");
                        str.Append(" MY NAME IS ABDALLAH");
                        Console.WriteLine(str);
                        Console.WriteLine(str.Length);
                        Console.WriteLine(str.Capacity);*/
            // NameSpaces & Properties
            /*        var abdallah = new Student(1000206502) { Description = "Software Engineer" };
                    Console.WriteLine("Enter the student name: ");
                    abdallah.Name = Console.ReadLine();
                    Console.WriteLine(abdallah.Id);
                    Console.WriteLine(abdallah.Name);
                    Console.WriteLine(abdallah.Description);*/
            /*            Console.WriteLine($"{PI}\t {_minutes}");
                        bool isSuccesful = true;
                        Console.WriteLine(Divider(10, 0, ref isSuccesful) + "\nIs Succesful => " + isSuccesful);*/

            App.Run(args);
        }

        /*        /// <summary>
                /// Calculate the average of an array of integers
                /// </summary>
                /// <param name="arr">the array you want to calculate its average</param>
                /// <param name="calculateSum">if you want the method to returnte sum of the array only</param>
                /// <returns>the average if the calculateSum param false </returns>
                static double CalculateAverge(int[] arr, bool calculateSum = false)
                {
                    int sum = 0;
                    foreach (var item in arr)
                        sum += item;
                    if (calculateSum) return sum;
                    double average = sum / arr.Length;
                    return average;
                }
                /// <summary>
                /// Find the minimum value of an array
                /// </summary>
                /// <param name="arr">array of integers</param>
                /// <returns>minimum value</returns>
                static int FindMin(int[] arr)
                {
                    Array.Sort(arr);
                    int min = arr[0];
                    return min;
                }
                /// <summary>
                /// Find the maximum value of an array
                /// </summary>
                /// <param name="arr">array of integers</param>
                /// <returns>maximum value</returns>
                static int FindMax(int[] arr)
                {
                    Array.Sort(arr);
                    int max = arr[arr.Length - 1];
                    return max;
                }
                /// <summary>
                /// Find if the input string is balindrome or not
                /// </summary>
                /// <param name="str">string</param>
                /// <returns>True if the srting is balindrome and false if not</returns>
                static bool IsBalindrome(string str)
                {
                    bool isBalindrome = false;
                    for (int i = 0; i < str.Length / 2; i++)
                    {
                        if (str[i] != str[str.Length - i - 1])
                        {
                            isBalindrome = false;
                            break;
                        }
                        else isBalindrome = true;
                    }
                    return isBalindrome;
                }
                static double Divider(double number, double divisor, ref bool isSuccesful)
                {
                    if (divisor == 0)
                    {
                        Console.WriteLine("Can't divide on zero !");
                        isSuccesful = false;
                        return 0;
                    }
                    isSuccesful = true;
                    return number / divisor;
                }*/
    }
}