using System;

namespace TypesOfConstructor{
    public class Box{
        int length, breadth, height;
        public Box(){
            length = 0;
            breadth = 0;
            height = 0;
        }

        public Box(int l, int b, int h){
            length = l;
            breadth = b;
            height = h;
        }
        public void show(){
            Console.WriteLine(length+" "+breadth+" "+height);
        }
    }

    public class Factory{
        public static void Main(string[] args){
            Box box1 = new Box();
            Box box2 = new Box(12,15,20);
            box1.show();
            box2.show();
        }  
    }
}