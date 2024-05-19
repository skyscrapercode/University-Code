
/**
 * Write a description of class Book here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class Book
{
    private int ISBN_Num;
    private int quantity;
    private double price;
    private String title;
    private String category;
    
    //normal
    public Book()
    {
        ISBN_Num = 0;
        quantity = 0;
        price = 0.0;
        title = null;
        category = null;
    }
    
    //normal
    public Book(int i, int q, double p, String t, String c)
    {
        ISBN_Num = i;
        quantity = q;
        price = 0.0;
        title = t;
        category = c;
    }
    
    //copy
    public Book (Book b)
    {
        ISBN_Num = b.ISBN_Num;
        quantity = b.quantity;
        price = b.price;
        title = b.title;
        category = b.category;
    }
    
    //setters or mutators
    public void setISBN_Num(int i) {ISBN_Num = i;}
    public void setQuantity(int q) {quantity = q;}
    public void setPrice(double p) {price = p;}
    public void setTitle(String t) {title = t;}
    public void setCategory(String c) {category = c;}
    
    //setBook
    public void setBook(int i, int q, double p, String t, String c)
    {
        ISBN_Num = i;
        quantity = q;
        price = p;
        title = t;
        category = c;
    }
    
    //accessors
    public int getISBN_Num() {return ISBN_Num;}
    public int getQuantity() {return quantity;}
    public double getPrice() {return price;}
    public String getTitle() {return title;}
    public String getCategory() {return category;}
    
    //toString
    public String toString() {return "ISBN Number: " + ISBN_Num + "\nQuantity: " + quantity + "\nPrice: RM" + price + "\nTitle: " + title + "\nCategory: " + category; }
}
