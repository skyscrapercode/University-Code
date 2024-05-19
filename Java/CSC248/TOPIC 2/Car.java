
/**
 * Write a description of class Car here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Car
{
    private String model;
    private double price;
    
    //Normal constructor
    public Car(String m, double p)
    {
        model = m;
        price = p;
    }
    
    //getters
    public String getModel() {return model;}
    public double getPrice() {return price;}
    
    
    //toString
    public String toString()
    {
        return ("Model: " + model + " Price: RM" + price );
    }
}
