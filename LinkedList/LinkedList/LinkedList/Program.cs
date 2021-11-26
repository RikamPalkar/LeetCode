/*
 * This information is taken from GeeksforGeeks.org *
 A LinkedList is a linear data structure which stores element in the non-contiguous location. 
 The elements in a linked list are linked with each other using pointers. 
 Or in other words, LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.
 In C#, LinkedList is the generic type of collection which is defined in System.Collections.Generic namespace. 
 It is a doubly linked list, therefore, each node points forward to the Next node and backward to the Previous node. 
 It is a dynamic collection which grows, according to the need of your program. It also provides fast inserting and removing elements.
 */

/*
    1. If the LinkedList is empty, the First and Last properties contain null.
    2. The capacity of a LinkedList is the number of elements the LinkedList can hold.
    3. In LinkedList, it is allowed to store duplicate elements but of the same type.
*/

// C# program to illustrate how 
// to create a LinkedList
using System;
using System.Collections.Generic;

class GFG
{

    // Main Method
    static public void Main()
    {

        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> my_list = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("10");
        my_list.AddLast("9");
        my_list.AddLast("8");
        my_list.AddLast("7");
        my_list.AddLast("6");
        my_list.AddLast("5");
        var third = my_list.AddFirst("3");
        my_list.AddAfter(third, "4");
        my_list.AddBefore(my_list.AddFirst("2"), "1");
        Console.WriteLine("Numbers:");

        // Accessing the elements of 
        // LinkedList Using foreach loop
        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
    }
}