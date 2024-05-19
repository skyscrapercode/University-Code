
/**
 * Write a description of class QuestionTwo here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class QuestionTwo
{
    public static void main (String args[])
    {
        double salary[] = new double[50];
        double totalSalary = 0, highestSalary = 0;
        int highSalary = 0;
        String in;
        
        for (int i = 0; i < 50; i++)
        {
            in = JOptionPane.showInputDialog(null," Enter the salary for employee " + i + ":");
            
            salary[i] = Double.parseDouble(in);
            
            totalSalary += salary[i];
            
            if (salary[i] > 5000)
            {
                highSalary++;
            }
            
            if (salary[i] > highestSalary)
            {
                highestSalary = salary[i];
            }
            
            
        }
        
        JOptionPane.showMessageDialog(null,"The total salary for all employee's is RM" + totalSalary  );
        JOptionPane.showMessageDialog(null,"The highest salary is RM " + highestSalary  );
        JOptionPane.showMessageDialog(null,"The number of employee's with salary more than RM5000 is: " + highSalary  );
        
        
    }
}
