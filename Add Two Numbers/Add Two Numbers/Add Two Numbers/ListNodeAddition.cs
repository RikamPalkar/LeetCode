namespace Add_Two_Numbers
{
    internal class ListNodeAddition
    {
        /// <summary>
        /// LeetCode have l1 and l2 as parameter's name, I am using currentNodeList1 to represent current node of list 1 
        /// currentNodeList2 to represent current node of list 2 
        /// </summary>
        /// <param name="currentNodeList1"></param>
        /// <param name="currentNodeList2"></param>
        /// <returns>List node of addition of list1 and list 2</returns>
        public ListNode AddTwoNumbers(ListNode currentNodeList1, ListNode currentNodeList2)
        {        
            // This is the list the method will return
            ListNode resultantList = null;

            // Reference of resultantList, we are going to use this to determine if resultant list's head node and managing it's next nodes
            ListNode resultantTempList = null;

            ListNode newNode = null;
            // carry to hold value if sum > 10
            int carry = 0;

            // 2 pointers as we mentioned in the algorithm
            while (currentNodeList1 != null || currentNodeList2 != null)
            {
                // next iteration might bring a carry with it, which we need to be added into the sum.
                int sum = carry;

                // Both lists don't necessarily have to be of same lengths, So if there is a node then we will add then we will simply skip.

                // current pointer of list 1 is not null, update the sum, and point current pointer to next node.
                if (currentNodeList1 != null)
                {
                    sum += currentNodeList1.val;
                    currentNodeList1 = currentNodeList1.next;
                }

                // current pointer of list 2 is not null, update the sum, and point current pointer to next node.
                if (currentNodeList2 != null)
                {
                    sum += currentNodeList2.val;
                    currentNodeList2 = currentNodeList2.next;
                }

                // we need to calculate the remainder and make a new link list node.
                // You don't necessarily need to create a variable to hold the value of remainder, this just makes code easy to read.
                int remainder = sum % 10;
                newNode = new(remainder);

                // As per our algorithm we need to take carry with us for the next iteration. result of division will give us the value of carry
                carry = sum / 10;


                // if this is the first node then set it as head
                if (resultantTempList == null)
                {
                    resultantTempList = resultantList = newNode;
                }

                // If this is not the first node then adding node to the next
                else
                {
                    // Adding next node of the temp list, And since it has been referenced by our resultant list
                    // resultant list next element will automatically be updated. We are not referring resultant list anywhere
                    // so current node is the last one, so for third iteration it will be next.next 
                    resultantTempList.next = newNode;

                    //Set temp list for next insertion
                    resultantTempList = resultantTempList.next;
                }
            }
            // When there is no node left in either of the list to iterate but we have left with a carry from last iteration
            // We need to create a new node to store the value.
            if (carry > 0)
            {
                resultantTempList.next = new ListNode(carry);
            }

            // simply return the resultant list
            return resultantList;
        }
    }

}
