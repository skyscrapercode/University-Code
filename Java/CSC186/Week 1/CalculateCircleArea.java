
/**
 * Write a description of class CalculateCircleArea here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class CalculateCircleArea
{
    public static void main(String args[])
    {
        double area, radius;
        final double PI = 3.142;
        
        String radiusInput = JOptionPane.showInputDialog(null," Enter the radius:  ");
        radius  = Double.parseDouble(radiusInput);
        
        area = radius * radius * PI;
        
        JOptionPane.showMessageDialog(null," The area of a circle with radius "
        + radius + " is " + area, "Answer", JOptionPane.WARNING_MESSAGE);
        
        System.exit(0);
    }
}
