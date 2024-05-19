
/**
 * Write a description of class WatchMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.*;
public class WatchMain
{
    public static void main(String args[])
    {
        ArrayList<String> arrList = new ArrayList<String>();
    
        
        Scanner s = new Scanner(System.in);
        
        System.out.println("How many watch data would you like to input?");
        int arraySize = s.nextInt();
        
        Watch watch[]  = new Watch[arraySize];
        
        for (int i = 0; i < watch.length; i++)
        {
            System.out.println("Choose your case material: \n1. Stainless Steel \n2. Titanium");
            int c = s.nextInt();
            String material;
            if (c == 1)
                material = "Stainless Steel";
            else
                material = "Titanium";    
            
            System.out.println("You've selected: " + material );
            
            System.out.println("Choose your type of glass: \n1. Sapphire \n2. Crystal \n3. mineral_glass");
            int t = s.nextInt();
            String gType;
            if (t == 1)
                gType = "Sapphire";
            else if (t == 2)
                gType = "Crystal";
            else
                gType = "mineral_glass";
            
            System.out.println("You've selected: " + gType );    
                
            System.out.println("Is it waterproof? \n1. Yes \n2. No");
            int w = s.nextInt();
            boolean wp;
            if (w == 1)
                wp = true;
            else
                wp = false;
            
            System.out.println("You've selected: " + wp );    
                
            System.out.println("Choose your watch strap: \n1. Rubber \n2. Leather \n3. Bracelet");
            int st = s.nextInt();
            String ws;
            if (st == 1)
                ws = "Rubber";
            else if (st == 2)
                ws = "Leather";
            else
                ws = "Bracelet";
            
            System.out.println("You've selected: " + ws );    
                
            System.out.println("How much does it cost? RM: ");
            double price = s.nextDouble();
            
            System.out.println("You've input: RM" + price );
            
            watch[i] = new Watch(material, gType, wp, ws, price);
            arrList.add(watch[i]);
            
            System.out.println("Current Array List Length/Size is: " + arrList.size());
        }
        
        /* for (int i = 0; i < watch.length; i++)
        {
            System.out.println("\nHere is the details of watch " + (i + 1));
            System.out.println(watch[i].toString());
        } */
        
        int searchTerm;
        
        do
        {
            System.out.println("What would you like to search for? \n1. Material \n2. Type of glass \n3. Waterproof \n4. Strap");
            searchTerm = s.nextInt();
            
            if (searchTerm == 1)
            {
                System.out.println("What material are you looking for?");
                String materialName = s.nextLine();
                for (int i = 0; i < arrList.size(); i++)
                {
                    arrList.get(i); 
                    if (watch[i].getCase().equalsIgnoreCase(materialName))
                    {
                        
                    }
                }
            }
            else if (searchTerm == 2)
            {
                System.out.println("What type of glass are you looking for?");
            }
            else if (searchTerm == 3)
            {
                System.out.println("Waterproof or not? (yes/no)");
            }
            else if (searchTerm == 4)
            {
                System.out.println("What Strap are you looking for?");
                
            }
            else
            {
                System.out.println("Wrong Input Please Try Again!");
            }
        }while (searchTerm < 1 || searchTerm > 4);
        
        
    }
}
