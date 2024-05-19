
/**
 * Write a description of class StudentMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class StudentMain
{
    public static void main (String args[])
    {
        String n, ic, s1, s2, s3;
        double score1, score2, score3, average, highestScore;
        
        n = JOptionPane.showInputDialog(null, "Input Name:");
        ic = JOptionPane.showInputDialog(null, "Input IC:");
        s1 = JOptionPane.showInputDialog(null, "Input Score 1:");
        s2 = JOptionPane.showInputDialog(null, "Input Score 2:");
        s3 = JOptionPane.showInputDialog(null, "Input Score 3:");
        
        score1 = Double.parseDouble(s1);
        score2 = Double.parseDouble(s2);
        score3 = Double.parseDouble(s3);
        
        Student student1 = new Student();
        Student student2 = new Student(n, ic, score1, score2, score3);
        
        JOptionPane.showMessageDialog(null, "The data of student is : " + student1);
        JOptionPane.showMessageDialog(null, "The data of student 2 is : " + student2);
        
        // object.methods and there has to be a variable to receive a value if it returns one
        // student2 means that it's the object that will do computeAvg in this case
        average = student2.computeAvg();
        
        JOptionPane.showMessageDialog(null, "The average of all 3 scores is: " + average);
        
        highestScore = student2.highestScore();
        
        JOptionPane.showMessageDialog(null, "The highest of all 3 scores is: " + highestScore);
        
        
        
        
        
        
        
    }
}
