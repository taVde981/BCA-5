using System;
using System.Diagnostics.Contracts;

namespace Number_Programming
{
    class Execution
    {
        public static void Main(string[] args)
        {
            int ch, num;
            String str;
            bool flag;
            while (true)
            {
                Console.WriteLine("Enter a number");
                str = Console.ReadLine();
                num = Convert.ToInt32(str);
                Programs programs = new Programs();
                Console.WriteLine("Enter Choice");
                Console.WriteLine("1. Spy Number");
                Console.WriteLine("2. Disarium Number");
                Console.WriteLine("3. Pronic Number");
                Console.WriteLine("4. Deficient Number");
                Console.WriteLine("5. Krishnamurthy Number");
                Console.WriteLine("6. Special 2 Digit Number");
                Console.WriteLine("7. Super Perfect Number");
                Console.WriteLine("8. Duck Number");
                Console.WriteLine("9. Cyclic Number");
                Console.WriteLine("10. Sunny Number");
                Console.WriteLine("11. Show Information\n");

                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        flag = programs.spyNum(num);
                        if (flag) Console.WriteLine("Number is Spy Number");
                        else Console.WriteLine("Not Spy Number");
                        break;
                    case 2:
                        flag = programs.disariumNum(num);
                        if (flag) Console.WriteLine("Number is Disarium Number");
                        else Console.WriteLine("Not Disarium Number");
                        break;
                    case 3:
                        flag = programs.pronicNum(num);
                        if (flag) Console.WriteLine("Number is Pronic Number");
                        else Console.WriteLine("Not Pronic Number");
                        break;
                    case 4:
                        flag = programs.deficientNum(num);
                        if (flag) Console.WriteLine("Number is Deficient Number");
                        else Console.WriteLine("Not Deficient Number");
                        break;
                    case 5:
                        flag = programs.krishnamNum(num);
                        if (flag) Console.WriteLine("Number is Krishnamurthy Number");
                        else Console.WriteLine("Not Krishnamurthy Number");
                        break;
                    case 6:
                        flag = programs.spectwoNum(num);
                        if (flag) Console.WriteLine("Number is Special Two Digit Number");
                        else Console.WriteLine("Not Special Two Digit Number");
                        break;
                    case 7:
                        flag = programs.supfectNum(num);
                        if (flag) Console.WriteLine("Number is Super Perfect Number");
                        else Console.WriteLine("Not Super Perfect Number");
                        break;
                    case 8:
                        flag = programs.duckNum(str, num);
                        if (flag) Console.WriteLine("Number is Duck Number");
                        else Console.WriteLine("Not Duck Number");
                        break;
                    case 9:
                        flag = programs.cyclicNum(num);
                        if (flag) Console.WriteLine("Number is Cyclic Number");
                        else Console.WriteLine("Not Cyclic Number");
                        break;
                    case 10:
                        flag = programs.sunnyNum(num);
                        if (flag) Console.WriteLine("Number is Sunny Number");
                        else Console.WriteLine("Not Sunny Number");
                        break;
                    case 11:
                        programs.showInformation();
                        break;
                }
            }
        }
    }

    public class Programs
    {
        public bool spyNum(int num)
        {
            int d, sum=0, p =1;
            while (num != 0)
            {
                d = num % 10;
                sum = sum + d;
                p = p * d;
                num = num / 10;
            }
            if (sum == p) { 
            return true;
            }
            else
            {
                return false;
            }
        }

        public bool disariumNum(int num) {
            int d, m = num, mm = num, count=0, sum=0;
            while (num != 0)
            {
                d = num % 10;
                count++;
                num = num / 10;
            }

            while (m != 0)
            {
                d = m % 10;
                sum = sum + (int)Math.Pow(d, count);
                m = m / 10;
                count--;
            }
            if(sum == mm)
            { return true; }
            else { return false; }
        }

        public bool pronicNum(int num) {
            int p=0, flag = 0;
            int i = 1;
            do
            {
                p = 0;
                p = i * (i + 1);
                if (p == num)
                {
                    flag = 1;
                    break;
                }
                i++;
            } while (i < num && p < num);

            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deficientNum(int num) {
            int m = 2* num, sum = 0;
            for (int i = 1; i <= num; i++) {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum < m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool krishnamNum(int num) {
            int m = num, d, sum = 0;

            while(num != 0)
            {
                d = num % 10;
                sum = sum + fact(d);
                num = num / 10;
            }

            int fact(int d) {
                int p = 1;
                for (int i = 1; i <= d; i++) {
                    p = p * i;
                }
                return p;
            }

            if (m == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool spectwoNum(int num) {
            int m = num, mm = num, d, sum = 0, p = 1, count = 0;

            while (num != 0)
            {
                d = num % 10;
                count++;
                num = num / 10;
            }

            if (count != 2)
            {
                return false;
            }
            else {
                while (m != 0)
                {
                    d = m % 10;
                    sum = sum + d;
                    p = p * d;
                    m = m / 10;
                }
            }
            if ((sum + p) == mm)
            {
                return true;
            }
            else { return false; }
        }

        public bool supfectNum(int num) { 
            int m = num, d, sum1 = 0, sum2 = 0, twice = 2 * num;

            for (int i = 1; i <= num; i++)
            {
                if((num % i) == 0)
                {
                    sum1 = sum1 + i;
                }
            }

            for (int i = 1; i <= sum1; i++)
            {
                if (sum1 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }

            if (sum2 == twice)
            {
                return true;
            }
            else { return false; }
        }

        public bool duckNum(string str, int num)
        {
            int d, flag = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    return false;
                    break;
                }
                else
                {
                    break;
                }
            }

            while(num != 0)
            {
                d = num%10;
                if (d == 0)
                {
                    flag = 1;
                    break;
                }
                num = num/10;
            }
            if(flag  == 1)
            {  return true;}
            else { return false;}
        }

        public bool cyclicNum(int num) {
            return false;
        }

        public bool sunnyNum(int num)
        {
            int m = num + 1;
            int p = 0, flag = 0;
            int i = 1;
            do
            {
                p = 0;
                p = i * i;
                if (p == m)
                {
                    flag = 1;
                    break;
                }
                i++;
            } while (i < num && p < num);

            if(flag == 1)
            {
                return true;
            }
            else { return false;}

        }

        public void showInformation()
        {
            Console.WriteLine("Information about number programs:");
            Console.WriteLine("1. Spy Number: A number is a Spy number if the sum of its digits is equal to the product of its digits. (Example: 1124, 22)");
            Console.WriteLine("2. Disarium Number: A number is a Disarium number if the sum of its digits powered with their respective positions is equal to the number itself. (Example: 89, 135)");
            Console.WriteLine("3. Pronic Number: A number is a Pronic number if it is the product of two consecutive integers. (Example: 6, 12, 20)");
            Console.WriteLine("4. Deficient Number: A number is a Deficient number if the sum of its proper divisors is less than the number itself. (Example: 15, 22)");
            Console.WriteLine("5. Krishnamurthy Number: A number is a Krishnamurthy number if the sum of the factorial of its digits is equal to the number itself. (Example: 145, 40585)");
            Console.WriteLine("6. Special Two Digit Number: A two-digit number is special if the sum of its digits plus the product of its digits equals the original number. (Example: 19, 29)");
            Console.WriteLine("7. Super Perfect Number: A number is a Super Perfect number if twice the number is equal to the sum of the sum of its proper divisors. (Example: 6, 28)");
            Console.WriteLine("8. Duck Number: A number is a Duck number if it contains a zero in it, but it should not be at the beginning. (Example: 102, 304)");
            Console.WriteLine("9. Cyclic Number: A cyclic number is a number in which cyclic permutations of the digits are successive multiples of the number. (Example: 142857)");
            Console.WriteLine("10. Sunny Number: A number is a Sunny number if the number plus one is a perfect square. (Example: 8, 15)");
        }
    }
}