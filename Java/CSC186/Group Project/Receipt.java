
/**
 * Write a description of class Receipt here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
import java.util.*;
import java.text.*;
import java.io.*;
public class Receipt
{
    // instance variables
    private Customer cust;
    private Restaurant rest;
    private double totalPrice;
    private double pay;
    
    //normal constructor
    public Receipt(Customer c, Restaurant r, double tp, double p)
    {
        cust = c;
        rest = r;
        totalPrice = tp;
        pay = p;
    }
    
    //setter@getter
    public void setPay(double p){pay = p;}
    public double getPay(){return pay;}
    
    //payment calculation
    public double calcPayment()
    {
        return (getPay() - totalPrice);
    }

    //Displaying receipt
     public String printReceipt() 
    {
        Time clock = new Time();
        DecimalFormat df = new DecimalFormat("###.##");
        
        String str = "", randomTime = clock.getRandomTime();
        str += "FoodCheetah \nYour Favourite food Ordering Companion!";
        str += "\n*********************************************";
        str += "\n     Customer: " + cust.getUsername();
        str += "\n     Restaurant: " + rest.getName();
        str += "\n     Location: " + rest.getLocation();
        str += "\n     Order Time: " + clock.getTime();
        str += "\n     Order Will Be Ready By: " + randomTime;
        str += "\n     Total Price: RM" + df.format(totalPrice);
        str += "\n     Balance: RM" + df.format(calcPayment()); 
        str += "\n*********************************************";
        
        try
        {
            FileWriter history = new FileWriter("receiptHistory.txt", true);
            PrintWriter historyWrite = new PrintWriter(history);
            historyWrite.println(cust.getUsername() + ";" + rest.getName() + ";" + rest.getLocation() + ";" + clock.getTime() + ";" + randomTime
             + ";" + df.format(totalPrice) + ";" + df.format(calcPayment()));
            historyWrite.close();
            history.close();
        }
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null,"Error opening file","Error", JOptionPane.ERROR_MESSAGE);
        }
        
        return str;
    }
}