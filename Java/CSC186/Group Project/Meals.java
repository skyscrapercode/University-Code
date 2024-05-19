
/**
 * Write a description of class Meals here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

public class Meals
{
    private String name;
    private double price;
    private boolean available;
    
    //default
    public Meals()
    {
        name = null;
        price = 0.0;
        available = false;
    }
    
    //normal
    public Meals(String n, double p, boolean a)
    {
        name = n;
        price = p;
        available = a;
    }
    
    //setters
    public void setAvailable(boolean a) {available = a;}
    //getters
    public String getMainCourse() {return name;}
    public double getMainCoursePrice() {return price;}
    
    public boolean checkAvailable()
    {
        return available;
    }
}
