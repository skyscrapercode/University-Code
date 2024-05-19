
/**
 * Write a description of class Employee here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Employee
{
    private String name;
    private int yearOfService;
    private double salary;
    private double increment;
    
    public Employee()
    {
        name = null;
        yearOfService = 0;
        salary = 0;
        increment = 0;
    }
    
    public Employee(String n, int y, double s, double i)
    {
        name = n;
        yearOfService = y;
        salary = s;
        increment = i;
    }
    
    public String getName() {return name;}
    public int getYearOfService() {return yearOfService;}
    public double getSalary() {return salary;}
    public double getIncrement() {return increment;}
    
    public boolean isSenior()
    {
        if (yearOfService >= 10)
            return true;
        else 
            return false;
    }
    
    public double newSalary()
    {
        return (salary + (salary * (increment/100)));
    }
}
