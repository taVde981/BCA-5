using System;

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
                Console.WriteLine("\nEnter a number");
                str = Console.ReadLine()!;
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
                Console.WriteLine("12. Keith Number");
                Console.WriteLine("13. Pell Number");
                Console.WriteLine("14. Narcissistic number");
                Console.WriteLine("15. Mersenne Prime");
                Console.WriteLine("16. Six Fermat Number");
                Console.WriteLine("17. Ideal Cube");
                Console.WriteLine("18. Circular Prime");
                Console.WriteLine("19. Goldbach number");
                Console.WriteLine("20. Amicable Number");


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
                    case 12:
                        flag = programs.keithNum(num);
                        if (flag) Console.WriteLine("Number is Keith Number");
                        else Console.WriteLine("Not Keith Number");
                        break;
                    case 13:
                        programs.pellNum(num);
                        break;
                    case 14:
                        flag = programs.narciNum(num);
                        if (flag) Console.WriteLine("Number is Narcissistic Number");
                        else Console.WriteLine("Not Narcissistic Number");
                        break;
                    case 15:
                        programs.mersennePrime(num);
                        break;
                    case 16:
                        programs.fermatNum(7);
                        break;
                    case 17:
                        flag = programs.idealCube(num);
                        if (flag) Console.WriteLine("Number is Ideal Cube");
                        else Console.WriteLine("Not Ideal Cube");
                        break;
                    case 18:
                        flag = programs.circularPrime(num);
                        if (flag) Console.WriteLine("Number is Circular Prime");
                        else Console.WriteLine("Not Circular Prime");
                        break;
                    case 19:
                        programs.goldbachNum(num);
                        break;
                    case 20:
                        flag = programs.amicableNum(num);
                        if (flag) Console.WriteLine("Number is Amicable Number");
                        else Console.WriteLine("Not Amicable Number");
                        break;
                }
            }
        }
    }

    public class Programs
    {
        public bool amicableNum(int num){
            int sq = 0;
            sq = num * num;
            bool flag = true;

            while(num != 0){
                if(num%10 != sq%10){
                flag = false;
                return flag;
                }

                num /= 10;
                sq /= 10;
            }
            return flag;

        }

        public void goldbachNum(int num){
            int i, m = num, a = 0, b = 0;
            Console.WriteLine("Prime pairs are: ");
            for(i = 3; i <= num/2; i++){
                a = i;
                b = num - i;
                if(isPrime(a) && isPrime(b))
                Console.WriteLine(a + "+" + b + "=" + num);
            }

            bool isPrime(int n){
                int i, count = 0;
                for(i = 1; i <=n; i++){
                    if(n % i == 0){
                        count++;
                    }
                }
                if(count == 2){
                    return true;
                }
                else{
                    return false;
                }
            }
        }

        public bool circularPrime(int num){
            int d = 0, i = 0, count = 0, m = num, temp = num, p = 0;
            bool flag = true;
            while(num != 0){
                count++;
                num /= 10;
            }
            Console.WriteLine(count);
            num = m;
            do{
                flag = isPrime(num);
                if(!flag)
                break;
                else
                {
                    d = num%10;
                    num /= 10;
                    p = d * (int)Math.Pow(10, count-1);
                    num = num+p;
                    Console.WriteLine(num);
                    i++;
                }
            }while(i<=count-1);

            bool isPrime(int n){
                int j, count = 0;
                for(j = 1; j <= n; j++){
                    if((n%j) == 0)
                    count++;
                }
                if(count == 2)
                return true;
                else
                return false;
            }

            return flag;
        }

        public bool idealCube(int num){
            double croot = 0;
            croot = Math.Cbrt(num);
            if((croot * croot * croot) == num)
            return true;
            else
            return false;
        }

        public void fermatNum(int num){
            long s = 0, k = 0;
            while(k < num){
                s = (long)Math.Pow(2, ((long)Math.Pow(2, k))) + 1;
                k++;
                Console.Write(s + " ");
            }
        }

        public void mersennePrime(int num){
            int i = 2, s = 0, k = 0;
            while(k <= num){
                if(prime(i)){
                s = (int)Math.Pow(2, i) - 1;
                k++;
                Console.Write(s + " ");
                }
                i++;
            }
            bool prime(int n){
                int j, count = 0;
                for(j = 1; j <= n; j++){
                    if((n%j) == 0)
                    count++;
                }
                if(count == 2)
                return true;
                else
                return false;
            }
        }

        public bool narciNum(int num){
            int m = num, d = 0, sum = 0, count = 0;
            while(num != 0){
                count++;
                num /= 10;
            }
            num = m;
            while(num != 0){
                d = num%10;
                sum += (int)Math.Pow(d, count);
                num /= 10;
            }
            num = m;
            if(sum == num)
            return true;
            else
            return false;            
        }
        public void pellNum(int num){
            int i, count = 0, p;
            int[] operation = new int[3];
            for(i = 0; i < num; i++){
                if(count == 0){
                    operation[0] = 0;
                    Console.Write("0 ");
                    count++;
                }
                else if(count == 1){
                    operation[1] = 1;
                    Console.Write("1 ");
                    count++;
                }
                else{
                    p = 2*operation[1] + operation[0];
                    Console.Write(p + " ");
                    operation[2] = p;
                    operation[0] = operation[1];
                    operation[1] = operation[2];
                }
            }
        }

        public bool keithNum(int num){
            int sum = 0, d = 0, m = num, i, count = 0, dup = 0;
            bool flag=false;
            while(num != 0){
                d = d % 10;
                count++;
                num = num/10;
            }
            dup = count;
            int[] operation = new int[count];
            num = m;
            while(num != 0){
                count--;
                d = num%10;
                operation[count] = d;
                num = num/10;
            }
            count = dup;
            num = m;
            while(sum <= num){
                for(i = 0; i < count; i++){
                    sum += operation[i];
                }
                for(i = 0; i < count-1; i++){
                    operation[i] = operation[i+1];
                }
                operation[count-1] = sum;
                if(sum == num){
                    flag = true;
                    break;
                }
                sum = 0;
            }
            return flag;
        }

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
            int m = num, sum1 = 0, sum2 = 0, twice = 2 * num;

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
            int d, i = 0, flag = 0;
            while(i < str.Length){
                if (str[i] == '0')
                {
                    i++;
                    return false;
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
