
/**
 * Write a description of class WatchMain1 here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;

public class WatchMain1
{
    public static void main(String args[])
    {
        ArrayList watchArr = new ArrayList();
        Scanner inputText = new Scanner(System.in);
        
        for(int i=0;i<2;i++)
        {
            System.out.println("Enter case material");
            String case_material = inputText.nextLine();
            System.out.println("Enter glass type");
            String glass_type = inputText.nextLine();
            System.out.println("Waterproof(true/false)?");
            boolean waterproof = inputText.nextBoolean();
            System.out.println("Enter watch strap:");
            String watch_strap = inputText.next();
            System.out.println("Enter price:");
            double price = inputText.nextDouble();
            
            inputText.nextLine();
            
            Watch watch = new Watch(case_material, glass_type, waterproof, watch_strap, price);
            watchArr.add(watch);
        }
        
        for (int i = 0; i < watchArr.size(); i++)
        {
            System.out.println(watchArr.get(i).toString());
        }
        
        ArrayList waterproofList = new ArrayList();
        ArrayList nonWaterproofList = new ArrayList();
        
        for (int i = 0; i < watchArr.size(); i++)
        {
            Object w = watchArr.get(i);
            Watch wa = (Watch) w;
            if (wa.getWaterproof())
            {
                waterproofList.add(wa);
            }
            else
            {
                nonWaterproofList.add(wa);
            }
            
        }
        
        System.out.println("The size of waterproof list is " + waterproofList.size() + "\nThe size of not waterproof list is " + nonWaterproofList.size());
        
        for (int i = 0; i < watchArr.size(); i++)
        {
            Object w = watchArr.get(i);
            Watch wa = (Watch) w;
            if (wa.getStrap().equalsIgnoreCase("leather"))
            {
                System.out.println(wa.toString());
            }
        }
        
        double total = 0;
        
        for (int i = 0; i < waterproofList.size(); i++)
        {
            Object w = waterproofList.get(i);
            Watch wa = (Watch) w;
            
            total += wa.getPrice();
        }
        
        System.out.println("Total price of all watches in waterproof list is: RM" + total);
        
        boolean search = false;
        for (int i = 0; i < waterproofList.size(); i++)
        {
            Object w = waterproofList.get(i);
            Watch wa = (Watch) w;
            
            if (wa.getGlass().equalsIgnoreCase("crystal") && wa.getCase().equalsIgnoreCase("titanium"))
            {
                System.out.println(wa.toString());
                search = true;
            }
        }
        
        if (!search)
        {
            System.out.println("item does not exist in search");
        }
        
    }
}
