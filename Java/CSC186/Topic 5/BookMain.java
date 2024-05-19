/**
 * Write a description of class BookMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import javax.swing.JOptionPane;
import java.time.*;
import java.util.Date;
public class BookMain
{
    public static void main (String args[]) 
    {
        int reference = 0;
        String quantitylessthen10 = "", lowestPriceString = "", highestPriceString = "";
        boolean bookFound = false;
        double lowestPrice = 100000, highestPrice = 0;
        
        Book[] bookObject = new Book[5];
        
        Date today = new Date();
       
        for (int i = 0; i < bookObject.length; i++)
        {
            
            bookObject[i] = new Book();
            
            String title = JOptionPane.showInputDialog(null, "What is the title of book " + (i + 1) + ": " );
            String category = JOptionPane.showInputDialog(null, "What is the category of the book, T for Text and R for Reference: ");
            int ISBN_Num = Integer.parseInt(JOptionPane.showInputDialog(null,"What is the ISBN Number: "));
            int quantity = Integer.parseInt(JOptionPane.showInputDialog(null, "What is the Quantity: "));
            double price = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the Price: "));
            
            bookObject[i].setBook(ISBN_Num, quantity, price, title, category);
            
            if (category.equalsIgnoreCase("r"))
            {
                reference++;   
            }
                
            if (bookObject[i].getQuantity() < 10)
            { 
                quantitylessthen10 += "\nISBN Number: " + bookObject[i].getISBN_Num() + " Price: " + bookObject[i].getPrice();
            }
            
            if ( bookObject[i].getPrice() < lowestPrice) 
            {
                lowestPriceString = "";
                lowestPriceString += "\nTitle: " + bookObject[i].getTitle() + "\nPrice: RM"+ bookObject[i].getPrice();
                lowestPrice = bookObject[i].getPrice();
            }
            
            if ( bookObject[i].getPrice() > highestPrice )
            {
                highestPriceString = "";
                highestPriceString += "\nTitle: " + bookObject[i].getTitle() + "\nPrice: RM"+ bookObject[i].getPrice();
                highestPrice = bookObject[i].getPrice();
            }
            
        }
        
        JOptionPane.showMessageDialog(null, "The books with quantity less then 10 is: " + quantitylessthen10 );
        
        String search = JOptionPane.showInputDialog(null, "What book would you like to find: ");
        for (int i = 0; i < bookObject.length; i++)
        {
            if(bookObject[i].getTitle().equalsIgnoreCase(search))
            {
                bookFound = true;
            }
            
            if (bookFound == true)
            {
                JOptionPane.showMessageDialog(null, "Book Found! " + "\nISBN Number: " + bookObject[i].getISBN_Num() + "\nTitle: " + bookObject[i].getTitle());
                break;
            }
        }
        
        JOptionPane.showMessageDialog(null, "The title of Book with the lowest Price is: " + lowestPriceString);
        JOptionPane.showMessageDialog(null, "The title of book with the highest Price is: " + highestPriceString);
        JOptionPane.showMessageDialog(null, "The number of reference books is: " + reference);
        
    }
}
