
/**
 * Write a description of class PhotoPrintsMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;
import java.io.*;
public class PhotoPrintsMain
{
    public static void main (String[] args)
    {
        ArrayList<PhotoPrints> printList = new ArrayList<PhotoPrints>();
        
        File inputFile = new File("PhotoData.txt");
        
        try {
             Scanner inFile = new Scanner(inputFile); 
             while (inFile.hasNextLine()) {
                String s = inFile.nextLine(); 
                String delimiter = ";"; 
                StringTokenizer st = new StringTokenizer(s, delimiter);
                 
                String method = st.nextToken();
                char paperType = st.nextToken().charAt(0);
                int photoSize = Integer.parseInt(st.nextToken());
                int quantity = Integer.parseInt(st.nextToken());
                             
                PhotoPrints c = new PhotoPrints(method,paperType, photoSize, quantity);
                printList.add(c);
              }
            }catch (Exception e)             
            {           
                System.out.println(e);       
            }
        
        /* Scanner s = new Scanner(System.in);
        for (int i = 0; i < 1; i++)
        {
            System.out.println("Method:");
            String m = s.nextLine();
            System.out.println("Type of paper:");
            char pt = s.nextLine().charAt(0);
            System.out.println("Size of photo:");
            int ps = Integer.parseInt(s.nextLine());
            System.out.println("Quantity:");
            int q = Integer.parseInt(s.nextLine());
            
            PhotoPrints print = new PhotoPrints(m, pt, ps, q);
            printList.add(print);
            
        }
        */
       
        System.out.println("\nAll PhotoPrint");
        System.out.println("\n==========");
        for (int i = 0; i < printList.size(); i++)
        {
            System.out.println(printList.get(i).toString());
        }
        
        
        //ii
        int count = 0;
        for (int i = 0; i < printList.size(); i++)
        {
            if (printList.get(i).getPhotoSize() == 11)
            {
                count += printList.get(i).getQuantity();
            }
        }
        
        System.out.println("The number of photo prints with the size of 11R is: " + count);
        
        //iii
        ArrayList <PhotoPrints> classicList = new ArrayList<PhotoPrints>();
        ArrayList <PhotoPrints> digitalList = new ArrayList<PhotoPrints>();
        
        for (int i = 0; i < printList.size(); i++)
        {
            if (printList.get(i).getMethod().equalsIgnoreCase("classic"))
            {
                classicList.add(printList.get(i));
                printList.remove(i);
            }
            else
            {
                digitalList.add(printList.get(i));
                printList.remove(i);
            }
            i--;
        }
        
        System.out.println(classicList.toString());
        System.out.println(digitalList.toString());
        
        int totalQuantity = 0;
        for (int i = 0; i < classicList.size(); i++)
        {
            if (classicList.get(i).getPaperType() == 'G')
            {
                totalQuantity += classicList.get(i).getQuantity();
            }
        }
        
        System.out.println("The total quantity of classic prints using gloss paper type: " + totalQuantity); 
        
    }
}
