
/**
 * Write a description of class GradeSystem here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class GradeSystem
{
    public static void main (String args[])
    {
        double mark;
        String grade = " ";
        String markInput = JOptionPane.showInputDialog(null, "Input your mark: ");
        mark = Double.parseDouble(markInput);
        
        if (mark > 90 && mark <= 100)
        {
            grade = "A+";
        }
        else if (mark > 80 && mark < 90)
        {
            grade = "A";
        }
        else if (mark > 75 && mark < 80)
        {
            grade = "A-";
        }
        else if (mark > 70 && mark < 75)
        {
            grade = "B+";
        }
        else if (mark > 65 && mark < 70)
        {
            grade = "B";
        }
        else if (mark > 60 && mark < 65)
        {
            grade = "B-";
        }
        else if (mark > 55 && mark < 60)
        {
            grade = "C+";
        }
        else if (mark > 50 && mark < 55)
        {
            grade = "C";
        }
        else if (mark > 47 && mark < 50)
        {
            grade = "C-";
        }
        else if (mark > 44 && mark < 47)
        {
            grade = "D+";
        }
        else if (mark > 40 && mark < 44)
        {
            grade = "D";
        }
        else if (mark > 30 && mark < 40)
        {
            grade = "E";
        }
        else if (mark > 0 && mark < 30)
        {
            grade = "F";
        }
        else 
        {
            JOptionPane.showMessageDialog(null, "Wrong Input");
        }
        
        JOptionPane.showMessageDialog(null, "Your grade is " + grade);
        
    }
}
