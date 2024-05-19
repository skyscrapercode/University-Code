
/**
 * Write a description of class Customer here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;
import java.io.*;
import javax.swing.JOptionPane;
public class Customer
{
    private String username;
    private String password;
    
    public Customer()
    {
        username = null;
        password = null;
    }
    
    public Customer(String u, String p)
    {
        username = u;
        password = p;
    }
    
    public String getUsername() {return username;}
    
    public void login() 
    {
        int choice = 0;
        String line = "";
        boolean loginCheck = false;
        
        try 
        {
            File f = new File("custLoginDetails.txt");
            
            do
            {
                choice = Integer.parseInt(JOptionPane.showInputDialog(null, "Would you like to login or create a new account?" + "\n" + "1. Login" + "\n" + "2. Create a new account"));
                
                if (choice != 1 && choice != 2)
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice please try again");
                }
                
            } while (choice != 1 && choice != 2);
            
            username = JOptionPane.showInputDialog(null,"Username:");
            password = JOptionPane.showInputDialog(null,"Password:");
            
            if (choice == 1)
            {
                FileReader fr = new FileReader(f);
                BufferedReader br = new BufferedReader(fr);
                while ((line = br.readLine()) != null)
                {
                    StringTokenizer st = new StringTokenizer(line, ";");
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
                    JOptionPane.showMessageDialog(null,"Welcome back! " + username); 
                }
                else
                {
                    do
                    {
                        JOptionPane.showMessageDialog(null,"Incorrect Login Details please try again");
                        
                        username = JOptionPane.showInputDialog(null,"Username:");
                        password = JOptionPane.showInputDialog(null,"Password:");
                        
                       
                        fr = new FileReader(f);
                        br = new BufferedReader(fr);
                        while ((line = br.readLine()) != null)
                        {   
                            StringTokenizer st = new StringTokenizer(line, ";");
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
                        
                    }while (!loginCheck);
                    
                    JOptionPane.showMessageDialog(null,"Welcome back! " + username);
                }
                fr.close();
                br.close();
            }
            
            else
            {
                FileWriter login = new FileWriter("custloginDetails.txt", true);
                PrintWriter loginWrite = new PrintWriter(login);
                loginWrite.println(username + ";" + password);
                loginCheck = true;
                JOptionPane.showMessageDialog(null,"Account created successfully!");
                JOptionPane.showMessageDialog(null,"Welcome! " + username);
                loginWrite.close();
                login.close();
            }

            
        }
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null, "Error opening file");
        }
        
    }
}

