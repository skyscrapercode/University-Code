
/**
 * Write a description of class animalMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class animalMain
{
    public static void main (String args[])
    {
        cat b[] = new cat[10]; 
        
        b[0] = new cat("Fluffy",4, "fav kitty", "German Shephard", "Pink");
        b[1] = new cat("Floof", 6, "old friend", "Siamese", "Green");
        
        cat a = b[0].isOlder(b[1]);
        
        System.out.println(a.toString());
        
        
        for (int i = 0; i < b.length; i++)
        {
            String na = JOptionPane.showInputDialog(null, "Name of cat: ");
            int age = Integer.parseInt(JOptionPane.showInputDialog(null, "Age of cat: "));
            String n = JOptionPane.showInputDialog(null, "Nickname of cat:");
            String breed = JOptionPane.showInputDialog(null, "Breed of animal: ");
            String c = JOptionPane.showInputDialog(null, "Color of cat: ");
        }
    }
}
