namespace StringProgramsLibrary
{

public class StringPrograms
{
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
}
}