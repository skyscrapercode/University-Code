
/**
 * Write a description of class Fruit here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Fruit
{
    // attributes
    private String name;
    private double price;
    private double weight;
    private String color;
    
    //default 
    /**
     * Constructor for objects of class Fruit
     */
    public Fruit()
    {
        // initialise instance variables |Extensiate or create objects
        name = null;
        price = 0.0;
        weight = 0.0;
        color = null;
    }
    
    // normal
    public Fruit(String n, double p, double w, String c)
    {
        name = n;
        price = p;
        weight = w;
        color = c;
    }
    
    //copy
    public Fruit(Fruit f)
    {
        name = f.name;
        price = f.price;
        weight = f.weight;
        color = f.color;
    }
    
    //setter method
    public void setName(String n){ name = n; }
    public void setPrice(double p){ price = p; }
    public void setWeight(double w){ weight = w; }
    public void setColor(String c){ color = c; }
    
    public void setFruit (String n, double p, double w, String c)
    {
        name = n;
        price = p;
        weight = w;
        color = c;
    }
    
    //getter
    public String getName(){ return name; }
    public double getPrice(){ return price; }
    public double getWeight(){ return weight; }
    public String getColor() { return color; }
    
    public String toString() {
        return ("Name of fruit: " + name + "\nPrice :RM "+ price + "\nWeight : " + weight + "\nColor : " + color);
    }
    
    
}
