using System.Collections;
using System.Collections.Generic;

namespace AssignmentADV02
{
    internal class Program
    {
        #region Q01
        //static int FirstGreater(int[] arr, int x)
        //{
        //    int left = 0, right = arr.Length - 1;
        //    int result = arr.Length;

        //    while (left <= right)
        //    {
        //        int mid = (left + right) / 2;
        //        if (arr[mid] > x)
        //        {
        //            result = mid;
        //            right = mid - 1;
        //        }
        //        else
        //        {
        //            left = mid + 1;
        //        }
        //    }

        //    return result;
        //} 
        #endregion

        #region Q02
        static bool IsPalindrome<T>(T[] array)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (!comparer.Equals(array[i], array[n - 1 - i]))
                    return false;
            }
            return true;
        }
        #endregion

        #region Q03
        public static void ReverseQueue<T>(Queue<T> queue)
        {
            if (queue == null)
            {
                Console.WriteLine("Queue cannot be null.");
            }

            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Q04
        static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if (!IsMatching(top, ch))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        static bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
        #endregion

        #region Q06
        static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((int)list[i] % 2 != 0)
                    list.RemoveAt(i);
            }
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Q01
            /*1. Given an array  consists of  numbers with size N and number of queries,
                 * in each query you will be given an integer X, and you should print how many numbers
                 * in array that is greater than X.*/

            //int[] arr = { 11, 5, 3 };
            //Array.Sort(arr); 

            //int[] queries = { 1, 5, 13 };

            //foreach (int x in queries)
            //{
            //    int index = FirstGreater(arr, x); 
            //    int count = arr.Length - index;
            //    Console.WriteLine($"{x} = {count}");
            //}

            #endregion

            #region Q02

            // 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.Write("Enter N: ");
            //int N = int.Parse(Console.ReadLine());

            //string[] arr = new string[N];
            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}

            //if (IsPalindrome(arr))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q03

            // 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> myQueue = new Queue<int>();
            //myQueue.Enqueue(10);
            //myQueue.Enqueue(20);
            //myQueue.Enqueue(30);
            //myQueue.Enqueue(40);

            //Console.WriteLine("Original Queue:");
            //foreach (int item in myQueue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //ReverseQueue(myQueue);

            //Console.WriteLine("Reversed Queue:");
            //foreach (int item in myQueue)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q04

            // 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string input;
            //while (true)
            //{
            //    Console.Write("Enter a string of parentheses: ");
            //    input = Console.ReadLine();

            //    if (!string.IsNullOrWhiteSpace(input))
            //        break;

            //    Console.WriteLine("Input cannot be empty. Please try again.");
            //}

            //bool isBalanced = IsBalanced(input);

            //if (isBalanced)
            //    Console.WriteLine("The parentheses are balanced.");
            //else
            //    Console.WriteLine("The parentheses are not balanced.");
            #endregion

            #region Q05
            // 5. Given an array, implement a function to remove duplicate elements from an array.

            //Console.Write("Enter array size: ");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //    Console.Write("Invalid! Enter positive size: ");

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //        Console.Write("Invalid! Enter a number: ");
            //}

            //Console.WriteLine("\nArray after removing duplicates:");
            //for (int i = 0; i < size; i++)
            //{
            //    bool isDuplicate = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            isDuplicate = true;
            //            break;
            //        }
            //    }
            //    if (!isDuplicate)
            //        Console.Write(arr[i] + " ");
            //}

            #endregion

            #region Q06
            // 6. Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList numbers = new ArrayList();

            //Console.Write("Enter number of elements: ");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //    Console.Write("Invalid! Enter a positive number: ");

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    int num;
            //    while (!int.TryParse(Console.ReadLine(), out num))
            //        Console.Write("Invalid! Enter a number: ");
            //    numbers.Add(num);
            //}

            //RemoveOddNumbers(numbers);

            //Console.WriteLine("\nArrayList after removing odd numbers:");
            //foreach (var item in numbers)
            //    Console.Write(item + " ");

            #endregion

            #region Q07
            /*7. Implement a queue that can hold different data types. 
                     And insert the following data:
                     queue.Enqueue(1)
                     queue.Enqueue(“Apple”)
                     queue.Enqueue(5.28)     */

            //Queue myQueue = new Queue();

            //myQueue.Enqueue(1);         
            //myQueue.Enqueue("Apple");   
            //myQueue.Enqueue(5.28);      

            //Console.WriteLine("Queue elements:");

            //foreach (var item in myQueue)
            //    Console.WriteLine(item);

            #endregion

            #region Q08
            /*8. Create a function that pushes a series of integers onto a stack.
               * Then, search for a target integer in the stack. If the target is found,
               * print a message indicating that the target was found how many elements were checked before finding the target
               * (“Target was found successfully and the count = 5”). If the target is not found,
               * print a message indicating that the target was not found(“Target was not found”).
                 Note : take the target as input from the user */

            //Stack<int> stack = new Stack<int>();


            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //Console.Write("Enter target number: ");
            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;

            //foreach (var item in stack)
            //{
            //    count++;
            //    if (item == target)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(found? $"Target was found successfully and the count = {count}": "Target was not found");

            #endregion

            #region Q09

            // 9. Given two arrays, find their intersection. Each element in the result should appear
            // as many times as it shows in both arrays.

            //int[] arr1 = { 1, 2, 2, 3, 4 };
            //int[] arr2 = { 2, 2, 3, 5 };

            //List<int> result = new List<int>();
            //bool[] used = new bool[arr2.Length]; 

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (!used[j] && arr1[i] == arr2[j])
            //        {
            //            result.Add(arr1[i]);
            //            used[j] = true; 
            //            break;
            //        }
            //    }
            //}

            #endregion

            #region Q10

            // 10. Given an ArrayList of integers and a target sum, find if there is a contiguous
            // sub list that sums up to the target.



            #endregion

            #region Q11

            // 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order.


            #endregion




        }
    }
}
