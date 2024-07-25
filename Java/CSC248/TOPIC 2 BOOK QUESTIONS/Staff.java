
/**
 * Write a description of class Staff here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Staff
{
    private String name;
    private int staffID;
    private String position; // e.g CEO, EO, Clerk, etc...
    private String department;
    private double monthlySalary;
    
    //default constructor
    public Staff()
    {
        name = null;
        staffID = 0;
        position = null;
        department = null;
        monthlySalary = 0.0;
    }
    
    //normal constructor
    public Staff(String n, int s, String p, String d, double ms)
    {
        name = n;
        staffID = s;
        position = p;
        department = d;
        monthlySalary = ms;
    }
    
    //getters or accessors
    public String getName() {return name;}
    public int getStaffID() {return staffID;}
    public String getPosition() {return position;}
    public String getDepartment() {return department;}
    public double getMonthlySalary() {return monthlySalary;}
    
    //setters or mutators
    public void setName(String n) {name = n;}
    public void setStaffID(int s) {staffID = s;}
    public void setPosition(String p) {position = p;}
    public void setDepartment(String d) {department = d;}
    public void setMonthlySalary(double ms) {monthlySalary = ms;}
    
    public String toString()
    {
        return "Name: " + name + " Staff ID: " + staffID + " Position: " + position + " Department: " + department + " Monthly Salary: RM" + monthlySalary;
    }
}
