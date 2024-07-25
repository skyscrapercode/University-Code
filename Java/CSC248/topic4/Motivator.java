
/**
 * Write a description of class Motivator here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Motivator
{
    private String motivatorID;
    private String motivatorName;
    private String faculty;
    private String programCode;
    private double marks;
    
    public Motivator(String i, String n, String f, String c, double m)
    {
        motivatorID = i;
        motivatorName = n;
        faculty = f;
        programCode = c;
        marks = m;
    }
    
    public String getMotivatorID() {return motivatorID;}
    public String getMotivatorName() {return motivatorName;}
    public String getFaculty() {return faculty;}
    public String getProgramCode() {return programCode;}
    public double getMarks() {return marks;}
    
    public String toString()
    {
        return "Motivator ID: " + motivatorID + " Motivator Name: " + motivatorName + " Faculty: " + faculty + " Program Code: " + programCode + " Marks: " + marks;
    }
}
