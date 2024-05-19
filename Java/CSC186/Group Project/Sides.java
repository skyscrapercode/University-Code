
/**
 * Write a description of class Sides here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import javax.swing.JOptionPane;
public class Sides extends Meals
{
    private String name;
    private double price;
    
    public Sides()
    {
        super();
        name = null;
        price = 0.0;
    }
    
    public Sides(String n, double p, boolean a, String na, double pr)
    {
        super(n,p,a);
        name = na;
        price = pr;
    } 
    
    public void setSides(String n) { name = n;}
    public void setSidesPrice (double p) { price = p;}
    
    public String getSides() {return name;}
    public double getSidesPrice() {return price;}
    
    public boolean type()
    {
        int choice;
        do 
        {
            choice = Integer.parseInt(JOptionPane.showInputDialog(null, "Would you like dessert or salad?" + "\n" + "1. Dessert" + "\n" + "2. Salad"));    
        } while (choice != 1 && choice != 2);
        
        if (choice == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
