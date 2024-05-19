
/**
 * Write a description of class CarMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.text.*;
import java.io.*;
import java.util.*;
public class CarMain
{
    public static void main (String args[])
    {
        DecimalFormat df = new DecimalFormat("#####.##");
        
        // i. read CarData.txt, put into car class and add to carList ArrayList
        ArrayList <Car> carList = new ArrayList<Car>();
        
        try {
            File f = new File("CarData.txt");
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String line = "";
            
            while ((line = br.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer(line, ";");
                String model = st.nextToken();
                double price = Double.parseDouble(st.nextToken());
                
                Car car = new Car(model, price);
                carList.add(car);
            }
        }catch (Exception e)
        {
            System.out.println(e);
        }
        
        //ii. Calc total and average price for all car
        double total = 0, averagePrice = 0;
        for (int i = 0; i < carList.size(); i++)
        {
            Car c = carList.get(i);
            total += c.getPrice();
            averagePrice = total / carList.size();
        }
        
        System.out.println("The total of all car is RM" + total + "\nThe average price of all cars is RM" + df.format(averagePrice));
        
        //iii. Displaying the current list
        for (int i = 0; i < carList.size(); i++)
        {
            System.out.println(carList.get(i).toString()); // The reason this works is because all classes e.g. ArrayList inherit class object the blueprint for all classes
        }
        
        //iv. pt 1 Sort the car using bubble sort based on model
        /*
        int n = carList.size();
        Car temp;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Car c1 = carList.get(j-1);
                Car c2 = carList.get(j);
                
                if (c1.getModel().compareTo(c2.getModel()) < 0)
                {
                    temp = c1;
                    carList.set((j-1), c2);
                    carList.set(j, temp);
                }
            }
        }
        
        System.out.println("After carList ArrayList has been sorted with bubble sort:");
        
        //v. pt 1 Display current list after sorting bubble sort
        for (int i = 0; i < carList.size(); i++)
        {
            System.out.println(carList.get(i).toString());
        }
        
        */
        
        //iv. pt 2 Sort the car using insertion sort based on model
        Car c1, c2;
        for (int i = 1; i < carList.size(); i++)
        { 
            c1 = carList.get(i);
            String key = c1.getModel();
            int j=i-1;
            c2 = carList.get(j);
            String value2 = c2.getModel();
            while(j>=0 && key.compareTo(value2) < 0)
            { 
                carList.set((j+1),c2);
                j=j-1;
                if(j>=0)
                { 
                    c2 = carList.get(j);
                    value2 = c2.getModel();
                }
            }
            carList.set((j+1),c1);
        }
        
        System.out.println("After carList ArrayList has been sorted with insertion sort:");
        
        //v. pt 1 Display current list after sorting insertion sort
        for (int i = 0; i < carList.size(); i++)
        {
            System.out.println(carList.get(i).toString());
        }
        
        
        //vi. Search Proton car using binary search algorithm
        
        String search = "Proton";
        int low = 0, mid = -1, high = carList.size() -1, index = 0;
        boolean isFound = false;
        
        while (high >= low)
        {
            mid = (low+high)/2;
            Car c4 = carList.get(mid);
            
            if (search.compareTo(c4.getModel()) < 0)
            {
                high = mid - 1;
            }
            else if (search.compareTo(c4.getModel()) ==  0)
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
            Car c4 = carList.get(index);
            System.out.println("Details of vehicle " + search + ":\n" + c4.toString() +"\n" + "Was found at index: " + index);
        }
        else
        {
            System.out.println("Sorry, the vehicle " + search + " is NOT FOUND");
        }
    }
}
