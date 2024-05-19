
/**
 * Write a description of class MainCourse here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import javax.swing.JOptionPane;
public class MainCourse extends Meals
{
    
    public MainCourse()
    {
        super();
    }
    
    public MainCourse(String n, double p, boolean a)
    {
        super(n,p,a);
    }
    
    public String getMainCourse() {return super.getMainCourse();}
    public double getMainCoursePrice() {return super.getMainCoursePrice();}
    
    public boolean category()
    {
       int choice;
       do 
       {
           choice = Integer.parseInt(JOptionPane.showInputDialog(null, "Would you like chicken or beef?" + "\n" + "1. Chicken" + "\n" + "2. Beef"));    
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
    
    public boolean checkAvailable()
    {
        return super.checkAvailable();
    } 
}
