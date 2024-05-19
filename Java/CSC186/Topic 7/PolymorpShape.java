
/**
 * Write a description of class PolymorpShape here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class PolymorpShape
{
    public static void main (String args[])
    {
        int choice, num;
        String strinput;
        double rad, height;
        
        for (int k = 0; k < num; k++ )
        {
            strinput = JOptionPane.showInputDialog(null, "Enter number of input : ");
            choice = Integer.parseInt(strinput);
        
        
            if (choice == 1)
            {
                strinput = JOptionPane.showInputDialog(null, "Enter choice (1-Cylinder, 2-Sphere) : ");
                choice = Integer.parseInt(strinput);
                
                strinput = JOptionPane.showInputDialog(null, "Enter height of the cylinder : ");
                height = Double.parseDouble(strinput);
                
                arr[k] = new Cylinder (rad, height);
            }
            else if (choice == 2)
            {
                strinput = JOptionPane.showInputDialog(null, "Enter the radius : ");
                rad = Double.parseDouble(strinput);
                
                arr[k] = new Sphere(rad);
            }
            
            
            
        }
        
        
    }
}
