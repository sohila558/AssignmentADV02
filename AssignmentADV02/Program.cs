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

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);

            Console.WriteLine("Original Queue:");
            foreach (int item in myQueue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ReverseQueue(myQueue);

            Console.WriteLine("Reversed Queue:");
            foreach (int item in myQueue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); 
            #endregion



        }
    }
}
