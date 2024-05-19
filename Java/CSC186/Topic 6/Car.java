
/**
 * Write a description of class Car here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Car
{
    private String name;
    private String ic;
    private String manufacturer;
    private String model;
    
    public Car()
    {
        name = null;
        ic = null;
        manufacturer = null;
        model = null;
    }
    
    public Car(String n, String i, String m, String o)
    {
        name = n;
        ic = i;
        manufacturer = m;
        model = o;
    }
    
    public String getName() {return name;}
    public String getIC() {return ic;}
    public String getManufacturer() {return manufacturer;}
    public String getModel() {return model;}
    
    public String toString()
    {
        return ("Name: " + name + " IC: " + ic + " Manufacturer: " + manufacturer + " Model: " + model);
    }
    
}
