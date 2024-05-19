
/**
 * Write a description of class dog here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class dog extends animal
{
    private String breed;
    private String color;
    
    //default constructor
    public dog()
    {
        super();
        breed = null;
        color = null;
    }
    
    //normal
    public dog(String n, int a, String nm, String b, String c)
    {
        super(n,a,nm);
        breed = b;
        color = c;
    }
    
    //copy
    public dog(dog d)
    {
        super(d);
        breed = d.breed;
        color = d.color;
    }
    
    //accessors or getters
    public String getName() {return super.getName();}
    public int getAge() {return super.getAge();}
    public String getNickname() {return super.getNickname();}
    public String getBreed() {return breed;}
    public String getColor() {return color;}
    
    //setters or mutators
    public void setName(String n) {super.setName(n);}
    public void setAge(int a) {super.setAge(a);}
    public void setNickname(String nm) {super.setNickname(nm);}
    public void setBreed(String b) {breed = b;}
    public void setColor(String c) {color = c;}
    
    //processor methods 
    
    public boolean isAvailable(String b)
    {
        if (breed.equalsIgnoreCase(b))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
