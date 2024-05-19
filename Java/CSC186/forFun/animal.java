
/**
 * Write a description of class animal here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public abstract class animal
{
    private String name;
    private int age;
    private String nickname;
    
    //default
    public animal()
    {
        name = null;
        age = 0;
        nickname = null;
    }
    
    //normal
    public animal(String n, int a, String nm)
    {
        name = n;
        age = a;
        nickname = nm;
    }
    
    //copy
    public animal (animal a)
    {
        name = a.name;
        age = a.age;
        nickname = a.nickname;
    }
    
    //getters or accessors
    public String getName() {return name;}
    public int getAge() {return age;}
    public String getNickname() {return nickname;}
    
    //setters or mutators
    public void setName(String n) {name = n;}
    public void setAge(int a) {age = a;}
    public void setNickname(String n) {nickname = n;}
    
    //processors not really needed in this case
    
    //printer
    public String toString()
    {
        return "Name: " + name + "\nAge: " + age + "\nNickname: " + nickname;
    }
    
}
