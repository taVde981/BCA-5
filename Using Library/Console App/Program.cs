using NPGC;
using NumberProgramsLibrary;
using StringProgramsLibrary;

class Program{

    public static void Main(string[] args){
        bool trigger = false;
        Class1 work = new Class1();
        NumPrograms numP = new NumPrograms();
        StringPrograms strP = new StringPrograms();
        Console.WriteLine(work.sum(100,200));
        Console.WriteLine(work.len("ABCDEFGH"));
        Console.WriteLine(work.name("Utkarsh"));

        
        trigger = numP.amicableNumber(50);
        if(trigger){
            Console.WriteLine("Amicable Number");
        }
        else{
            Console.WriteLine("Not Amicable Number");
        }

        trigger = numP.circularPrimeNumber(1193);
        if(trigger){
            Console.WriteLine("Amicable Number");
        }
        else{
            Console.WriteLine("Not Amicable Number");
        }

        strP.remCharLevAlpha();
        strP.replaceWhiteSpace();
    }
}
