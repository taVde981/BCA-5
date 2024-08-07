using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

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
            Console.WriteLine("7. Input a string and count number of words");
            Console.WriteLine("8. Compare two strings without using string library functions.");
            Console.WriteLine("9. Count the total number of alphabets, digits and special characters in a string.");
            Console.WriteLine("10. Count the total number of vowels or consonants in a string");
            Console.WriteLine("11. Count element with highest frequency in the string without any function");
            Console.WriteLine("12. Sort a string array in ascending order without using function");
            Console.WriteLine("13. Extract a substring from a given string without using function");            
            Console.WriteLine("14. Check whether a substring is present in a string without using function");
            Console.WriteLine("15. Find the number of times a given word 'the' appears in the given string.");
            Console.WriteLine("16. Remove characters from a string except alphabets");
            Console.WriteLine("17. Combine two strings manually");
            Console.WriteLine("18. Find the largest and smallest words in a string.");
            Console.WriteLine("19. Replace the spaces in a string with a specific character");
            Console.WriteLine("20. Read a file and remove the spaces between two words of its content.");

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
                string str = Console.ReadLine()!;
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
                    inp1 = Console.ReadLine()!;
                    rev = programs.revString(inp1);
                    Console.WriteLine("Reversing the Words String: " +  rev);
                    break;
                case 7:
                    programs.countWords();
                    break;
                case 8:
                    programs.compStringNoInFunc();
                    break;
                case 9:
                    programs.countEverything();
                    break;
                case 10:
                    programs.vowCons();
                    break;
                case 11:
                    programs.countFreq();
                    break;
                case 12:
                    programs.sortStr();
                    break;
                case 13:
                    programs.extractSub();
                    break;
                case 14:
                    programs.checkSub();
                    break;
                case 15:
                    programs.countTHE();
                    break;
                case 16:
                    programs.remCharLevAlpha();
                    break;
                case 17:
                    programs.combineStrings();
                    break;
                case 18:
                    programs.findSmallLarge();
                    break;
                case 19:
                    programs.replaceWhiteSpace();
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

        public void replaceWhiteSpace(){
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine()!;
            Console.WriteLine("Enter the character you want to replace the whitespaces with");
            char newch = Convert.ToChar(Console.ReadLine()!);
            char ch = ' ';
            int i, n = str.Length;
            string str2 = "";
            for(i = 0; i < n; i++){
                if(str[i] != ' '){
                ch = str[i];
                str2 += ch;}
                else
                str2 += newch;
            }
            Console.WriteLine("New String: " + str2);
        }

        /*public void findSmallLarge()
{
    Console.WriteLine("Enter a string");
    string str = Console.ReadLine()!;
    str = str + " "; // Ensure there's a trailing space to count the last word.

    int i, n = str.Length, count = 0, max = 0, min = int.MaxValue;

    for (i = 0; i < n; i++)
    {
        if (str[i] != ' ')
        {
            count++;
        }
        else if (count > 0)
        {
            if (count > max)
            {
                max = count;
            }
            if (count < min)
            {
                min = count;
            }
            count = 0;
        }
    }

    Console.WriteLine("Biggest word has " + max + " letters");
    Console.WriteLine("Smallest word has " + min + " letters");
}

static void Main()
{
    new Program().findSmallLarge();
}
*/

        public void findSmallLarge(){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            str = str + " ";
            int i, n = str.Length, count = 0, max = 0, min = 0;

            for(i = 0; i < n; i++){
                if(str[i] != ' ')
                count++;
                if(str[i] == ' '){
                if(count > max)
                {
                max = count;
                count = 0;
                }
                }
            }
            count = 0;
            Console.WriteLine("Biggest word has " + max + " Letters");
            min = max;
            for(i = 0; i < n; i++){
                if(str[i] != ' ')
                count++;
                if(str[i] == ' '){
                if(count < min)
                {
                min = count;
                count = 0;
                }
                }
            }
            Console.WriteLine("Smallest word has " + min + " Letters");

        }

        public void combineStrings(){
            Console.WriteLine("Enter string 1");
            string str1 = Console.ReadLine()!;
            Console.WriteLine("Enter string 2");
            string str2 = Console.ReadLine()!;
            string str3 = "";
            str2 = " " + str2;
            char ch = ' ';
            int i, n1 = str1.Length, n2 = str2.Length, n3 = n1 + n2;
            for(i = 0; i < n3; i++){
                if(i < n1){
                ch = str1[i];
                str3 +=  ch;
                }
                else{
                    ch = str2[i%n2];
                    str3 += ch; 
                }
            }
            Console.WriteLine("Combind String: " + str3);
        }

        public void remCharLevAlpha(){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            int i, ascii = 0, n = str.Length;
            char ch = ' ';
            Console.WriteLine("After Removal:-");
            for(i = 0; i < n; i++){
                ch = str[i];
                ascii = ch;
                if((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <=122)){
                    Console.Write(ch);
                }
            }
            Console.WriteLine();
        }

        public void countTHE(){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            int i, count = 0, n = str.Length;
            for(i = 0; i < n; i++){
                if(((str[i] == 'T' && str[i+1] == 'h' && str[i+2] == 'e') || (str[i] == 't' && str[i+1] == 'h' && str[i+2] == 'e') || (str[i] == 'T' && str[i+1] == 'H' && str[i+2] == 'E')) && i < n)
                count++;
            }
            Console.WriteLine("Number of the/THE: " + count);
        }

        public void checkSub(){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            Console.WriteLine("Enter substring you want to check");
            string substr = Console.ReadLine()!;

            int i, n1 = str.Length, n2 = substr.Length, count = 0, m = 0;
            char ch = substr[0];
            //bool flag = true;

            for(i = 0; i < n1; i++){
                if(str[i] == ch){
                    m = i;
                    break;
                }
            }
            for(i = m; i <= n1; i++){
                    if(str[i] == substr[count]){
                        count++;
                    }
                    if(count == n2){
                        break;
                    }
            }
            if(count == n2)
            Console.WriteLine("String contains inputted Substring");
            else
            Console.WriteLine("String does NOT contain the substring");
        }

        public void extractSub(){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            int n = str.Length, i, m1=0, m2=0;
            Console.WriteLine("Enter starting index");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending index");
            m2 = Convert.ToInt32(Console.ReadLine());

            if(m1 < n && m2 < n && m1 < m2){
                for(i = m1; i < m2; i++){
                    Console.Write(str[i]);
                }
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Please give proper inputs");
            }

        }

        public void sortStr(){
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine()!;
            int i, j, n = str.Length, asciii = 0, temp = 0;
            int[] ascii = new int[n];
            char ch = ' ';
            for(i = 0; i < n; i++){
                ch = str[i];
                asciii = ch;
                ascii[i] = asciii;
            }

            for(i = 0; i < n-1; i++){
                for(j = i+1; j < n; j++){
                    if(ascii[j] > ascii[i]){
                        temp = ascii[i];
                        ascii[i] = ascii[j];
                        ascii[j] = temp;
                    }
                }
            }

            for(i = 0; i < n; i++){
                asciii = ascii[i];
                ch = (char)asciii;
                Console.Write(ch);
            }
            Console.WriteLine();
        }

        public void countFreq() {
        int[] ch_freq = new int[128];
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine()!;
        int n = str.Length;

        for (int i = 0; i < n; i++) {
            if (str[i] != ' ') {
                int ascii = str[i];
                ch_freq[ascii]++;
            }
        }

        int max = 0;
        char maxChar = ' ';
        for (int i = 0; i < 128; i++) {
            if (ch_freq[i] > max) {
                max = ch_freq[i];
                maxChar = (char)i;
            }
        }

        Console.WriteLine("Character: " + maxChar);
        Console.WriteLine("Frequency: " + max);
    }


        public void vowCons(){
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine()!;
            int[] vowels = {65, 69, 73, 79, 85, 97, 101, 105, 111, 117};
            int i, j, n = str.Length, ascii = 0, vow = 0, cons = 0;
            char ch = ' ';
            bool flag = false;
            for(i = 0; i < n; i++){
                ch = str[i];
                ascii = ch;
                for(j = 0; j < 10; j++){
                    if(ascii == vowels[j])
                    {
                        vow++;
                        flag = true;
                        break;
                    }
                }
                    if((flag == false) && ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii<=122)))
                    {
                        cons++;
                    }
                ch = ' ';
                ascii = 0;
                flag = false;
            }
            Console.WriteLine("Number of Vowels: " + vow);
            Console.WriteLine("Number of Consonants: " + cons);
        }


        public void countEverything() {
        Console.WriteLine("Enter a String");
        string str = Console.ReadLine() ?? string.Empty; // Handle null input
        int alphabet = 0, number = 0, sp_char = 0;
    
        for (int i = 0; i < str.Length; i++) {
            char ch = str[i];
            int ascii = ch;
        
            if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122)) {
                alphabet++;
            } else if (ascii >= 48 && ascii <= 57) {
                number++;
            } else {
                sp_char++;
            }
        }

        Console.WriteLine("Number of Alphabets: " + alphabet);
        Console.WriteLine("Number of Numbers: " + number);
        Console.WriteLine("Number of Special Characters: " + sp_char);
    }


        public void compStringNoInFunc(){
            Console.WriteLine("Enter First string");
            string str1 = Console.ReadLine()!;
            Console.WriteLine("Enter Second string");
            string str2 = Console.ReadLine()!;
            int i, n1 = str1.Length, n2 = str2.Length;
            bool flag = true;
            if(n1 == n2){
                for(i = 0; i < n1; i++){
                    if(str1[i] != str2[i]){
                    flag = false;
                    break;
                    }
                }
            }
            else{
                flag = false;
            }

            if(flag == false)
            Console.WriteLine("Both strings are NOT equal");
            else
            Console.WriteLine("Given strings are equal");
        }

        public void countWords(){
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine()!;
            str.Trim();
            str =  str + " ";
            int i, n = str.Length, count = 0;
            for(i = 0; i < n; i++){
                if(str[i] == ' ')
                count++;
            }
            Console.WriteLine("Number of Words in the string: " + count);
        }

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
                email_ids[i] = Console.ReadLine()!;
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
            str = Console.ReadLine()!;
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
                        ch2 = Convert.ToChar(ascii);
                        ascii += 32;
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
            str = Console.ReadLine()!;
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
            str = Console.ReadLine()!;
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
