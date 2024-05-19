
/**
 * Write a description of class taxpayerMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class taxpayerMain
{
    public static void main (String args[]){
        
        double[] income = new double[12];
        
        taxpayer taxes = new taxpayer();
        taxpayer taxes2 = new taxpayer();
        JOptionPane.showMessageDialog(null, taxes2);
        JOptionPane.showMessageDialog(null,taxes2.getIncome());
            
        String name = JOptionPane.showInputDialog(null, "What is your name: ");
        taxes.setName(name);
            
        String fileNum = JOptionPane.showInputDialog(null, "What is your file number: ");
        taxes.setfileNum(fileNum);
        
        for (int i = 0; i < income.length; i++)
        {
            income[i] =  Double.parseDouble(JOptionPane.showInputDialog(null, "What is your income for month " + (i+1) + " : "));
        }
        
        taxes.setIncome(income);
        
        JOptionPane.showMessageDialog(null, taxes);
        
        JOptionPane.showMessageDialog(null, "Your total income is RM: " + taxes.calculateTotalIncome());
        JOptionPane.showMessageDialog(null, "The amount of tax you owe is RM" + taxes.calculateTax()); 
            
        
        
    }
}
