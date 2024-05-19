
/**
 * Write a description of class companyMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.io.*;
import java.util.*;
import javax.swing.JOptionPane;
public class companyMain
{
    public static void main (String args[]) throws IOException
    {   
        try 
        {
            File f = new File("Employee.txt");
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String name, line = "";
            int yearOfService, num = 0;
            double salary;
            double increment;
            Employee [] e = new Employee[5];
        
            FileWriter junior = new FileWriter("Junior.txt");
            PrintWriter juniorWrite = new PrintWriter(junior);
            
            FileWriter senior = new FileWriter("Senior.txt");
            PrintWriter seniorWrite = new PrintWriter(senior);
            
            FileWriter eupdate = new FileWriter("employeeupdate.txt");
            PrintWriter eupdateWrite = new PrintWriter(eupdate);

            juniorWrite.println("JUNIOR DATA         \n");
            juniorWrite.println("NAME AND SALARY:   \n");
           
            seniorWrite.println("SENIOR DATA        \n");
            seniorWrite.println("NAME AND SALARY:  \n");
            
            eupdateWrite.println("UPDATED DATA       \n");
            eupdateWrite.println("NAME AND SALARY:  \n");
            
            while ((line = br.readLine()) != null)
            {
               StringTokenizer st = new StringTokenizer(line, ";");
               name = st.nextToken();
               yearOfService = Integer.parseInt(st.nextToken());
               salary = Double.parseDouble(st.nextToken());
               increment = Double.parseDouble(st.nextToken());
               
               e[num] = new Employee (name, yearOfService, salary, increment);
               num++; 
            }
            
            for (int i = 0; i < num; i++)
            {
                if (e[i].isSenior())
                    seniorWrite.println(e[i].getName() + " RM" + e[i].getSalary() + "\n");
                else 
                    juniorWrite.println(e[i].getName() + " RM" + e[i].getSalary() + "\n");
                
                eupdateWrite.println(e[i].getName() + " RM" + e[i].newSalary());
            }
            
            fr.close();
            br.close();
            
            juniorWrite.close();
            seniorWrite.close();
            eupdateWrite.close();            

        }
        
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null, "error opening file");
        }
           
    }
        
}
