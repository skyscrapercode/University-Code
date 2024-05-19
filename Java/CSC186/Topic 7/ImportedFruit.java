
/**
 * Write a description of class ImportedFruit here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class ImportedFruit extends Fruit
{
    private int numOfPermit;
    private int certNum;
    private boolean quarantine;
    private int numOfDaysInQ;
    
    public ImportedFruit(String n, double w, double p, int t, int c, boolean q, int nq)
    {
        super(n,w,p);
        numOfPermit = t;
        certNum = c;
        quarantine = q;
        numOfDaysInQ = nq;
    }
    
    public double calculateFee()
    {
        double totalPermitPrice, totalInspection = 0, totalCompliance = 0, totalQuarantine = 0, totalInspectionWeight, totalComplianceWeight, totalQuarantineWeight;
        
        totalPermitPrice = numOfPermit * 15;
        totalInspectionWeight = super.getWeight();
        totalComplianceWeight = super.getWeight();
        totalQuarantineWeight = super.getWeight();
        
        if (super.getWeight() > 1000)
        {
            totalInspection += 2;
            while (totalInspectionWeight > 0  )
            {
                totalInspection += 1;  
                totalInspectionWeight -= 1000;
            }
            totalCompliance += 2;
            while (totalComplianceWeight > 0  )
            {
                totalCompliance += 1;  
                totalComplianceWeight -= 1000;
            }
        }
        else
        {
            totalInspection = 2;
            totalCompliance = 2;
        }
        
        if (numOfDaysInQ > 0 && quarantine == true)
        {
            while (totalQuarantineWeight > 0  )
            {
                totalQuarantine += 25;
                totalQuarantineWeight -= 1000;
            }
        }
        else
        {
            totalQuarantine = 0;
        }
        
        totalQuarantine = totalQuarantine * numOfDaysInQ;
        
        return (totalPermitPrice + totalInspection + totalCompliance + totalQuarantine);
    }
    
    @Override
    public String toString()
    {
        return ("Name: " + super.getName() + "\nWeight: " + super.getWeight() + "\nPrice: RM" + super.getPrice() + "\nTotal Fee: RM" + calculateFee() );
    }
}
