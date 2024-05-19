
/**
 * Write a description of class Player here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Player
{
    //attributes
    private String name;
    private String game;
    private String gender;
    private int age;
    private int rank;
    
    //default
    public Player()
    {
        name = "Eminem";
        game = "Genshin";
        gender = "Male";
        age = 20;
        rank = 60;
    }
    
    //normal
    public Player(String n, String ga, String ge, int a, int r)
    {
        name = n;
        game = ga;
        gender = ge;
        age = a;
        rank = r;
    }
    
    //copy
    public Player(Player p)
    {
        name = p.name;
        game = p.game;
        gender = p.gender;
        age = p.age;
        rank = p.rank;
    }
    
    //setter 
    public void setName(String n){ name = n; }
    public void setGame(String g){ game = g; }
    public void setGender(String g){ gender = g; }
    public void setAge(int a){ age = a; }
    public void setRank(int r){ rank = r; }
    
    //getter
    public String getName() { return name; }
    public String getGame() { return game; }
    public String getGender() { return gender;}
    public int getAge() {return age;}
    public int getRank() {return rank;}
    
    public String toString() {
        return ("Name: " + name + "\n Game: "+ game + "\n Gender: " + gender + "\n Age: " + age + "\n Rank: " + rank);
    }
    
    
}
