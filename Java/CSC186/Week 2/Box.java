
/**
 * Write a description of class Box here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Box
{
    private String boxName;
    private double height;
    private double width;
    private double length;
    
    //default
    public Box()
    {
        boxName = null;
        height = 0.0;
        width = 0.0;
        length = 0.0;
    }
    
    //normal
    public Box(String b, double h, double w, double l)
    {
        boxName = b;
        height = h;
        width = w;
        length = l;
    }
    
    //copy
    public Box(Box b)
    {
        boxName = b.boxName;
        height = b.height;
        width = b.width;
        length = b.length;
    }
    
    //mutator / setter
    public void setBoxName(String b) {boxName = b;}
    public void setHeight(double h) {height = h;}
    public void setWidth(double w) {width = w;}
    public void setLength(double l) {length = l;}
    
    //Accessors / getter
    public String getBoxName() {return boxName;}
    public double getHeight() {return height;}
    public double getWidth() {return width;}
    public double getLength() {return length;}
    
    //toString
    public String toString () {
        return ("Box Name: " + boxName + "\n Height: " + height + "\n Width: " + width + "\n Length: " + length);
    }
    
    public double calculateArea()
    {
        return (height *  width);
    }
    
    public double calculateVolume()
    {
        return (length * width * height);
    }
    
    public boolean isSmaller(Box b)
    {
        
        if (calculateVolume() < b.calculateVolume())
            return true;
        else  
            return false;
            
    }
    
    public boolean isCube()
    {
        
        if (length == height && height == width)
            return true;
        else
            return false;
            
    }
}
