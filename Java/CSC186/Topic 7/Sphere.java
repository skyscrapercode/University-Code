
/**
 * Write a description of class Sphere here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Sphere extends Circle
{
    public Sphere() {super();}
    
    public Sphere(double r) {super(r);}
    
    public void setDimension(double r)
    {
        super.setDimension(r);
    }
    
    public double calArea() {return 4 * super.calArea();}
    
    public double calVolume() 
    {
        return 4.0/3.0 * 3.142 * super.getRadius() * super.getRadius() * super.getRadius();
    }
    
    public String print() 
    {
        return (super.print()); 
    }
}
