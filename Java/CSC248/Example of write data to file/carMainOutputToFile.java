import java.util.Scanner;
import java.io.*;
import java.util.StringTokenizer;
import java.util.ArrayList;

public class carMainOutputToFile 
{
    public static void main(String args[]) throws IOException
    {
        File inputFile = new File("CarData.txt");//i)
        ArrayList <Car>carList = new ArrayList<Car>(); 
        
        
        try {
             Scanner inFile = new Scanner(inputFile); 
             while (inFile.hasNextLine()) {
                String s = inFile.nextLine(); 
                String delimiter = ";"; 
                StringTokenizer st = new StringTokenizer(s, delimiter);
                 
                String model = st.nextToken();
                double price = Double.parseDouble(st.nextToken());
                             
                Car c = new Car(model, price);
                carList.add(c);
              }
            }catch (Exception e)             
            {           
                System.out.println(e);       
            }
            
            //display all cars - tidak diperlukan dalam soalan
            System.out.println("\nAll Cars");
            System.out.println("\n==========");
        
            for(int i=0;i<carList.size();i++){
                System.out.print(carList.get(i).toString());
            }
                       
            //iv. Sort the car using bubble sort or insertion sort based on model
            //Sort the car using bubble sort or insertion sort based on model
            int n = carList.size();
            Car temp;
            for(int i = 0; i<n; i++)
            { 
                for(int j = 1; j<(n-i); j++)
                { 
                    Car carList1 = (Car)carList.get(j-1);
                    String model1 = carList1.getModel();
                    Car carList2 = (Car)carList.get(j);
                    String model2 = carList2.getModel();
                    if(model1.compareTo(model2)>0){
                        temp=carList1;
                        carList.set((j-1),carList2);
                        carList.set(j,temp);
                    }
                }
            }
            
            //v
            System.out.println("\n\nAll Cars (After Sort)");
            System.out.println("\n==========");
        
            for(int i=0;i<carList.size();i++){
                System.out.print(carList.get(i).toString());
            }
            
             PrintWriter pw = new PrintWriter(new FileWriter("CarDataAfterSort.txt"));
             for(int i=0;i<carList.size();i++){
                 Object obj   = carList.get(i);
                 Car c  = (Car) obj;
                 pw.write(c.toStringToFile());
            }
            pw.close();
            
        }
}