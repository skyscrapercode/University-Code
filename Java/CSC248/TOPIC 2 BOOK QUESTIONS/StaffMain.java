
/**
 * Write a description of class StaffMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.ArrayList;
import java.util.Scanner;
public class StaffMain
{
    public static void main (String args[])
    {
        
        Scanner s = new Scanner(System.in);
        System.out.println("How many staff?");
        int amtStaff = s.nextInt();
        ArrayList staffList = new ArrayList(amtStaff);
        for (int i = 0; i < staffList.size(); i++)
        {
            System.out.println("Name:");
            String n = s.nextLine();
            System.out.println("Staff ID:");
            int id = s.nextInt();
            System.out.println("Position:");
            String p = s.nextLine();
            System.out.println("Department:");
            String d = s.nextLine();
            System.out.println("Monthly Salary:");
            double ms = s.nextDouble();
            
            Staff staff = new Staff(n,id,p,d,ms);
            staffList.add(staff);
        }
        
        int count = 0;
        for (int i = 0; i < staffList.size(); i++)
        {
            Object obj = staffList.get(i);
            Staff stf = (Staff) obj;
            
            if (stf.getMonthlySalary() > 2000)
                count++;
        }
        
        System.out.println("The number of staff with salary less then RM2000 is " + count);
        
        double minSalary = 9999999;
        Staff minStaff;
        for (int i = 0; i < staffList.size(); i++)
        {
            Object obj = staffList.get(i);
            Staff stf = (Staff) obj;
            
            if (stf.getMonthlySalary() < minSalary)
            {
                minSalary = stf.getMonthlySalary();
                minStaff = stf;
            }
            
        }
        
        System.out.println("Information of staff with the lowest monthly salary:" + "\n" + minStaff.toString());
        
    }
}
