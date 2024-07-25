
/**
 * Write a description of class WatchMain5 here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.*;
import java.io.*;
import java.text.*;
public class WatchMain5
{
    public static void main (String args[])
    {
        ArrayList watchList = new ArrayList();
        
        //If it ask to format money for whatever reason lol
        //DecimalFormat df = new DecimalFormat("###.##");
        //System.out.println(df.format(324.324));
        
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
    
    
        /* for (int i = 0; i < watchList.size(); i++)
        {
            System.out.println(watchList.get(i).toString());
        } */
        
        /* ArrayList waterproofList = new ArrayList();
        ArrayList nonWaterproofList = new ArrayList();
        
         for (int i = 0; i < watchList.size(); i++)
        {
            Object w = watchList.get(i);
            Watch wa = (Watch) w;
            
            if (wa.getWaterproof())
            {
                waterproofList.add(wa);
                watchList.remove(i);
            }
            else
            {
                nonWaterproofList.add(wa);
            }
        } */
        
        // System.out.println("The size of waterproof list is " + waterproofList.size() + "\nThe size of not waterproof list is " + nonWaterproofList.size());
        
        /* for (int i = 0; i < watchList.size(); i++)
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
        } */
        
        
        //Bubble Sort Algorithm Method (my way) (not working)
        /* for (int i = 0; i < (watchList.size())-1; i++)
        {
            for (int index = 0; index < watchList.size()-(i+1); index++)
            {
                Object w = watchList.get(index);
                Watch wa = (Watch) w;
                
                Object wat = watchList.get(index + 1);
                Watch watc = (Watch) w;
                
                if (wa.getPrice() > watc.getPrice())
                {
                    watchList.set(index, watc);
                    watchList.set(index + 1, wa);
                }
            }
        } */
        
        //Bubble Sort Algorithm Method (madam's way)
        
        int n = watchList.size();
        Watch temp;
        for (int i = 0 ; i < n; i++)
        {
            for (int j=1;j<(n-1); j++)
            {
                Watch data1 = (Watch) watchList.get(j-1);
                double price1 = data1.getPrice();
                Watch data2 = (Watch) watchList.get(j);
                double price2 = data2.getPrice();
                
                if (price1 > price2)
                {
                    temp = data1;
                    watchList.set((j-1), data2);
                    watchList.set(j, temp);
                }
            }
        }
        
        for (int i = 0; i < watchList.size(); i++)
        {
            System.out.println(watchList.get(i).toString());
        } 
        
        
       
        //Insertion Sort Algorithm Method (my way incomplete)
        /* for (int i = 1; i < watchList.size(); i++ )
        {
            int currentElement = i;
            int index;
            for (index = i - 1; )
        } */
        
        //Insertion Sort (Madam's way)
        Watch wat1, wat2;
        for (int i = 1; i < watchList.size(); i++)
        { 
            wat1 = (Watch) watchList.get(i);
            String key = wat1.getCase();
            int j=i-1;
            wat2 = (Watch) watchList.get(j);
            String value2=wat2.getCase();
            while(j>=0 && value2.compareTo(key) > 0)
            { 
                watchList.set((j+1),wat2);
                j=j-1;
                if(j>=0)
                { 
                    wat2 = (Watch) watchList.get(j);
                    value2 = wat2.getCase();
                }
            }
            watchList.set((j+1),wat2);
        }
        
        for (int i = 0; i < watchList.size(); i++)
        {
            System.out.println(watchList.get(i).toString());
        } 
        
        //Binary Search (Madam's way)
        
        Watch wat;
        Scanner s = new Scanner(System.in);
        System.out.println("Input watch price:");
        double search = s.nextDouble();
        int low=0;
        int index=0;
        int high=watchList.size()-1;
        boolean isFound = false;
        int mid=-1;
        while(high >= low)
        { 
            mid = (low+high)/2;
            wat = (Watch) watchList.get(mid);
            if(search<wat.getPrice())
                high = mid - 1;
            else if(search == wat.getPrice())
            { 
                isFound = true;
                index = mid;
                break;
            }
            else
                low = mid + 1;
        }
        
        if(isFound)
        { 
            wat = (Watch) watchList.get(index);
            System.out.println("Details of watch price: RM"+search+"\n"+wat.toString());
        }
        else
            System.out.println("Sorry,the watch price of: RM"+search+" is NOT FOUND");
            
            
        //Binary Search Algorithm
        // int list[] = watchList
    } 
}
