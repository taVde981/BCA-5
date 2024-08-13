namespace NumberProgramsLibrary
{

public class NumPrograms
{
    public bool amicableNumber(int num){
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

    public bool circularPrimeNumber(int num){
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
}
}
