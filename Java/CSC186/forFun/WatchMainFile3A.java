import java.util.Scanner;
import java.io.File;            //new statement
import java.util.StringTokenizer;

public class WatchMainFile3A
{
    public static void main(String arg[]){
         File inputFile = new File("WatchData.txt");            
                     
         Watch[] watchArr = new Watch[10];
         int i=0;

         //get input data from file
         try {
             Scanner inFile = new Scanner(inputFile); 
             while (inFile.hasNextLine()) {
                String s = inFile.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(s, delimiter);
                 
                //read from s using st
                String case_material = st.nextToken();
                String glass_type = st.nextToken();
                boolean waterproof = Boolean.parseBoolean(st.nextToken());
                String watch_strap = st.nextToken();
                double price = Double.parseDouble(st.nextToken());
                             
                Watch w = new Watch(case_material,glass_type,waterproof, watch_strap, price);
                watchArr[i] = w;
                i++;
              }
            }catch (Exception e)             
            {                                
                System.out.println(e);       
            }                                
        
        //display data in arraylist
        System.out.println("\nAll Watch Records");
        System.out.println("\n=================");
        for(int j=0;j<i;j++)
        { 
            System.out.println(watchArr[j].toString());
        }
    }
}
