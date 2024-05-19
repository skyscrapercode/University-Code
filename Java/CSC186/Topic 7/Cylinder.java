
/**
 * Write a description of class Cylinder here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Cylinder extends Circle
{
    private double height;
    
    public Cylinder() 
    {
        super();
        height = 0;
    }
    
    public Cylinder (double r, double h)
    {
        super.setDimension(r);
        if (h >= 0)
            height = h;
        else
            height = 0;
    }
    
    public double getHeight() {return height;}
    public double calArea() { return super.calArea() * super.calPerimeter() * height;}
    public double calVolume() { return 3.142 * super.getRadius() * super.getRadius() * height;}
    public String print() {return (super.print() + "\nHeight " + height);}
    
    
}
