using Queue;
using QueueUsingTwoStack;

public class Program
{
    public static void Main(string[] args)
    {
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("*****************************");
        //    Console.WriteLine("$$ Queue implementation Using Array $$");
        //    Console.WriteLine("*****************************");
        //    Console.ForegroundColor = ConsoleColor.White;


        //    Console.WriteLine("Enter the size of the Queue");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    string userSelection;
        //    QueueUsingArrays s1 = new QueueUsingArrays(size);
        //    do
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;

        //        Console.WriteLine("************");
        //        Console.WriteLine("## Select an action ##");
        //        Console.WriteLine("************");
        //        Console.ForegroundColor = ConsoleColor.White;

        //        Console.WriteLine("1. Insert Element");
        //        Console.WriteLine("2. Delete Element");
        //        Console.WriteLine("3. See the First value");
        //        Console.WriteLine("4. See All Elements of the Stack");
        //        Console.WriteLine("9. Quit Application");

        //        userSelection = Console.ReadLine();

        //        switch (userSelection)
        //        {
        //            case "1":
        //                Console.WriteLine("Enter the element to insert: ");
        //                int data = Convert.ToInt32(Console.ReadLine());
        //                s1.Enqueue(data);
        //                Console.WriteLine("Element Added:");
        //                break;

        //            case "2":
        //                s1.Dequeue();
        //                Console.WriteLine("Element Deleted:");
        //                break;

        //            case "3":
        //                Console.WriteLine("First value is: ");
        //                s1.getFront();
        //                break;

        //            case "4":
        //                s1.Display();
        //                break;

        //            case "9":
        //                break;


        //            default:
        //                Console.WriteLine("Invalid selcection... Try Again!!!!");
        //                break;
        //        }
        //    }
        //    while (userSelection != "9");
        //    Console.WriteLine("Thanks for using the application");
        //    Console.Read();
        //}


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*****************************");
        Console.WriteLine("$$ Queue implementation Using Stack $$");
        Console.WriteLine("*****************************");
        Console.ForegroundColor = ConsoleColor.White;


        QueueUsingStack s1 = new QueueUsingStack();
        string userSelection;
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("************");
            Console.WriteLine("## Select an action ##");
            Console.WriteLine("************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Insert Element in Queue");
            Console.WriteLine("2. Delete Element in Queue");
            Console.WriteLine("3. See the top value present in the Queue");
            Console.WriteLine("4. See All Elements of the Stack");
            Console.WriteLine("9. Quit Application");

            userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("Enter the element to insert: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    s1.Push(data);
                    break;

                case "2":
                    s1.Pop();
                    break;

                case "3":
                    s1.Peek();
                    break;

                case "4":
                    s1.Display();
                    break;

                case "9":
                    break;

                default:
                    Console.WriteLine("Invalid selcection... Try Again!!!!");
                    break;
            }
        }
        while (userSelection != "9");
        Console.WriteLine("Thanks for using the application");
        Console.Read();
    }
}
