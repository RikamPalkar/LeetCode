using Add_Two_Numbers;

public class Program
{
    static public void Main()
    {
        // creating first list
        ListNode l1 = new(2)
        {
            next = new ListNode(4)
            {
                next = new ListNode(3) { }
            }
        };
        //Printing list 1
        PrintListNode(l1);


        // creating second list
        ListNode l2 = new(5)
        {
            next = new ListNode(6)
            {
                next = new ListNode(4) { }
            }
        };
        //Printing list 2
        PrintListNode(l2);

        //Creating an instance of an class which contains the logic
        ListNodeAddition listNodeAddition = new();
        ListNode addedNodes = listNodeAddition.AddTwoNumbers(l1, l2);
        PrintListNode(addedNodes);
    }

    /// <summary>
    /// This method prints all the elements in the singly linked list
    /// </summary>
    /// <param name="head"></param>
    static void PrintListNode(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine("");
    }
}




