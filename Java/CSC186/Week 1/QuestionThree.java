
/**
 * Write a description of class QuestionThree here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class QuestionThree
{
    public static void main (String args[])
    {
        double CGPA[] = new double[100];
        int studentID[] = new int[100];
        int deanList = 0, probation = 0, highestCGPAStudentID = 0 ;
        double highestCGPA = 0 ;
        String in, in2, student;
        
        student  =  "StudentID: " + "CGPA:" + "\n";
        
        for (int i = 0; i < 5; i++)
        {
            in = JOptionPane.showInputDialog(null," Enter your Student ID: ");
            
            studentID[i] = Integer.parseInt(in);
            
            in2 = JOptionPane.showInputDialog(null," Enter your CGPA: ");
            
            CGPA[i] = Double.parseDouble(in2);
 
            student  +=  studentID[i] + "  " + CGPA[i] + "\n";
            
            if (CGPA[i] > highestCGPA)
            {
                highestCGPA = CGPA[i];
                highestCGPAStudentID = studentID[i];
            }
            
            if (CGPA[i] >= 3.5)
            {
                deanList++;
            }
            
            if (CGPA[i] < 2.0)
            {
                probation++;
            }
            
        }
        
        JOptionPane.showMessageDialog(null,student);
        JOptionPane.showMessageDialog(null,"The student with the highest CGPA: " + "\n" + "Student ID: " + highestCGPAStudentID + " CGPA: " + highestCGPA);
        JOptionPane.showMessageDialog(null,"The number of students that are in the dean list is: " + deanList);
        JOptionPane.showMessageDialog(null,"The number of students that are in probation: " + probation);
        
        
        
    }
}
