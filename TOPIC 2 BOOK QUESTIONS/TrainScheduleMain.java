
/**
 * Write a description of class TrainScheduleMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.ArrayList;
import java.util.Scanner;
import java.util.StringTokenizer;
import java.io.*;
public class TrainScheduleMain
{
   public static void main (String args[])
   {
       ArrayList trainList = new ArrayList(50);
       Scanner s = new Scanner(System.in);
       
       /*
       for (int i = 0; i < trainList.size(); i++)
       {
           System.out.println("What is the code?");
           String c = s.nextLine();
           System.out.println("What is the date?");
           String d = s.nextLine();
           System.out.println("What is the departure time?");
           String dt = s.nextLine();
           System.out.println("What is the destination?");
           String de = s.nextLine();
           System.out.println("What is the arrival time?");
           String at = s.nextLine();
           
           TrainSchedule ts = new TrainSchedule(c,d,dt,de,at);
           trainList.add(ts);
       }
       */
       try{
            File f = new File("TrainScheduleData.txt");
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String line = "";
            while ((line = br.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer(line, ";");
                String c = st.nextToken();
                String d = st.nextToken();
                String dt = st.nextToken();
                String de = st.nextToken();
                String at = st.nextToken();
                
                TrainSchedule ts = new TrainSchedule(c,d,dt,de,at);
                trainList.add(ts);
                
            }
        }catch (Exception e)
        {
            System.out.println(e);
        }
       
       System.out.println("Data before sort for asecending departure time");
       for (int i = 0; i < trainList.size(); i++)
       {
            System.out.println(trainList.get(i).toString());
       }
    
    
       int n = trainList.size();
       TrainSchedule temp;
       for(int i = 0; i < n - 1; i++)
       {
            for (int j = 1; j < n; j++)
            {
                Object obj = trainList.get(j-1);
                TrainSchedule ts = (TrainSchedule) obj;
                
                Object obj2 = trainList.get(j);
                TrainSchedule ts2 = (TrainSchedule) obj2;
                if (ts.getDepTime().compareTo(ts2.getDepTime()) > 0)
                {
                    temp = ts;
                    trainList.set((j-1), ts2);
                    trainList.set(j, temp);
                }
            }
       }
       
       System.out.println("Data after sort for asecending departure time");
       for (int i = 0; i < trainList.size(); i++)
       {
            System.out.println(trainList.get(i).toString());
       }
       
   }
}
