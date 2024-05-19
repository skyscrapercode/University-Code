import java.text.*;
/**
 * Write a description of class Bag here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Bag
{
    private String brand;
    private String model;
    private String type;
    private double sellingPrice;
    DecimalFormat df = new DecimalFormat("###.##");
    
    //default
    public Bag()
    {
        brand = null;
        model = null;
        type = null;
        sellingPrice = 0.0;
    }
    
    //normal
    public Bag(String b, String m, String t, double sp)
    {
        brand = b;
        model = m;
        type = t;
        sellingPrice = sp;
    }
    
    //setter or muatator for each
    public void setBagBrand(String b) { brand = b;}
    public void setBagModel(String m) { model = m;}
    public void setBagType(String t) { type = t;}
    public void setBagSellingPrice(double sp) { sellingPrice = sp;}
    
    //setter or muatator for all
    public void setBag(String b, String m, String t, double sp)
    {
        brand = b;
        model = t;
        type = t;
        sellingPrice = sp;
    }
    
    //getters or accessors
    public String getBagBrand() {return brand;}
    public String getBagModel() {return model;}
    public String getBagtype() {return type;}
    public double getBagSellingPrice() {return sellingPrice;}
    
    //toString
    public String toString()
    {  
        return ("Bag Brand: " + brand + "\nBag Model:" + model + "\nBag Type:" + type + "\nBag Selling Price RM:" + df.format(sellingPrice));
    }
    
    public void promotionPrice()
    {
       
        
        if (type.equalsIgnoreCase("Travelling Bag"))
        {
            sellingPrice = sellingPrice * (95.0/100);
        }
        else if (type.equalsIgnoreCase("School Bag"))
        {
            sellingPrice = sellingPrice * (90.0/100);
        }
    }
    
    
    
    
}
