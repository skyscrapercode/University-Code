
/**
 * Write a description of class cat here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class cat extends animal
{
    private String breed;
    private String color;
    
    //default
    public cat()
    {
        super();
        breed = null; 
        color = null;
    }
    
    //normal
    public cat(String n, int a, String nm, String b, String c)
    {
        super(n,a,nm);
        breed = b;
        color = c;
    }
    
    public cat(cat c)
    {
        super(c);
        breed = c.breed;
        color = c.color;
    }
    
    //getters or accessors
    public String getName() {return super.getName();}
    public int getAge() {return super.getAge();}
    public String getNickname() {return super.getNickname();}
    public String getBreed() {return breed;}
    public String getColor() {return color;}
    
    //setters or mutators
    public void setName(String n) {super.setName(n);}
    public void setAge(int a) {super.setAge(a);}
    public void setNickname(String n) {super.setNickname(n);}
    public void setBreed(String b) {breed = b;}
    public void setColor(String c) {color = c;}
    
    //processors methods
    
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
    
    public cat isOlder(cat c)
    {
        if (this.getAge() > c.getAge())
            return this;
        else
            return c;
    }
    
    public String toString()
    {
        return super.toString() + "\nBreed: " + breed + "\nColor: " + color;
    }
}
