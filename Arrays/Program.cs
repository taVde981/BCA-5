using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    class Execution
    {
        public static void Main(string[] args)
        {
            int ch;
            Programs programs = new Programs();
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1. Find the minimum and maximum element of an array");
            Console.WriteLine("2. Print elements of the array in reverse");
            Console.WriteLine("3. Sort and print array elements in both ascending and descending order");
            Console.WriteLine("4. Print K’th Smallest Element in Unsorted Array");
            Console.WriteLine("5. Count number of occurrences (or frequency) in a sorted array");
            Console.WriteLine("6. Dutch National Flag problem");
            Console.WriteLine("7. Find Subarray with given Sum from Array of non-negative Numbers");
            Console.WriteLine("8. Move all negative numbers to beginning and positive to end");
            Console.WriteLine("9. Union and Intersection of two arrays");
            Console.WriteLine("10. Find a peak element which is not smaller than its neighbours");
            Console.WriteLine("11. Update every array element with multiplication of previous and next numbers in array");
            Console.WriteLine("12. Rearrange an array in such an order that– small, large, second smallest, second largest, etc.");
            Console.WriteLine("13. Return the number of clumps (a series of 2 or more adjacent elements of the same value) in a given array");
            Console.WriteLine("14. Check if an array can be split in such a way that the left side of the splitting is equal to the sum of the right side");
            Console.WriteLine("15. Copy elements from first array into another array");
            Console.WriteLine("16. Segregate even and odd elements in an array");
            Console.WriteLine("17. Find the largest element of each and every contiguous subarray of size k from a given array");
            Console.WriteLine("18. Rearrange positive and negative numbers alternatively in a given array.");
            Console.WriteLine("19. PLace elements from one array into another without using any sort");
            Console.WriteLine("20. Rearrange the given array so that arr[i] becomes arr[arr[i]]");



            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    programs.elements();
                    programs.show();
                    programs.minmax();
                    break;
                case 2:
                    programs.elements();
                    programs.show();
                    programs.revArray();
                    break;
                case 3:
                    programs.elements();
                    programs.show();
                    programs.sortArray();
                    break;
                case 4:
                    programs.elements();
                    programs.show();
                    programs.kmin();
                    break;
                case 5:
                    programs.elements();
                    programs.show();
                    programs.freq();
                    break;
                case 6:
                    programs.elements();
                    programs.show();
                    programs.dutch();
                    break;
                case 7:
                    programs.elements();
                    programs.findSubarrayWithGivenSum();
                    break;
                case 8:
                    programs.elements();
                    programs.show();
                    programs.negposort();
                    break;
                case 9:
                    programs.elements();
                    programs.unisect();
                    break;
                case 10:
                    programs.elements();
                    programs.show();
                    int n = programs.peakVal();
                    Console.WriteLine("\nIndex at which Peak value lies: " + n);
                    break;
                case 11:
                    programs.elements();
                    programs.show();
                    programs.prevNextMult();
                    break;
                case 12:
                    programs.elements();
                    programs.show();
                    programs.rearrangeWeird();
                    break;
                case 13:
                    programs.elements();
                    programs.show();
                    programs.countClumps();
                    break;
                case 14:
                    /*programs.elements();
                    programs.show();
                    programs.splitSumCheck();*/
                    break;
                case 15:
                    programs.elements();
                    programs.show();
                    programs.copyArray();
                    break;
                case 16:
                    programs.elements();
                    programs.show();
                    programs.segregateEvenOdd();
                    break;
                case 17:
                    programs.elements();
                    programs.show();
                    programs.subArrayMax();
                    break;
                case 18:
                    programs.elements();
                    programs.show();
                    programs.alternatePosNeg();
                    break;
                case 19:
                    programs.elements();
                    programs.show();
                    programs.noSortSorting();
                    break;
                case 20:
                    programs.elements();
                    programs.show();
                    programs.rearrange();
                    break;
                
            }
        }
    }

    public class Programs
    {
        int[] arr = new int[10];
        public void elements()
        {
            Console.WriteLine("Enter 10 Array Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //************************************

        public void minmax()
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i+1] > temp) {
                    temp = arr[i + 1];
                }
            }
            Console.WriteLine("\nBiggest Element: " + temp);
            temp = arr[0];
            for (int i = 0;i < arr.Length-1; i++) {
                if (arr[i + 1 ] < temp)
                {
                    temp = arr[i + 1];
                }
            }
            Console.WriteLine("Smallest Element: " + temp);
        }

        //____________________________________

        public void revArray()
        {
            Console.WriteLine("\nReverse of the array: ");
            for (int i = arr.Length - 1; i >= 0; i--) { 
                Console.Write(arr[i] + " ");
            }
        }

        //____________________________________

        public void sortArray()
        {
            Console.WriteLine("\nArray Sorted in descending order");
            dsort();
            show();

            Console.WriteLine("\nArray Sorted in ascending order");
            sort();
            show();
        }

        //____________________________________

        public void kmin() {
            int temp = 0, k = 0;
            sort();

            Console.Write("\nEnter value of k: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(arr[k-1] + " is the " + "k'th smallest number in the array");
        }

        //____________________________________

        public void freq() {
            int k = 0, count = 0;
            Console.WriteLine("\nEnter value to be counted");
            k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == k) {
                    count++;
                }
            }
            Console.WriteLine(k + " was encountered " + count + " times in the array");
        }

        //____________________________________

        public void dutch()
        {
            int flag = 0;
            sort();
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > 2)
                {
                    Console.WriteLine("Entered array is not Dutch array");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                show();
            }
        }

        //____________________________________

        public void findSubarrayWithGivenSum()
        {
            Console.WriteLine("\nEnter the sum to find the subarray:");
            long sum = Convert.ToInt64(Console.ReadLine());
            List<int> result = SubarraySum(arr, arr.Length, sum);

            if (result.Count == 2 && result[0] != -1)
            {
                Console.WriteLine($"\nSubarray with given sum found between indexes {result[0]} and {result[1]}.");
            }
            else
            {
                Console.WriteLine("\nNo subarray with given sum found.");
            }
        }

        private List<int> SubarraySum(int[] arr, int n, long sum)
        {
            List<int> res = new List<int>();
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                int currentSum = arr[i];
                if (currentSum == sum)
                {
                    res.Add(i + 1);
                    res.Add(i + 1);
                    flag = true;
                    break;
                }
                else
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        currentSum += arr[j];
                        if (currentSum == sum)
                        {
                            res.Add(i + 1);
                            res.Add(j + 1);
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }
            }

            if (flag)
                return res;
            return new List<int> { -1 };
        }

        //____________________________________

        public void negposort()
        {
            sort();
            Console.WriteLine();
            show();

        }

        public void unisect()
        {
            int[] arr2 = new int[10];
            int temp2 = 0;
            Console.WriteLine("Enter 10 Array Elements");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int [] temp = new int[20];

            for (int i = 0;i < temp.Length; i++)
            {
                if (i < 10)
                {
                    temp[i] = arr[i];
                }
                else
                {
                    temp[i] = arr2[i % 10];
                }
            }

            int[] result = RemoveDuplicates(temp);

            Console.WriteLine("Union of both arrays: ");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

        static int[] RemoveDuplicates(int[] temp)
        {
            // Using a HashSet to store unique elements
            HashSet<int> uniqueElements = new HashSet<int>(temp);
            return uniqueElements.ToArray();
            }


            int[] intersection = FindIntersection(arr, arr2);

            Console.WriteLine("\nIntersection of the two arrays:");
            foreach (int num in intersection)
            {
                Console.Write(num + " ");
            }
        }

        static int[] FindIntersection(int[] arr, int[] arr2)
        {
            HashSet<int> set1 = new HashSet<int>(arr);
            HashSet<int> set2 = new HashSet<int>(arr2);

            // Find common elements
            set1.IntersectWith(set2);

            return set1.ToArray();
        }

        public int peakVal()
        {
            int n = arr.Length;

            if (n == 0)
            {
                return 0;
            }
            if (arr[0] > arr[1]) {
                return 0;
            }
            if ((arr[n - 1] > arr[n - 2])){
                return n - 1;
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= arr[i+1] && arr[i] >= arr[i-1]) {
                    return i;
                }
            }
            return 0;
        }

        //____________________________________

        public void prevNextMult(){
            int i, n = arr.Length;
            for(i = 0; i < n; i++){
                if(i == 0){
                    Console.Write((arr[i] * arr[i+1]) + " ");
                }
                else if(i == n-1){
                    Console.Write((arr[i] * arr[i-1]) + " ");
                }
                else{
                    Console.Write((arr[i-1] * arr[i+1]) + " ");
                }
            }
        }

        //____________________________________

        public void rearrangeWeird(){
            sort();
            int i, length = arr.Length;
            for(i = 0; i < length; i++){
                if(i == length/2)
                break;
                Console.Write(arr[i] + " " + arr[(length-1)-i] + " ");
            }
        }

        //____________________________________

        public void countClumps(){
        int i, count = 0, n = arr.Length;
        bool inClump = false;

        for(i = 0; i < n - 1; i++){
            if(arr[i] == arr[i+1]){
                if(!inClump){
                    count++;
                    inClump = true;
                }
            } else {
                inClump = false;
            }
        }
        Console.WriteLine("Clumps Found : " + count);
    }

        //____________________________________

        /*

        public void splitSumCheck(){
            int i, sum = 0, n = string.Length;
            for(i = 0; i < n; i++){
                sum += arr[i];
            }
            double half = sum/2;
            
        }
        */

        //____________________________________

        public void copyArray(){
            int i, n = arr.Length;
            int[] arr2 = new int[n];

            for(i = 0; i < n; i++){
                arr2[i] = arr[i];
            }

            Console.WriteLine("Elements successfully copied!");
            for(i = 0; i < n; i++){
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
        }

        //____________________________________
        public void segregateEvenOdd(){
            int i, j = 0, n = arr.Length;
            int[] segregated = new int[n];
            for(i = 0; i < n; i++){
                if(arr[i] % 2 == 0){
                segregated[j] = arr[i];
                j++;
                }
            }
            for(i = 0; i < n; i++){
                if(arr[i] % 2 != 0){
                segregated[j] = arr[i];
                j++;
                }
            }
            Console.WriteLine("Segregated array!");
            for(i = 0; i < n; i++){
                Console.Write(segregated[i] + " ");
            }
            
        }
        //____________________________________
        public void subArrayMax(){
            int i = 0, n = arr.Length, k = 0, j = 0, temp = 0, count = 1, dup = 0;
            Console.WriteLine("Enter Length of sub-array");
            k = Convert.ToInt32(Console.ReadLine())!;
            dup = k;
            while(k <= n && ((k - i) == dup)){
                for(j = i; j < k-1; j++){
                    if(arr[j+1] > arr[j]){
                        temp = arr[j+1];
                    }
                }
                Console.WriteLine("Max Element in " + count + " iteration: " + temp);
                i++;
                k++;
                count++;
            }
        }
        //____________________________________
        public void alternatePosNeg(){
            int i, j = 0, k = 1, n = arr.Length, pcount = 0, ncount = 0;
            int[] alternated = new int[n];
            for(i = 0; i < n; i++){
                if(arr[i] >= 0){
                    pcount++;
                }
                else
                {
                    ncount++;
                }
            }
            //if(pcount > ncount){
                for(i = 0; i < n; i++){
                    if(arr[i] >= 0 && j<n){
                        alternated[j] = arr[i];
                        j += 2;
                    }
                    else{
                        alternated[k] = arr[i];
                        k += 2;
                    }
                }
            //}
            /*else{
               for(i = 0; i < n; i++){
                    if(arr[i] < 0 && j<n){
                        alternated[j] = arr[i];
                        j += 2;
                    }
                    else{
                        alternated[k] = arr[i];
                        k += 2;
                    }
                } 
            }*/
            

            Console.WriteLine("Alternated array!");
            for(i = 0; i < n; i++){
                Console.Write(alternated[i] + " ");
            }
        }
        //____________________________________
        public void noSortSorting(){
            int i, j = 0, n = arr.Length;
            int[] interchanged = new int[n];
            for(i = 0; i < n; i++){
                j = arr[i];
                interchanged[j] = arr[i];
            }
            Console.WriteLine("Interchanged Array");
            for(i = 0; i < n; i++){
                Console.Write(interchanged[i] + " ");
            }
        }

        //____________________________________

        public void rearrange()
        {
            int n = arr.Length;

            // Step 1: Increase all values by (arr[arr[i]] % n) * n
            for (int i = 0; i < n; i++)
            {
                arr[i] += (arr[arr[i]] % n) * n;
            }

            // Step 2: Divide all values by n to get the final result
            for (int i = 0; i < n; i++)
            {
                arr[i] /= n;
            }

            for(int i = 0; i < n; i++){
                Console.Write(arr[i] + " ");
            }

        }


        //************************************

        public void sort()
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        //____________________________________

        public void dsort()
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        //____________________________________

        public void show()
        {
            Console.WriteLine("Array Elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
