
/**
 * Write a description of class Cat here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Cat extends Mamalia
{
    private boolean haveFur;
    private String color;
    
    public Cat()
    {
        super();
        haveFur = false;
        color = null;
    }
    
    public Cat(String o, String s, String n, boolean h, String c)
    {
        super(o,s,n);
        haveFur = h;
        color = c;
    }
    
    public String toString()
    {
        return (super.toString() + "\nHad Fur? : " + haveFur + "\nColor : " + color);
    }
}
