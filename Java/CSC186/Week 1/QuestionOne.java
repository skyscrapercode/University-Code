
/**
 * Write a description of class QuestionOne here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class QuestionOne
{
    public static void main (String args[])
    {
        double CGPA[] = new double[100];
        double lowestCGPA = 4, averageCGPA = 0, totalCGPA = 0;
        int numOfStudent = 0, numOfStudent2 = 0;
        String in;
        
        for (int i = 0; i < 4; i++)
        {
  
             in = JOptionPane.showInputDialog(null," Enter the CGPA for student " + i +":  ");  
             
             CGPA[i] = Double.parseDouble(in);
             if (lowestCGPA > CGPA[i] )
             {
                 lowestCGPA = CGPA[i];
             }
             
             if (CGPA[i] < 2.0)
             {
                 numOfStudent++;
             }
             
             if (CGPA[i] >= 3.5)
             {
                 numOfStudent2++;
             }
             
             totalCGPA += CGPA[i];
             
        }
        
        averageCGPA = totalCGPA/4;
        
        JOptionPane.showMessageDialog(null,"The lowest CGPA is: " + lowestCGPA );
        JOptionPane.showMessageDialog(null,"The number of student with CGPA below 2.0 is: " + numOfStudent );
        JOptionPane.showMessageDialog(null,"The number of student with highest CGPA equal or above 3.5 is: " + numOfStudent2 );
        JOptionPane.showMessageDialog(null,"The average CGPA is: " + averageCGPA );
        
        
        
    }
}
