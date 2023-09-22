using System;
using System.ComponentModel.Design;
using System.Net.Sockets;

namespace SearchingAlgorithmProblems
{
    public class SearchingAlgorithmProblems
    {
        public int Problem1(int[] A, int target) //searching for a target value in a array
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == target) {
                    return i + 1; }


            }
            return -1;
        }
       
        public int Problem2(int[] A, int target) //counting the occurances of a specific value
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == target)
                {
                    count++;
                }
            }
            return count;
        }

        public void Problem3(int[] A, int target) //Finding the first and last occurance of a target value
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == target)
                    count++;
            }

            if (count > 0)
            {
                int[] occurance = new int[count];
                int index = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == target)
                    {
                        occurance[index] = i;
                        index++;
                    }

                }

                Console.WriteLine("\nFirst Occurance at:{0}", occurance[0]);
                Console.WriteLine("\nLast Occurance at:{0}", occurance[occurance.Length - 1]);
            }
        
        }


        public void Problem4(int[] A) //Sum of all elements of the array
        {
            int total = 0;
            for(int i = 0;i < A.Length;i++)
            {
                total += A[i];
            }
            Console.WriteLine("\nThe sum of the elements of the array is:{0}", total);
        }
    

        public void Problem5(int[] A)//Biggest and the smallest elements of the array
        {
            int big = 0;
            int small = A[0];
            for(int i = 0;i< A.Length; i++)
            {
                if (A[i] >big)
                    big = A[i];
               
                
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < small)
                    small = A[i];
            }
            Console.WriteLine("\nBig is:{0} and the small is{1} ", big,small);
        }


        public void Problem6(string[] strings,string SearchValue) //Searching for a name in a string array 
        {
            int index = 0;
            for(int i=0;i< strings.Length;i++)
            {
                if (strings[i] == SearchValue)
                {
                    index = i+1;
                   
                    break;
                }
               
            }
            if(index!= 0)
            {
                Console.WriteLine("\nThe element is at position no: {0}", index);
            }
            else
            { 
                Console.WriteLine("\nThere is no such element");
            }
        }

        static void Main(string[] args) 
        {
            SearchingAlgorithmProblems problem= new SearchingAlgorithmProblems();    
            
            Console.WriteLine("\nEnter the size of the array");
            int n =Convert.ToInt32(Console.ReadLine());

            //int[] A = new int[n];
            //Console.WriteLine("\nEnter Elements");
            //for(int i = 0;i < A.Length;i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\nEnter the value to be searched");
            //int Target = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nEnter the value of which the count has be determined");
            //int CountTargetValue = Convert.ToInt32(Console.ReadLine());
            //int TargetIndex = problem.Problem1(A, Target);
            //int TargetCount = problem.Problem2(A, CountTargetValue);
            //Console.WriteLine("\nThe value is at position no:{0}", TargetIndex);
            //Console.WriteLine("\nThe count of the target value is:{0}", TargetCount);
            //Console.WriteLine("\nEnter the value of which the occurance has to be determined");
            //int occurancetarget = Convert.ToInt32(Console.ReadLine());
            //problem.Problem3(A, occurancetarget);

            //Console.WriteLine("\nThe sum of the elements of the array");
            //problem.Problem4(A);
            //Console.WriteLine("\nThe biggest number and the smallest number:");
            //problem.Problem5(A);

            string[] strings = new string[n];
            Console.WriteLine("\nEnter the Names");

            for (int i=0;i<strings.Length;i++)
            {
                strings[i] = Console.ReadLine();

            }
            Console.WriteLine("\nEnter the value to be searched");
            string SearchName=Console.ReadLine();

            problem.Problem6(strings, SearchName);

        }
    }
}