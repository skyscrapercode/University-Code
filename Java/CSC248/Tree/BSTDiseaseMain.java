import java.util.Scanner;
import java.io.*;
import java.util.StringTokenizer;
import java.util.ArrayList;

public class BSTDiseaseMain 
{
    public static void main(String args[])
    {
        File inputFile = new File("DiseaseData.txt");
        BSTDisease tree = new BSTDisease();
        Scanner input = new Scanner(System.in);
        
        try {
             Scanner inFile = new Scanner(inputFile); 
             while (inFile.hasNextLine()) {
                String s = inFile.nextLine(); 
                String delimiter = ";"; 
                StringTokenizer st = new StringTokenizer(s, delimiter);
                 
                String dn = st.nextToken();
                double p = Double.parseDouble(st.nextToken());
                int y = Integer.parseInt(st.nextToken());
                
                Disease D = new Disease(dn,p,y);
                tree.insertNode(D);
              }
            }catch (Exception e)             
            {           
                System.out.println(e);       
            }
            
        System.out.println("All Data");    
        tree.printAll();
        
        System.out.println("Display the details of disease with more than 10%");
        tree.printBySpecific();
        
        System.out.println("Input Year: ");
        int year = input.nextInt();
        tree.calTotByYear(year);
        
        input.nextLine();
        
        System.out.println("Input Disease Name: ");
        String dName = input.nextLine();
        System.out.println(" The total percent of " + dName + " disease death is " + tree.calByDisease(dName) + "%");
    }
}