
/**
 * Write a description of class DeliveryMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.Scanner;
import java.util.StringTokenizer;
import java.io.File;

public class DeliveryMain2
{
    public static void main (String args[])
    {
        //Question i.
        Scanner s = new Scanner(System.in);
        LinkedList deliveryLL = new LinkedList();
        
        File inputFile = new File("DeliveryMain.txt");
        
        try {
            Scanner inFile = new Scanner(inputFile);
            while (inFile.hasNextLine())
            {
                String line = inFile.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(line, delimiter);
                
                String dn = st.nextToken();
                String pn = st.nextToken();
                String rn = st.nextToken();
                int tp = Integer.parseInt(st.nextToken());
                String n = st.nextToken();
                
                Delivery d = new Delivery(dn,pn,rn,tp,n);
                deliveryLL.insertAtBack(d);
            }
        }catch (Exception e)
        {
            System.out.println(e);
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
        
        obj = deliveryLL.removeFromFront();
        boolean found = false;
        while (deliveryLL.isEmpty())
        {
            Delivery tempD = (Delivery) obj;
            if(tempD.getTotalPrice() < 100)
            {
                found = true;
                smallBudget.insertAtBack(tempD);
            }
            obj = deliveryLL.removeFromFront();
        }
        
        
        
        
        if (found)
            System.out.println("Record has been added");
        else
            System.out.println("The record is not found");
        
       



    }
}