import java.text.*;
/**
 * Write a description of class BagMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class BagMain
{
    public static void main(String args[])
    {
        Bag bagOne = new Bag();
        DecimalFormat df = new DecimalFormat("###.##");
        
        String brand = JOptionPane.showInputDialog(null, "What is the brand of the bag: ");
        String model = JOptionPane.showInputDialog(null, "What is the model of the bag: ");
        String type = JOptionPane.showInputDialog(null, "What is the type of the bag: ");
        double sellingPrice = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the price of the bag: "));
        
        
        Bag bagTwo = new Bag(brand, model, type, sellingPrice);
        
        bagOne.setBagBrand("Swan");
        bagOne.setBagModel("SW102");
        bagOne.setBagType("School Bag");
        bagOne.setBagSellingPrice(79.00);
      
        System.out.println("\n");
        System.out.println(bagOne);
        System.out.println("\n");
        System.out.println(bagTwo);
        System.out.println("\n");
        bagOne.promotionPrice();
        bagTwo.promotionPrice();
        System.out.println("Here is the price of Bag one after a promotion: " + df.format(bagOne.getBagSellingPrice()) + "\nHere is the price of Bag two after a promotion: " + df.format(bagTwo.getBagSellingPrice()));
        
        if (bagOne.getBagSellingPrice() > bagTwo.getBagSellingPrice() )
        {
            System.out.println(bagOne);
        }
        else
        {
            System.out.println(bagTwo);
        }
    }
}
