
/**
 * Write a description of class TrainSchedule here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class TrainSchedule
{
    private String code; // e.g AAA123
    private String date; //dd-mm-yyyy
    private String DepTime; // e.g depature time in 24 h format
    private String destination; 
    private String ArrTime; // arrival time 24 h format
    
    public TrainSchedule()
    {
        code = null;
        date = null;
        DepTime = null;
        destination = null;
        ArrTime = null;
    }
    
    public TrainSchedule(String c, String d, String dt, String de, String at)
    {
        code = c;
        date = d;
        DepTime = dt;
        destination = de;
        ArrTime = at;
    }
    
    public String getCode() {return code;}
    public String getDate() {return date;}
    public String getDepTime() {return DepTime;}
    public String getDestination() {return destination;}
    public String getArrTime() {return ArrTime;}
    
    public void setCode(String c) {code = c;}
    public void setDate(String d) {date = d;}
    public void setDepTime(String dt) {DepTime = dt;}
    public void setDestination(String de) {destination = de;}
    public void setArrTime(String at) {ArrTime = at;}
    
    
    public String toString()
    {
        return "Code: " + code + " Date: " + date + " Departure Time: " + DepTime + " Destination: " + destination + " Arrival Time: " + ArrTime;
    }
}
