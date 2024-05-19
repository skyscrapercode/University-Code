
/**
 * Write a description of class PhotoPrints here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class PhotoPrints
{
    private String method;
    private char paperType;
    private int photoSize;
    private int quantity;
    
    public PhotoPrints(String m, char p, int ps, int q)
    {
        method = m;
        paperType = p;
        photoSize = ps;
        quantity = q;
    }
    
    public void setMethod(String m) {method = m;}
    public void setPaperType(char p) {paperType = p;}
    public void setPhotoSize(int ps) {photoSize = ps;}
    public void setQuantity(int q) {quantity = q;}
    
    public String getMethod() {return method;}
    public char getPaperType() {return paperType;}
    public int getPhotoSize() {return photoSize;}
    public int getQuantity() {return quantity;}
    
    //processor?
    
    public String toString()
    {
        return ("Method: " + method + "\nType of paper: " + paperType + "\nPhoto Size: " + photoSize + "\nQuantity: " + quantity);
    }
}
