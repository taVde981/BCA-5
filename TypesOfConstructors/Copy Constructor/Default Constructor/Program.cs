using System;

namespace TypesOfContructors{
    public class Box{
        int length, breadth, height;
        public Box(){
            length = 0;
            breadth = 0;
            height = 0;
        }

        public void show(){
            Console.WriteLine("Default: "+length+" "+breadth+" "+height);
        }
    }

    public class Factory{
        public static void Main(string[] args){
            Box box1 = new Box();
            box1.show();
        }
    }
}