
/**
 * Write a description of class ZakatUiTMRecepient2021 here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class ZakatUiTMRecepient2021
{
    private String studentName;
    private String studentID;
    private char category;
    private String ICNumber;
    private double amount;
    
    public ZakatUiTMRecepient2021(String sn, String si, char c, String ic, double a)
    {
        studentName = sn;
        studentID = si;
        category = c;
        ICNumber = ic;
        amount = a;
    }
    
    public String getName() {return studentName;}
    public String getID() {return studentID;}
    public char getCategory() {return category;}
    public String getIcNo() {return ICNumber;}
    public double getAmount() {return amount;}
    
    public String toString()
    {
        return "Student Name: " + studentName + " Student ID: " + studentID + " Category: " + category + " IC No: " + ICNumber + " Amount: " + amount;
    }
}
