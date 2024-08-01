using System;

namespace FindDotComInEmails
{
    public class Execution
    {
        public static void Main(string[] args)
        {
            Programs programs = new Programs();
            int ch;
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1. Input 10 emails in an array and find how many of them are gmail accounts");
            Console.WriteLine("2. Reverse words in a given string");
            Console.WriteLine("3. Find Longest Common Prefix");
            Console.WriteLine("4. Convert Roman Numerals to Integer");
            Console.WriteLine("5. Convert Integer numbers to Roman numerals");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch) {
                case 1:
                    int count = 0;
                    count = programs.countGmails();
                    Console.WriteLine(count + " Gmail accounts found");
                    break;
                case 2:
                    string rev, inp1;
                    Console.WriteLine("Enter String");
                    inp1 = Console.ReadLine();
                    rev = programs.revString(inp1);
                    Console.WriteLine("Reversing the Words String: " +  rev);
                    break;
                case 3:
                    string outp;
                    outp = programs.lcPrefix();
                    Console.WriteLine("Largest Common Prefix: " + outp);
                    break;
                case 4:
                    string inp2, outp2;
                    Console.WriteLine("Enter a Number in Roman Numerals");
                    inp2 = Console.ReadLine();
                    outp2 = programs.romanToInt(inp2);
                    break;


            }
        }
    }

    public class Programs
    {
        //***************4***************

        public string romanToInt(string inp)
        {
            char[] roman = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

        }

        //***************3***************

        public string lcPrefix()
        {
            string[] words = new string[4];
            string pref = "";
            char ch = words[0][0];
            int i, count = 0 ;

            for(i = 0; ; i++)
            {
                if (i == 4)
                {
                    i = i % 4;
                }

                if(ch ==)
            }

            return pref;
        }

        //***************2***************

        public string revString(string inp)
        {
            inp = inp.Trim();
            inp = inp + " ";
            string word = "", nstring = "";
            int len = inp.Length, i, j;
            for (i = 0; i < len; i++)
            {
                if (inp[i] != ' ')
                {
                    word += inp[i];
                }
                if (inp[i] == ' ')
                {
                    for (j = word.Length - 1; j >= 0; j--)
                    {
                        nstring += word[j];
                    }
                    word = " ";
                    nstring += " "; 
                    //i++;
                }
                
            }

            return nstring;
        }

        //***************1***************
        public int countGmails()
        {
            string[] email_ids = new string[10];
            int i, count = 0;
            for(i = 0;  i < email_ids.Length; i++)
            {
                Console.WriteLine("Enter Email " + (i + 1));
                email_ids[i] = Console.ReadLine();
            }
            i = 0;
            for(i = 0; i < email_ids.Length; i++)
            {
                if (email_ids[i].Contains("gmail") || email_ids[i].Contains("GMAIL"))
                    count++;
            }

            return count;
        }
    }
}