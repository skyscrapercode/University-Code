
/**
 * Write a description of class WatchMain2 here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.*;
import java.io.*;
public class WatchMain2
{
    public static void main (String args[])
    {
        ArrayList watchList = new ArrayList();
        
        try{
            File f = new File("WatchData.txt");
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String line = "";
            while ((line = br.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer(line, ";");
                String cm = st.nextToken();
                String gt = st.nextToken();
                boolean w = Boolean.parseBoolean(st.nextToken());
                String ws = st.nextToken();
                double price = Double.parseDouble(st.nextToken());
                
                Watch watch = new Watch(cm, gt, w, ws, price);
                watchList.add(watch);
            }
        }catch (Exception e)
        {
            System.out.println(e);
        }
    
    
        for (int i = 0; i < watchList.size(); i++)
        {
            System.out.println(watchList.get(i).toString());
        }
        
        ArrayList waterproofList = new ArrayList();
        ArrayList nonWaterproofList = new ArrayList();
        
        for (int i = 0; i < watchList.size(); i++)
        {
            Object w = watchList.get(i);
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
        
        for (int i = 0; i < watchList.size(); i++)
        {
            Object w = watchList.get(i);
            Watch wa = (Watch) w;
            
            if (wa.getStrap().equalsIgnoreCase("leather"))
            {
                System.out.println(wa.toString() + "\n");
            }
        }
        
        double total = 0;
        
        for (int i = 0; i < waterproofList.size(); i++)
        {
            Object w = waterproofList.get(i);
            Watch wa = (Watch) w;
            
            total += wa.getPrice();
        }
        
        System.out.println("The total price of all watches that are waterproof is: RM" + total);
        
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
            System.out.println("item made of titanium, crystal and is waterproof does not exist in search");
        }
    }
}
