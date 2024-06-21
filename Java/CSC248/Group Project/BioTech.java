
/**
 * Write a description of class BioTech here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class BioTech
{
    private String vacName;
    private String vacDate;
    private String vacType;
    private double vacPrice;
    private boolean vacStock;
    private String vacID;
    
    public BioTech(String n, String d, String t, double p, boolean s, String id)
    {
        vacName = n;
        vacDate = d;
        vacType = t;
        vacPrice = p;
        vacStock = s;
        vacID = id;
    }
    
    public String getVacName() {return vacName;}
    public String getVacDate() {return vacDate;}
    public String getVacType() {return vacType;}
    public double getVacPrice() {return vacPrice;}
    public boolean getVacStock() {return vacStock;}
    public String getVacID() {return vacID;}
    
    public void setVacName(String n) {vacName = n;}
    public void setVacDate(String d) {vacDate = d;}
    public void setVacType(String t) {vacType = t;}
    public void setVacPrice(double p) {vacPrice = p;}
    public void setVacStock(boolean s) {vacStock = s;}
    public void setVacID(String id) {vacID = id;}
    
    public String toString()
    {
        return ("\n\t====================================" + "\n" +
                "\t|Vaccine Name: " + vacName + "\n" +
                "\t|Date: " + vacDate + "\n" +
                "\t|Type: " + vacType + "\n" +
                "\t|Price: RM" + vacPrice + "\n" +
                "\t|Stock: " + vacStock + "\n" +
                "\t|ID: " + vacID + "\n" +
                "\t===================================="); 
    }
    
    public String toStringToFile()
    {
        return "\n" + vacName + ";" + vacDate + ";" + vacType + ";" + vacPrice + ";" + vacStock + ";" + vacID;
    }
}
