
/**
 * Write a description of class Dog here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Dog extends Mamalia //Subclass
{
    private boolean canHunt;
    private String type;
    
    public Dog()
    {
        super();
        canHunt = false;
        type = null;
    }
    
    public Dog (String o, String s, String n, boolean c, String t)
    {
        super(o,s,n);
        canHunt = c;
        type = t;
    }
    
    public String toString()
    {
        if (canHunt)
        {
            return (super.toString() + "\nIt can Hunt " + "\nType : " + type);
        }
        else
        {
            return (super.toString() + "\nIt can Hunt " + "\nType : " + type);
        }
    }
}
