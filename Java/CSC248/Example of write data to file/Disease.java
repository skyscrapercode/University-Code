public class Disease
{
    private String diseaseName;
    private double percentDeath;
    private int year;

    /*** Definition of the other methods including
    normal constructor, mutators, accessors, processors, and
    toString() printer
    ***/
        
    public Disease()
    {
        diseaseName = "";
        percentDeath = 0;
        year=0;
    }
    public Disease(String name,double pd,int y)
    {
        diseaseName = name;
        percentDeath = pd;
        year = y;
    }
    public void setDisease(String name,double pd,int y)
    {
        diseaseName = name;
        percentDeath = pd;
        year = y;
    }
    public String getDiseaseName(){return diseaseName;}
    public double getPercentDeath(){return percentDeath;}
    public int getYear(){return year;}
    
    public String toString(){
        return diseaseName + "\t" + percentDeath + "\t" + year + "\n";
    }
}