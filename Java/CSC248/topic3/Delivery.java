
/**
 * Write a description of class Delivery here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Delivery 
{

    private String driverName;
    private String placeName;
    private String receiverName;
    private int totalPrice;
    private String phoneNumber;
    
    
    //constructors
    
    public Delivery (String dn, String pn, String rn, int tp, String n)
    {
        driverName = dn;
        placeName = pn;
        receiverName = rn;
        totalPrice = tp;
        phoneNumber = n;
    }
    
    //setters
    
    public void setDriverName(String dn) {driverName = dn;}
    public void setPlaceName(String pn) {placeName = pn;}
    public void setReceiverName(String rn) {receiverName = rn;}
    public void setTotalPrice(int tp) {totalPrice = tp;}
    public void setPhoneNumber(String n) {phoneNumber = n;}
    
    //getters
    public String getDriverName() {return driverName;}
    public String getPlaceName() {return placeName;}
    public String getReceiverName() {return receiverName;}
    public int getTotalPrice() {return totalPrice;}
    public String getPhoneNumber() {return phoneNumber;}
    
    //printer
    
    public String toString()
    {
        return ("Driver Name: " + driverName + " Place Name: " + placeName + " Receiver Name: " + receiverName + " Total Price: RM" + totalPrice + " Phone Number: " + phoneNumber + "\n");
    }

}
