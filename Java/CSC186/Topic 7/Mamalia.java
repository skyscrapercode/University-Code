
/**
 * Write a description of class Mamalia here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Mamalia //superclass
{
    private String order;
    private String species;
    private String name;
    
    public Mamalia()
    {
        order = null;
        species = null;
        name = null;  
    }
    
    public Mamalia (String o, String s, String n)
    {
        order = o;
        species = s;
        name = n;
    }
    
    public String toString()
    {
       return("Order : " + order + "\nSpecies : " + species + "\nName : " + name); 
    }
    
}
