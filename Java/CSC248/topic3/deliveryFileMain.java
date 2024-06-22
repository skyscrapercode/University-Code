import java.util.Scanner;
import java.io.File;
import java.util.StringTokenizer;

public class deliveryFileMain
{
    public static void main(String args[])
    {
        LinkedList deliveryLL = new LinkedList();
        File inputFile = new File("DeliveryMain.txt");
        
        Scanner s = new Scanner(System.in);
        //i)
        try{
            Scanner in = new Scanner(inputFile);
            while(in.hasNextLine())
            {
                String ss = in.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(ss,delimiter);
                
                String dn = st.nextToken();
                String pn = st.nextToken();
                String rn = st.nextToken();
                int tp = Integer.parseInt(st.nextToken());
                String p = st.nextToken();
                Delivery obj = new Delivery(dn,pn,rn,tp,p);
                
                deliveryLL.insertAtBack(obj);
                System.out.println(obj.toString());
            }
        }catch (Exception e)
        {
            System.out.println(e);
        }
        
        int i = 0, position;
        Object obj = deliveryLL.getFirst();
        while (obj != null)
        {
            Delivery d1 = (Delivery) obj;
            obj = deliveryLL.getNext();
            System.out.println("Number: " + i + "\n" + d1.toString());
            i++;
        }
        System.out.println("Which one would you like to remove?");
        position = s.nextInt();
        
        Object obj2 = deliveryLL.removeChosenNode(position);
        Delivery d2 = (Delivery) obj2;
        
        System.out.println("The node has been removed: " + d2.toString());
        
        //to check removed node
        i = 0;
        System.out.println("This is to checked that node is removed properly: ");
        Object obj3 = deliveryLL.getFirst();
        while (obj3 != null)
        {
            Delivery d3 = (Delivery) obj3;
            obj3 = deliveryLL.getNext();
            System.out.println("Number " + i + "\n" + d3.toString());
            i++;
        }
        
        //ii)
        /*
        String str = "Driver Name\tReceiver Name\tPhone Number";
        Object obj1 = deliveryLL.getFirst();
        while(obj1 != null)
        {
            Delivery tempD = (Delivery) obj1;
            
            if (tempD.getPlaceName().equalsIgnoreCase("Jasin Melaka"))
            {
                str += "\n" + tempD.getDriverName() + "\t\t" + tempD.getReceiverName() + "\t\t" + tempD.getPhoneNumber();
            }
            obj1 = deliveryLL.getNext();
        }
        
        System.out.println(str);
        
        obj1 = deliveryLL.getFirst();
        boolean found = false;
        LinkedList smallBudget = new LinkedList();
        while(obj1 != null)
        {
            Delivery tempD = (Delivery) obj1;
            if(tempD.getTotalPrice() < 100)
            {
                found = true;
                deliveryLL.removeFromFront();
                smallBudget.insertAtBack(tempD);
            }
            obj1 = deliveryLL.getNext();
        }
        if(found)
        {
            System.out.println("Record has been added");
        }
        else
        {
            System.out.println("The record is not found");
        }
        
        */
    }
}
