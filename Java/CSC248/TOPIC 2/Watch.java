
/**
 * Write a description of class Watch here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Watch
{
    private String case_material;
    private String glass_type;
    private boolean waterproof;
    private String watch_strap;
    private double price;
    
    //Normal constructor
    public Watch(String cm, String gt, boolean w, String ws, double p)
    {
        case_material = cm;
        glass_type = gt;
        waterproof = w;
        watch_strap = ws;
        price = p;
    }
    
    //setters or mutators
    public void setCase(String c) {case_material = c;}
    public void setGlass(String g) {glass_type = g;}
    public void setWaterproof(boolean w) {waterproof = w;}
    public void setStrap(String w) {watch_strap = w;}
    public void setPrice(double p) {price = p;}
    
    //getters or accessors
    public String getCase() {return case_material;}
    public String getGlass() {return glass_type;}
    public boolean getWaterproof() {return waterproof;}
    public String getStrap() {return watch_strap;}
    public double getPrice() {return price;}
    
    //toString or printer method
    public String toString()
    {
        return ("Case: " + case_material + "\nGlass: " + glass_type + "\nWaterproof: " + waterproof + "\nStrap: " + watch_strap + "\nPrice: " + price);
    }
}
