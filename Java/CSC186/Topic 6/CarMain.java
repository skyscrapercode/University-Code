
/**
 * Write a description of class CarMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.io.*;
import java.util.*;
import javax.swing.JOptionPane;
public class CarMain
{
   public static void main (String args[]) throws IOException
   {
       try 
       {
           File f = new File("Cars.txt");
           FileReader fr = new FileReader(f);
           BufferedReader br = new BufferedReader(fr);
           String line = "", fullName;
           String[] arrName = null;
           Car [] c = new Car[6];
           String name, ic, manufacturer, model;
           int num = 0, countBezza = 0;
           
           FileWriter out1 = new FileWriter("Proton.txt");
           PrintWriter ofile1 = new PrintWriter(out1);
           
           FileWriter out2 = new FileWriter("Other.txt");
           PrintWriter ofile2 = new PrintWriter(out2);
           
           ofile1.println("Proton cars owner- \n");
           ofile1.println("NAME:             \n");
           
           ofile2.println("OTHER cars owner-  \n");
           ofile2.println("NAME:             \n");
           
           while ((line = br.readLine()) != null)
           {
               StringTokenizer st = new StringTokenizer(line, ";");
               name = st.nextToken();
               ic = st.nextToken();
               manufacturer = st.nextToken();
               model = st.nextToken();
               
               c[num] = new Car (name, ic, manufacturer, model);
               num++;
           }
           
           for (int i = 0; i < num; i++)
           {
               if(c[i].getManufacturer().equalsIgnoreCase("Proton"))
               {
                   ofile1.println(c[i].getName() + "\n");
               }
               else 
               {
                   ofile2.println(c[i].getName() + "\n");
               }
               
               if (c[i].getManufacturer().equalsIgnoreCase("Perodua") && c[i].getModel().equalsIgnoreCase("Bezza"))
                   countBezza++;
                
           }
           
           System.out.println("count Bezza: " + countBezza);
           
           br.close();
           fr.close();
           
           ofile1.close();
           ofile2.close();
       }
       
       catch (IOException e)
       {
           JOptionPane.showMessageDialog(null, "error opening file");
       }
   }
}
