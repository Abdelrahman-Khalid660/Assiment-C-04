namespace AssignmentC_04
{
    internal class Program
    {

        // 1) / 2)

        /*

    1) By Value: A copy of the variable's value is passed to the method
     Changes within the method do not affect the original variable

    2) By Reference : The memory address of the variable is passed 
     Changes within the method do affect the original variable 

        */

        public static void PassByValue(int num)
        {
            num = num * 2;
            Console.WriteLine("Inside PassByValue: num = " + num);
        }

        public static void PassByReference(ref int num)
        {
            num = num * 2;
            Console.WriteLine("Inside PassByReference: num = " + num);
        }


        // 3)

        public class Calculator
        {
            public static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
            {
                int sum = num1 + num2 + num3 + num4;
                int difference = num1 - num2 - num3 - num4;

                return (sum, difference);
            }









            // 4)
            static int SumDigits(int num)
        {
            int result = 0;  
            while(num > 0)    
            {
                result += num % 10;
                num /= 10;
            }
            return result;

        }
        // 5)
        static bool isPrime(int n)    
        {
            if(n<=1) return false;  
           

            for(int i = 2; i * i <= n;i++)  
            {
                if (n % i == 0) return false;
            }
            return true;

        }

        // 6)
        static int[] MinMax(int[]arr)
        {
            
            int min = arr[0];
            int max = arr[0];
      
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int[] result = { min,max};
            return result;

        }
        // 7)
        static int Factorial (int n)
        {
            int result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return (result);
        }

        // 8)
        static string ChangeChar(string str, int pos, char newChar)
        {
            if(pos< 0 || pos > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos),"position is out of range");
            }

            char[] chars = str.ToCharArray();
            chars[pos] = newChar;
            return new string(chars);
        }
        static void Main(string[] args)
        {

            // 1) / 2)

            int number = 5;

            Console.WriteLine("Before PassByValue: number = " + number);
            PassByValue(number);
            Console.WriteLine("After PassByValue: number = " + number);

            Console.WriteLine("Before PassByReference: number = " + number);
            PassByReference(ref number);
            Console.WriteLine("After PassByReference: number = " + number);


                // 3)

                Console.Write("Enter number 1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter number 2: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter number 3: ");
                int num3 = int.Parse(Console.ReadLine());

                Console.Write("Enter number 4: ");
                int num4 = int.Parse(Console.ReadLine());

                (int sum, int difference) result = Calculate(num1, num2, num3, num4);

                Console.WriteLine($"Sum: {result.sum}");
                Console.WriteLine($"Difference: {result.difference}");



                bool prime = isPrime(num);
            if (prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            

        }
    }
}
