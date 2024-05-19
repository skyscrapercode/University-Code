
/**
 * Write a description of class Restaurant here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.io.*;
import java.util.*;
import javax.swing.JOptionPane;
public class Restaurant
{
    private String name;
    private String location;
    
    public Restaurant()
    {
        name = null;
        location = null;
    }
    
    public Restaurant(String n, String l)
    {
        name = n;
        location = l;
    }
    
    public Restaurant (Restaurant p)
    {
        name = p.name;
        location = p.location;
    }
    
    public void setName(String n){name = n;}
    public void setLocation(String l){location = l;}
    
    public String getName(){return name;}
    public String getLocation(){return location;}
    
    public void login()
    {
        int choice = 0;
        String line = "", username, password;
        boolean loginCheck = false;
        
        try 
        {
            File f = new File ("restLoginDetails.txt");
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            
            username = JOptionPane.showInputDialog(null,"Username:");
            password = JOptionPane.showInputDialog(null,"Password:");
            
            while ((line = br.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer (line, ";");
                String readUsername = st.nextToken();
                String readPassword = st.nextToken();
                
                if (username.equals(readUsername) && password.equals(readPassword))
                {
                    loginCheck = true;
                    break;
                    
                }
                else
                {
                    loginCheck = false;
                }
            }
            if (loginCheck)
            {
                JOptionPane.showMessageDialog(null,"Welcome back to our restaurant menu system! " + username);
            }
            else
            {
                do
                {
                    JOptionPane.showMessageDialog(null,("Incorrect Login Details, please try again"));
                    
                    username = JOptionPane.showInputDialog(null,"Username:");
                    password = JOptionPane.showInputDialog(null,"Password:");
                    
                    fr = new FileReader(f);
                    br = new BufferedReader(br);
                    while ((line = br.readLine()) != null)
                    {
                        StringTokenizer st = new StringTokenizer (line, ";");
                        String readUsername = st.nextToken();
                        String readPassword = st.nextToken();
                                    
                        if (username.equals(readUsername) && password.equals(readPassword))
                        {
                            loginCheck = true;
                            break;
                        }
                        else
                        {
                            loginCheck = false;
                        }
                    }
                } while (!loginCheck);
                
                
            }
            
            fr.close();
            br.close();
            
        }
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null,"Error opening file","Error",JOptionPane.ERROR_MESSAGE);
        }
        
    }
    
    public void receiptHistory()
    {
        
        String[] str = new String[10];
        int num = 0, input;
        String line = "";
        try{
            
            File f = new File("receiptHistory.txt");
            FileReader fr = new FileReader (f);
            BufferedReader br = new BufferedReader (fr);
            
            while((line = br.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer (line, ";");
                String readCustUsername = st.nextToken();
                String readRestName = st.nextToken();
                String readLocation = st.nextToken();
                String readTime = st.nextToken();
                String readRandomTime = st.nextToken();
                double readcalPrice = Double.parseDouble(st.nextToken());
                double readcalPayment = Double.parseDouble(st.nextToken());
                
                str[num]  = "";
                str[num] += "FoodCheetah \nYour Favourite food Ordering Companion!";
                str[num] += "\n********************************************";
                str[num] += "\n     Customer: " + readCustUsername;
                str[num] += "\n     Restaurant: " + readRestName;
                str[num] += "\n     Location: " + readLocation;
                str[num] += "\n     Order Time: " + readTime;
                str[num] += "\n     Order Will Be Ready By: " + readRandomTime;
                str[num] += "\n     Total Price: RM" + readcalPrice;
                str[num] += "\n     Balance: RM" + readcalPayment; 
                str[num] += "\n********************************************";
                
                num++;
                
                if (num == 9)
                {
                    break;
                }
            }
            
            do
            {
                input = Integer.parseInt(JOptionPane.showInputDialog(null, "Which receipt do you want to see? Input (1 - " + num + "):" ));

                if(input >= 1 && input < 10)
                {
                    JOptionPane.showMessageDialog(null,str[input - 1]);
                }
                else
                {
                    JOptionPane.showMessageDialog(null,"Invalid input");
                }
            }while (input < 1 && input > 10);
        }
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null,"Error opening file","Error",JOptionPane.ERROR_MESSAGE);
        }
    }  
}


