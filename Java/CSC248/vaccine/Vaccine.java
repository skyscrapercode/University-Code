public class Vaccine {
    private String vacNo; //vaccine number e.g. 001, etc
    private double vacPrice; //vaccine price
    private double vacYear; //vaccine produced in 2021, etc
    private String vacType; //Pfizer,Sinovac,AstraZeneca,//Novavax

    //constructors
    public Vaccine(String v,  double vp, double vy, String vt)
    {
        vacNo = v;
        vacPrice = vp;
        vacYear = vy;
        vacType = vt;
    }
    //setters
    
    public void setVaccine(String v,  double vp, double vy, String vt)
    {
        vacNo = v;
        vacPrice = vp;
        vacYear = vy;
        vacType = vt;
    }
    
    public void setVacPrice(double vp)
    {
        vacPrice = vp;
    }
    
    //getters
    public String getVacNo()
    {
        return vacNo;
    }
    
    public String getVacType()
    {
        return vacType;
    }
    
    public double getVacPrice()
    {
        return vacPrice;
    }
    
    public double getVacYear()
    {
        return vacYear;
    }
    
    //printer
    public String toString()
    {
        return "\n vacNo = " + vacNo +
        "\n vacPrice = " + vacPrice +
        "\n vacYear = " + vacYear +
        "\n vacType = " + vacType;
    }
    
}