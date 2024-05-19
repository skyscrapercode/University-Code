
/**
 * Write a description of class FruitMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class FruitMain
{
    public static void main (String args[])
    {
        
        ImportedFruit [] f = new ImportedFruit[1];
        
        for (int i = 0; i < f.length; i++)
        {
            String name = JOptionPane.showInputDialog(null, "Name: ");
            double weight = Double.parseDouble(JOptionPane.showInputDialog(null, "Weight: "));
            double price = Double.parseDouble(JOptionPane.showInputDialog(null, "Price: "));
            int numOfPermit = Integer.parseInt(JOptionPane.showInputDialog(null, "Number of Permit: "));
            int certNum = Integer.parseInt(JOptionPane.showInputDialog(null, "How many certs: "));
            boolean quarantine = Boolean.parseBoolean(JOptionPane.showInputDialog(null, "Are you in quarantine? (true or false)"));
            int numInQ = Integer.parseInt(JOptionPane.showInputDialog(null, "What is the num of days in quarantine"));
            
            f[i] = new ImportedFruit(name, weight, price, numOfPermit, certNum, quarantine, numInQ);
            
            JOptionPane.showMessageDialog(null, "The total price of all fees is RM" + f[i].calculateFee());
            
            if (f[i].getWeight() > 10000 && numInQ > 5)
            {
                System.out.println(f[i].toString());
            }
        }
        
        
        
        
    }
}
