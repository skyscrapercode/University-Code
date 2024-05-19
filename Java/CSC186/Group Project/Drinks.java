
/**
 * Write a description of class Drinks here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class Drinks extends Meals
{
    private String name;
    private double price;
    
    public Drinks()
    {
        super();
        name = null;
        price = 0.0;
    }
    
    public Drinks(String n, double p, boolean a, String na, double pr)
    {
        super(n,p,a);
        name = na;
        price = pr;
    } 
    
    public void setDrinks(String n) { name = n;}
    public void setDrinksPrice(double p) { price = p;}

    public String getDrinks() {return name;}
    public double getDrinksPrice() {return price;}
    
    public double drinkSize()
    {
        int drinkSizeInput;
        do
        {
            
            drinkSizeInput = Integer.parseInt(JOptionPane.showInputDialog(null, "What size would you like it to be?" + "\n" + "1. Large: RM" + (price + 6) + "\n" + "2. Medium: RM" + price + "\n" + "3. Small: RM" + (price - 2)));
            
            if (drinkSizeInput == 1)
                price += 6;
            else if (drinkSizeInput == 3)
                price -= 2;
            else
                JOptionPane.showMessageDialog(null, "Wrong choice please try again");
                
        } while (drinkSizeInput < 1 && drinkSizeInput > 3);
        
        return price;
    }
}