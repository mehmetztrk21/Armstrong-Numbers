using System;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(371));
        }

        public static bool IsArmstrong(int number)
        {
            int sum = 0;
            int temp = number;
            int control_temp = number;
            int count = 0;
            while (temp > 0)
            {
                temp /= 10;
                count += 1;
            }
            for (int i = count - 1; i >= 0; i--)
            {
                int temp_val = number / (int)Math.Pow(10, i);
                sum += (int)Math.Pow(temp_val, count);
                number = number - temp_val * (int)Math.Pow(10, i);
            }
            if (sum == control_temp)
            {
                return true;
            }
            return false;
        }
    }
}
