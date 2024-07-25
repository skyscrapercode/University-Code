
/**
 * Write a description of class DeliveryMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.Scanner;
public class DeliveryMain
{
    public static void main (String args[])
    {
        //Question i.
        Scanner s = new Scanner(System.in);
        LinkedList deliveryLL = new LinkedList();
        
        for (int i = 0; i < 20; i++)
        {
            System.out.println("Driver Name:");
            String dn = s.nextLine();
            System.out.println("Place Name:");
            String pn = s.nextLine();
            System.out.println("Receiver Name:");
            String rn = s.nextLine();
            System.out.println("Total Price: RM");
            int tp = s.nextInt();
            System.out.println("Phone Number: ");
            String n = s.nextLine();
            
            Delivery d = new Delivery(dn,pn,rn,tp,n);
            deliveryLL.insertAtBack(d);
        }
        
        
        //Question ii.
        String str = "Driver Name  Receiver Name  Phone Number";
        Object obj = deliveryLL.getFirst();
        while(obj != null)
        {
            Delivery tempD = (Delivery) obj;
            
            if (tempD.getPlaceName().equalsIgnoreCase("Jasin Melaka"))
            {
                str += "\n" + tempD.getDriverName() + "  " + tempD.getReceiverName() + "  " + tempD.getPhoneNumber();
            }
            obj = deliveryLL.getNext();
        }
        
        System.out.println(str);
        
        
        //Question iii.
        LinkedList smallBudget = new LinkedList();
        LinkedList tempLL = new LinkedList();
        
        Object obj2 = deliveryLL.removeFromBack();
        boolean found = false;
        while (!deliveryLL.isEmpty())
        {
            Delivery tempD = (Delivery) obj2;
            if(tempD.getTotalPrice() < 100)
            {
                smallBudget.insertAtBack(obj2);
                found = true;
            }
            else
            {
                tempLL.insertAtBack(obj2);
            }
            obj2 = deliveryLL.removeFromBack();
        }
        
        
        
        while (!tempLL.isEmpty())
        {
            obj = tempLL.removeFromBack();
            deliveryLL.insertAtBack(obj);
        }
        
        if (found)
            System.out.println("Record has been added");
        else
            System.out.println("The record is not found");
        
       

    }
}
