namespace StackImplementation
{
    /*Ability to create a Stack of
            56->30->70
            - Use LinkedList to do the Stack Operations
            - Here push will internally call add method on LinkedList.
            - So 70 will be added first then 30 and then 56 to make 56 on top of the Stack
     */

    /*Ability to peak and pop from the Stack till it is empty
     * 56 ->30 ->70

        - Use LinkedList to do the Stack Operations
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Top element of the stack: " + stack.Peek());

            Console.WriteLine("Elements in the stack:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}