
/**
 * Write a description of class Student here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Student
{
    //attributes
    private String name;
    private String ICNum;
    private double score1;
    private double score2;
    private double score3;
    
    //default
    public Student()
    {
        name = null;
        ICNum = null;
        score1 = 0.0;
        score2 = 0.0;
        score3 = 0.0;
    }
    
    //normal
    public Student(String n, String i, double s1, double s2, double s3)
    {
        name = n;
        ICNum = i;
        score1 = s1;
        score2 = s2;
        score3 = s3;
    }
    
    //setter or mutator method (if there are 5 it will be 6, one for all the attributes)
    public void setName(String n){name = n;}
    public void setICNum(String i){ICNum = i;}
    public void setScore1(double s1){score1 = s1;}
    public void setScore2(double s2) {score2 = s2;}
    public void setScore3(double s3){score3 = s3;}
    
    public void setStudent(String n, String i, double s1, double s2, double s3)
    {
        name = n;
        ICNum = i;
        
        
    }
    
    //getter
    public String getName() {return name;}
    public String getICNum() {return ICNum;}
    public double getScore1() {return score1;}
    public double getScore2() {return score2;}
    public double getScore3() {return score3;}
    
    //toString or Printer method
    public String toString() {
        return ("\nName: " + name + "\n IC: "+ ICNum + "\n Score1: " + score1 + "\n Score2: " + score2 + "\n Score3: " + score3);
    }
    
    //processor method
    public double computeAvg()
    {
        return ( score1 + score2 + score3 ) / 3;
    }
    
    public double highestScore()
    {
        double highestScore = 0;
        
        if (highestScore < score1)
        {
            highestScore = score1;
        }
        if (highestScore < score2)
        {
            highestScore = score2;
        }
        if (highestScore < score3)
        {
            highestScore = score3;
        }
        
        return highestScore;
    }
}
