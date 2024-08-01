using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StringProg{
    class Execution{
        public static void Main(string[] args){
            Programs programs = new Programs();
            int choice;
            Console.WriteLine("Enter a Choice");
            Console.WriteLine("1. Input a string, convert it into Uppercase and add 2 in each character");
            Console.WriteLine("2. Input a string and convert each character in it's opposite case");
            Console.WriteLine("3. Input a string and convert into Lowercase if it is in uppercase and display the word by replacing only the Vowels with the character following it");
            Console.WriteLine("4. Create a class ArrangeLetters and a method Arrange() with a string parameter. Convert the word into capital. Arrange each letter of the word in alphabetical order. Print the word before and after arranging letter in A-Z order");
            Console.WriteLine("5. Input 10 emails in an array and find how many of them are gmail accounts");
            Console.WriteLine("6. Reverse words in a given string");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice){
                case 1:
                programs.uppAndAdd();
                break;
                case 2:
                programs.oppCon();
                break;
                case 3:
                programs.lowerVowels();
                break;
                case 4:
                ArrangeLetters al = new ArrangeLetters();
                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();
                al.arrange(str);
                break;
                case 5:
                    int count = 0;
                    count = programs.countGmails();
                    Console.WriteLine(count + " Gmail accounts found");
                    break;
                case 6:
                    string rev, inp1;
                    Console.WriteLine("Enter String");
                    inp1 = Console.ReadLine();
                    rev = programs.revString(inp1);
                    Console.WriteLine("Reversing the Words String: " +  rev);
                    break;

            }
        }
    }

    public class ArrangeLetters{
        public void arrange(string str){
            str = str.ToUpper();
            str = str.Trim();
            string nstr = "";
            int i, j, l = str.Length;
            char[] arr = new char[l];
            char temp = ' ';

            for(i = 0; i < l; i++){
                temp = str[i];
                arr[i] = temp;
            }
            
            Console.WriteLine("Original String: " + str);

            for(i = 0; i < arr.Length-1; i++){
                //if(arr[i] != ' '){
                    for(j = i+1; j < arr.Length; j++){
                        if(arr[i] > arr[j]){
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                //}
            }

            for(i = 0; i < arr.Length; i++){
                nstr += arr[i];
            }

            Console.WriteLine("Sorted String: " + nstr);
        }
    }

    public class Programs{
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

        public void lowerVowels(){
            string str, nstr = "";
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            int i, j, ascii = 0;
            char[] vowels = {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
            char ch = ' ', ch2 = ' ';
            bool flag = false, space = false;
            for(i = 0; i < str.Length; i++){
                if(str[i] != ' '){
                    ch = str[i];
                    ascii = ch;
                    if(ascii >= 65 && ascii <= 90)
                    {
                        ascii += 32;
                        ch2 = Convert.ToChar(ascii);
                        nstr = nstr + ch2;
                    }
                    else if(ascii >= 97 && ascii <= 122){
                        ascii -= 32;
                        ch2 = Convert.ToChar(ascii);
                        nstr = nstr + ch2;
                    }
                    else{
                        nstr = nstr + ch;
                    }
                }
                else{
                    nstr = nstr + ' ';
                }
            }
            Console.WriteLine(nstr);


            for(i = 0; i < nstr.Length; i++){
                ch = nstr[i];
                for(j = 0; j < vowels.Length; j++){

                    if(nstr[i] == ' ')
                    {
                        space = true;
                    }

                    if(ch == vowels[j]){
                        ch2 = vowels[j];
                        ascii = ch2;
                        ascii += 1;
                        ch2 = Convert.ToChar(ascii);
                        flag = true;
                    }
                }
                if(space){
                    Console.Write(' ');
                }
                else if(flag){
                    Console.Write(ch2);
                }
                else{
                    Console.Write(ch);
                }
                flag = false;
                space = false;
            }


        }

        public void oppCon(){
            string str;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            int i, ascii = 0;
            char ch = ' ';
            for(i = 0; i < str.Length; i++){
                if(str[i] != ' '){
                    ch = str[i];
                    ascii = ch;
                    if(ascii >= 65 && ascii <= 90)
                    {
                        ascii += 32;
                        ch = Convert.ToChar(ascii);
                        Console.Write(ch);
                    }
                    else if(ascii >= 97 && ascii <= 122){
                        ascii -= 32;
                        ch = Convert.ToChar(ascii);
                        Console.Write(ch);
                    }
                    else{
                        Console.Write(' ');
                    }
                }
            }
        }

        public void uppAndAdd(){
            string str = "";
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            str.Trim();
            str = str.ToUpper();
            Console.WriteLine("String in Uppercase: " + str);
            char ch = ' ';
            int i, con = 0;
            for(i = 0; i < str.Length; i++){
                if(str[i] != ' '){
                    ch = str[i];
                    con = ch;
                    con += 2;
                    ch = Convert.ToChar(con);
                    Console.Write(ch);
                }
                else{
                    Console.Write(' ');
                }
            }
        }

    }
}