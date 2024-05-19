
/**
 * Write a description of class Patient here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Patient
{
    private String name;
    private String illness;
    private int yearOfBirth;
    private String gender;
    private double charge;
    
    //default
    public Patient()
    {
        name = null;
        illness = null;
        yearOfBirth = 0;
        gender = null;
        charge = 0.0;
    }
    
    //normal
    public Patient(String n, String i, int y, String g, double c)
    {
        name = n;
        illness = i;
        yearOfBirth = y;
        gender = g;
        charge = c;
    }
    
    //copy
    public Patient(Patient p)
    {
        name = p.name;
        illness = p.illness;
        yearOfBirth = p.yearOfBirth;
        gender = p.gender;
        charge = p.charge;
    }
    
    //Mutators / setters
    public void setName(String n) {name = n;}
    public void setIllness(String i) {illness = i;}
    public void setYearOfBirth(int y) {yearOfBirth = y;}
    public void setGender(String g) {gender = g;}
    public void setCharge(double c) {charge = c;}
    
    //setPatient or setAll basically
    public void setPatient (String n, String i, int y, String g, double c)
    {
        name = n;
        illness = i;
        yearOfBirth = y;
        gender = g;
        charge = c;
    }
    
    //Accessors / getters
    public String getName() {return name;}
    public String getIllness() {return illness;}
    public int getYearOfBirth() {return yearOfBirth;}
    public String getGender() {return gender;}
    public double getCharge() {return charge;}
    
    //toString
    public String toString () {return ("Name: " + name + "\nIllness: " + illness + "\nYear Of Birth: " + yearOfBirth + "\nGender: " + gender + "\n Charge: RM" + charge );}
    
    public boolean isVeteran()
    {
        int currentYear = 2023;
        if ((currentYear - yearOfBirth) > 55)
            return true;
        else 
            return false;
    }
    
    
}
