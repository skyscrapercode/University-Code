
/**
 * Write a description of class Fruit here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Fruit
{
    private String name;
    private double weight;
    private double price;
    
    //normal
    public Fruit(String n, double w, double p)
    {
        name = n;
        weight = w;
        price = p;
    }
    
    //mutators or setters
    public void setName(String n) { name = n;}
    public void setWeight(double w) {weight = w;}
    public void setPrice(double p) {price = p;}
    
    //accessors or getters
    public String getName() {return name;}
    public double getWeight() {return weight;}
    public double getPrice() {return price;}
    
    public String toString()
    {
        return ("Name: " + name + "\nWeight: " + weight + "\nPrice: RM" + price);
    }
}
