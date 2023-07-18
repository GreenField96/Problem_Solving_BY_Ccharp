
using System.Security.Cryptography;

public class ListNode{
      public int val;

    public void setVal(int val){
        this.val = val;
    }
    public int getVal() {
        return val;
    }

    public ListNode next;

      public ListNode(int val = 0, ListNode next = null){
        this.val = val;
        this.next = next;
       }
 }

internal class Program{
    private static unsafe void Main(string[] args){

        Console.WriteLine("inter value for insert to List & 0 to exit : ");
        int digit = Convert.ToInt32(Console.ReadLine());

        ListNode l1 = new ListNode(digit,  null);
        ListNode l2 = new ListNode(digit*2,null);
        ListNode h1 = l1;
        ListNode h2 = l2;

        while (digit != 0) {
            Console.WriteLine("inter value for insert to List & 0 to exit : ");
            digit = Convert.ToInt32(Console.ReadLine());

            ListNode temp = new ListNode(digit, null);
            l1.next = temp;
            l1 = l1.next;

            temp = new ListNode((digit * 2), null);
            l2.next = temp;
            l2 = l2.next;            
        }

        Console.WriteLine("print list-1");
        printNodes(h1);
        Console.WriteLine("print list-2");
        printNodes(h2);

        ListNode h3 = AddTwoNumbers(h1,h2);
        Console.WriteLine("print Collect of two prevuse list");
        printNodes(h3);
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) {
        
            if (l1 == null && l2 == null && carry == 0) return null;

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        // solution from leetCode

        /*
        int count = 0 , digit = 0;

        digit = (l1.val + l2.val) > 9 ? (l1.val + l2.val) - 10 : (l1.val + l2.val);
        ListNode l3 = new ListNode(digit, null);
        ListNode h3 = l3;
        
        l1 = l1.next;
        l2 = l2.next;

        while (l1 != null & l2 != null)
        {
            digit = (l1.val + l2.val) > 9 ? (l1.val + l2.val) - 10 : (l1.val + l2.val);

            ListNode temp = new ListNode(digit, null);
            l3.next = temp;
            l3 = l3.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        return h3;
        */
    }
    public static void printNodes(ListNode Nod)
    {
        while(Nod != null)
        {
            Console.WriteLine(Nod.val);
            Nod = Nod.next;
        }
    }

    public static unsafe void swapp(int* x, int* y){
        *x ^= *y;
        *y ^= *x;
        *x ^= *y;
    }
   
}