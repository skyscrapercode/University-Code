
/**
 * Write a description of class taxpayer here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class taxpayer
{
    private String name;
    private String fileNum;
    private double[] income = new double[12];
    
    //default
    public taxpayer()
    {
        name = null;
        fileNum = null;
    }
    
    //normal
    public taxpayer(String n, String f, double[] in)
    {
        name = n;
        fileNum = f;
        for (int i = 0; i < income.length; i++)
            income[i] = in[i];
    }
    
    //copy
    public taxpayer(taxpayer t)
    {
        name = t.name;
        fileNum = t.fileNum;
        income = t.income;
    }
    
    //mutator 
    public void setName(String n){ name = n;}
    public void setfileNum(String f) {fileNum = f;}
    public void setIncome(double[] i) {
        for (int n = 0; n < i.length; n++)
            income[n] = i[n];
        }
    
    //accessors
    public String getName() {return name;}
    public String getfileNum() {return fileNum;}
    public double[] getIncome() {return income; } 
    
    //toString
    public String toString () {
        String result = "Name: " + name + "\nFile Number: " + fileNum + "\nIncome: ";
        for (int i = 0; i < income.length; i++)
            result += "\nRM" + income[i];   
        return result;
        }
        
    public double calculateTotalIncome()
    {
        double totalIncome = 0;
        
        for (int i = 0; i < income.length; i++ )
        {
             totalIncome += income[i];   
        }
        
        return totalIncome;
    }
    
    public double calculateTax()
    {        
        if (calculateTotalIncome() >= 40000)
            return (calculateTotalIncome() * (5.0/100));
        else
            return (calculateTotalIncome()) * 0;
    }
        
}
