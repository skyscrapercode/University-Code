
/**
 * Write a description of class ClothesMainSHEIKHADAMBAJUNIDBINMOHDFAISAL here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.Scanner;
import java.io.File;
import java.util.StringTokenizer;
import java.util.ArrayList;
public class ClothesMainSHEIKHADAMBAJUNIDBINMOHDFAISAL
{
    public static void main (String args[])
    {
        //Question 1
        File inputFile = new File("ClothesData.txt");
        ArrayList clothesList = new ArrayList();
        
        try
        {
            Scanner in = new Scanner(inputFile);
            while (in.hasNextLine())
            {
                String s = in.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(s, delimiter);
                
                String b = st.nextToken();
                String si = st.nextToken();
                double p = Double.parseDouble(st.nextToken());
                
                Clothes Clothes = new Clothes(b,si,p);
                clothesList.add(Clothes);
            }
        }catch (Exception e)
        {
            System.out.println(e);
        }
        
        //Question 2
        System.out.println("All the information from clothes list:");
        for (int i = 0; i < clothesList.size(); i++)
        {
            System.out.println(clothesList.get(i).toString());
        }
        
        //Question 3
        double cheapestPrice = 9999;
        int indexCheapest = 0;
        for (int i = 0; i < clothesList.size(); i++)
        {
            Object obj = clothesList.get(i);
            Clothes c = (Clothes) obj;
            
            if (c.getPrice() < cheapestPrice)
            {
                cheapestPrice = c.getPrice();
                indexCheapest = i;
            }
        }
        
        System.out.println("The data of the cheapest clothes is: " + clothesList.get(indexCheapest).toString() );
        
        //Question 4
        int n = clothesList.size();
        Clothes temp;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Object obj = clothesList.get(j-1);
                Clothes c1 = (Clothes) obj;
                Object obj2 = clothesList.get(j);
                Clothes c2 = (Clothes) obj2;
                
                if (c1.getPrice() < c2.getPrice())
                {
                    temp = c1;
                    clothesList.set((j-1), c2);
                    clothesList.set(j, temp);
                }
            }
        }
        
        System.out.println("Data after bubble sort price in descending order:");
        for (int i = 0; i < clothesList.size(); i++)
        {
            System.out.println(clothesList.get(i).toString());
        }
        
        //Question 5
        Scanner input = new Scanner(System.in);
        System.out.println("Input price to search: RM");
        double search = input.nextDouble();
        int low = 0, mid = -1, high = clothesList.size() -1, index = 0;
        boolean isFound = false;
        
        while (high >= low)
        {
            mid = (low+high)/2;
            Object obj = clothesList.get(mid);
            Clothes c4 = (Clothes) obj;
            
            if (search > c4.getPrice())
            {
                high = mid - 1;
            }
            else if (search == c4.getPrice())
            {
                isFound = true;
                index = mid;
                break;
            }
            else
            {
                low = mid + 1;
            }
        }
        
        
        if (isFound)
        {
            System.out.println("How much would you like to update the price: RM");
            double priceUpdate = input.nextDouble();
            
            Object obj = clothesList.get(index);
            Clothes c = (Clothes) obj;
            
            c.setPrice(priceUpdate);
            clothesList.set(index, c);
            
            System.out.println("The record is updated");
        }
        else
        {
            System.out.println("Sorry, the record doesn't exist");
        }
        
        //Question 6
        ArrayList MList = new ArrayList();
        
        for (int i = 0; i < clothesList.size(); i++)
        {
            Object obj = clothesList.get(i);
            Clothes c = (Clothes) obj;
            
            if (c.getSize().equalsIgnoreCase("M"))
            {
                MList.add(clothesList.remove(i));
                i--;
            }
        }
        
        
    }
}
