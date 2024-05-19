
/**
 * Write a description of class MotivatorMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.Scanner;
public class MainMotivator
{
    public static void main (String args[])
    {
        Queue motivatorQ = new Queue();
        
        Scanner in = new Scanner(System.in);
        
        for (int i = 0; i < 10; i++)
        {
            System.out.println("What is your motivator ID:");
            String m = in.nextLine();
            System.out.println("What is your motivator Name:");
            String n = in.nextLine();
            System.out.println("What is your faculty: ");
            String f = in.nextLine();
            System.out.println("What is your program code:");
            String c = in.nextLine();
            System.out.println("What is your marks:");
            double mk = in.nextDouble();
            
            Motivator mo = new Motivator(m,n,f,c,mk);
            
            motivatorQ.enqueue(mo);
        }
        
        int count = 0;
        Queue qTemp = new Queue();
        while (!motivatorQ.isEmpty())
        {
            Object obj = motivatorQ.dequeue();
            Motivator mo = (Motivator) obj;
            qTemp.enqueue(mo);
            
            if (mo.getProgramCode().startsWith("CS"))
            {
                count++;
            }
            
        }
        
        while (!qTemp.isEmpty())
        {
            motivatorQ.enqueue(qTemp.dequeue());
        }
        
        System.out.println("Number of CS motivators: " + count);
    }
}
