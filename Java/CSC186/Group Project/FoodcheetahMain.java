
/**
 * Write a description of class FoodcheetahMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.io.*;
import java.util.*;
import javax.swing.JOptionPane;
import java.text.*;
public class FoodcheetahMain
{
    public static void main (String args[]) throws IOException
    {
        try
        {
            String line = "", mainCourse = "", restaurantChoice = "", sides = "", drinks = "", mealsFileName = "", mealAvailableChoice = "";
            int num = 0, mChoice, rChoice, sChoice, dChoice, paymentChoice, choice, availableUp, numObjArr = 0, choiceInput;
            double paymentInput;
            boolean available = false;            
            Restaurant rest = new Restaurant();
            Restaurant [] r = new Restaurant[4];
            MainCourse [] m = new MainCourse[4];
            Sides [] s = new Sides[4];
            Drinks [] d = new Drinks[4];
            DecimalFormat df = new DecimalFormat("###.##");
            
            Scanner in = new Scanner(System.in);
            
            
            
            //Login System for Customer or Restaurant
            
            Customer cust = new Customer();
            
            do
            { 
                choice = Integer.parseInt(JOptionPane.showInputDialog(null, "Welcome to FOODCHEETAH!" + "\n" + "Are you a customer or restaurant?" + "\n" + "1. Customer" + "\n" + "2. Restaurant")); 
                
            } while (choice != 1 && choice != 2);
                
            if (choice == 1)
            {
                cust.login();    
            }
            else 
            {
                rest.login();
                
                do
                {
                    rChoice = Integer.parseInt(JOptionPane.showInputDialog(null,"What would you like to do?" + "\n" + "1. Change availability of meals" + "\n" + "2. See receipt history"));

                    if (rChoice < 1 && rChoice > 2)
                    {
                        JOptionPane.showMessageDialog(null,"Wrong Input please try again");
                    }
                } while (rChoice < 1 && rChoice > 2);
                
                if (rChoice == 1)
                {
                    File fChoice = new File ("restaurant.txt");
                    FileReader frChoice = new FileReader (fChoice);
                    BufferedReader brChoice = new BufferedReader (frChoice);
                                    
                    while((line = brChoice.readLine()) != null)
                    {
                        StringTokenizer st = new StringTokenizer (line, ";");
                        String rName = st.nextToken();
                        String rLocation = st.nextToken();
                            
                        r[num] = new Restaurant(rName, rLocation);
                        num++;
                    }
                    frChoice.close();
                    brChoice.close();
                    
                    for (int i = 0; i < r.length; i++)
                    {
                        restaurantChoice += (i + 1) + "." + r[i].getName() + " " + r[i].getLocation() + "\n"; 
                    }
                    
                    
                    do
                    {
                        rChoice = Integer.parseInt(JOptionPane.showInputDialog(null, restaurantChoice + "\n" + "Which restaurant would you like to change?"));

                        if (rChoice < 1 && rChoice > 4)
                        {
                            JOptionPane.showMessageDialog(null, "Wrong choice please try again");
                        }
                    } while (rChoice < 1 && rChoice > 4);
                    
                    
                    num = 0;
                    
                    if (rChoice == 1)
                    {
                        File f = new File ("meals.txt");
                        FileReader fr = new FileReader (f);
                        BufferedReader br = new BufferedReader (fr);
                        mealsFileName = "meals.txt";
                        while((line = br.readLine()) != null)
                        {
                            StringTokenizer st = new StringTokenizer (line, ";");
                            String readMainCourse = st.nextToken();
                            double readMainCoursePrice = Double.parseDouble(st.nextToken());
                            String readSides = st.nextToken();
                            double readSidesPrice = Double.parseDouble(st.nextToken());
                            String readDrinks = st.nextToken();
                            double readDrinksPrice = Double.parseDouble(st.nextToken());
                            boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                            
                            m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                            s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                            d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                            numObjArr++;
                        }
                        fr.close();
                        br.close();
                    }
                    else if (rChoice == 2)
                    {
                        File f = new File ("meals2.txt");
                        FileReader fr = new FileReader (f);
                        BufferedReader br = new BufferedReader (fr);
                        mealsFileName = "meals2.txt";
                        while((line = br.readLine()) != null)
                        {
                            StringTokenizer st = new StringTokenizer (line, ";");
                            String readMainCourse = st.nextToken();
                            double readMainCoursePrice = Double.parseDouble(st.nextToken());
                            String readSides = st.nextToken();
                            double readSidesPrice = Double.parseDouble(st.nextToken());
                            String readDrinks = st.nextToken();
                            double readDrinksPrice = Double.parseDouble(st.nextToken());
                            boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                            
                            m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                            s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                            d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                            numObjArr++;
                        }
                        fr.close();
                        br.close();
                    }
                    else if (rChoice == 3)
                    {
                        File f = new File ("meals3.txt");
                        FileReader fr = new FileReader (f);
                        BufferedReader br = new BufferedReader (fr);
                        mealsFileName = "meals3.txt";
                        while((line = br.readLine()) != null)
                        {
                            StringTokenizer st = new StringTokenizer (line, ";");
                            String readMainCourse = st.nextToken();
                            double readMainCoursePrice = Double.parseDouble(st.nextToken());
                            String readSides = st.nextToken();
                            double readSidesPrice = Double.parseDouble(st.nextToken());
                            String readDrinks = st.nextToken();
                            double readDrinksPrice = Double.parseDouble(st.nextToken());
                            boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                            
                            m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                            s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                            d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                            numObjArr++;
                        }
                        fr.close();
                        br.close();
                    }
                    else
                    {
                        File f = new File ("meals4.txt");
                        FileReader fr = new FileReader (f);
                        BufferedReader br = new BufferedReader (fr);
                        mealsFileName = "meals4.txt";
                        while((line = br.readLine()) != null)
                        {
                            StringTokenizer st = new StringTokenizer (line, ";");
                            String readMainCourse = st.nextToken();
                            double readMainCoursePrice = Double.parseDouble(st.nextToken());
                            String readSides = st.nextToken();
                            double readSidesPrice = Double.parseDouble(st.nextToken());
                            String readDrinks = st.nextToken();
                            double readDrinksPrice = Double.parseDouble(st.nextToken());
                            boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                                
                            m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                            s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                            d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                            numObjArr++;
                        }
                        fr.close();
                        br.close();
                        
                    }
                    
                    
                    
                    for (int i = 0; i < m.length; i++) 
                    {
                        if (m[i].checkAvailable())
                            mealAvailableChoice += (i + 1) + "." + m[i].getMainCourse() + " Available: Yes " + "\n";
                        else
                            mealAvailableChoice += (i + 1) + "." + m[i].getMainCourse() + " Available: No " + "\n";
                    }
                    
                    do
                    {
                        mChoice = Integer.parseInt(JOptionPane.showInputDialog(null, mealAvailableChoice + "\n" + "Which meal would you like to change availability?"));

                        if (mChoice < 1 && mChoice > 6)
                        {
                             JOptionPane.showMessageDialog(null,"Wrong Input please try again!"); 
                        }
                    } while (mChoice < 1 && mChoice > 6);
                    
                    MainCourse selectedMainCourse = m[mChoice - 1];
                    
                    do
                    {
                        availableUp = Integer.parseInt(JOptionPane.showInputDialog(null,"Do you want to set it available or not available?" +"\n" + "1. Available" +"\n"+ "2. Not Available"));

                        if (availableUp == 1)
                            available = true;
                        else if (availableUp == 2)
                            available = false;
                        else
                            JOptionPane.showMessageDialog(null,"Wrong Input Please try again");
                    } while (availableUp != 1 && availableUp != 2);
                    
                    selectedMainCourse.setAvailable(available);
                    
                    FileWriter mealWrite = new FileWriter(mealsFileName + ".tmp");
                    PrintWriter mealPrint = new PrintWriter(mealWrite);
                    
                    for (int i = 0; i < m.length; i++) 
                    {
                        
                        mealPrint.println(m[i].getMainCourse() + ";" + m[i].getMainCoursePrice() + ";" + s[i].getSides() + ";" + s[i].getSidesPrice() + ";" + d[i].getDrinks() + ";" + d[i].getDrinksPrice() + ";" + m[i].checkAvailable());
                        
                    }
                    

                    mealWrite.close();
                    mealPrint.close();
                    
                    
                    File originalFile = new File(mealsFileName);
                    File tempFile = new File(mealsFileName + ".tmp");
                    
                    originalFile.delete();
                    
                    if (tempFile.renameTo(originalFile)) 
                    {
                        JOptionPane.showMessageDialog(null,"File updated successfully.");
                    } 
                    else 
                    {
                        JOptionPane.showMessageDialog(null,"Error updating/renaming file.");
                    } 
                    
                }
                else
                {
                    rest.receiptHistory();
                }
                
                
                System.exit(0);
            }
            
            
            //Pick Restaurant
            File fChoice = new File ("restaurant.txt");
            FileReader frChoice = new FileReader (fChoice);
            BufferedReader brChoice = new BufferedReader (frChoice);
            
            num = 0;
            
            while((line = brChoice.readLine()) != null)
            {
                StringTokenizer st = new StringTokenizer (line, ";");
                String rName = st.nextToken();
                String rLocation = st.nextToken();
                
                r[num] = new Restaurant(rName, rLocation);
                num++;
            }
            frChoice.close();
            brChoice.close();
            
            for (int i = 0; i < r.length; i++)
            {
                restaurantChoice += (i + 1) + "." + r[i].getName() + " " + r[i].getLocation() + "\n"; 
            }
            

            do
            {
                rChoice = Integer.parseInt(JOptionPane.showInputDialog(null, restaurantChoice + "\n" + "Which restaurant would you like?"));
                
                if (rChoice < 1 && rChoice > 4)
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice please try again");
                }
            } while (rChoice < 1 && rChoice > 4);
            
            
            
            //Order Meals
            
            num = 0;
            if (rChoice == 1)
            {
                File f = new File ("meals.txt");
                FileReader fr = new FileReader (f);
                BufferedReader br = new BufferedReader (fr);
                while((line = br.readLine()) != null)
                {
                    StringTokenizer st = new StringTokenizer (line, ";");
                    String readMainCourse = st.nextToken();
                    double readMainCoursePrice = Double.parseDouble(st.nextToken());
                    String readSides = st.nextToken();
                    double readSidesPrice = Double.parseDouble(st.nextToken());
                    String readDrinks = st.nextToken();
                    double readDrinksPrice = Double.parseDouble(st.nextToken());
                    boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                
                    m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                    s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                    d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                    numObjArr++;
                }
                fr.close();
                br.close();
            }
            else if (rChoice == 2)
            {
                File f = new File ("meals2.txt");
                FileReader fr = new FileReader (f);
                BufferedReader br = new BufferedReader (fr);
                while((line = br.readLine()) != null)
                {
                    StringTokenizer st = new StringTokenizer (line, ";");
                    String readMainCourse = st.nextToken();
                    double readMainCoursePrice = Double.parseDouble(st.nextToken());
                    String readSides = st.nextToken();
                    double readSidesPrice = Double.parseDouble(st.nextToken());
                    String readDrinks = st.nextToken();
                    double readDrinksPrice = Double.parseDouble(st.nextToken());
                    boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                
                    m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                    s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                    d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                    numObjArr++;
                }
                fr.close();
                br.close();
            }
            else if (rChoice == 3)
            {
                File f = new File ("meals3.txt");
                FileReader fr = new FileReader (f);
                BufferedReader br = new BufferedReader (fr);
                while((line = br.readLine()) != null)
                {
                    StringTokenizer st = new StringTokenizer (line, ";");
                    String readMainCourse = st.nextToken();
                    double readMainCoursePrice = Double.parseDouble(st.nextToken());
                    String readSides = st.nextToken();
                    double readSidesPrice = Double.parseDouble(st.nextToken());
                    String readDrinks = st.nextToken();
                    double readDrinksPrice = Double.parseDouble(st.nextToken());
                    boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                
                    m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                    s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                    d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                    numObjArr++;
                }
                fr.close();
                br.close();
            }
            else
            {
                File f = new File ("meals4.txt");
                FileReader fr = new FileReader (f);
                BufferedReader br = new BufferedReader (fr);
                while((line = br.readLine()) != null)
                {
                    StringTokenizer st = new StringTokenizer (line, ";");
                    String readMainCourse = st.nextToken();
                    double readMainCoursePrice = Double.parseDouble(st.nextToken());
                    String readSides = st.nextToken();
                    double readSidesPrice = Double.parseDouble(st.nextToken());
                    String readDrinks = st.nextToken();
                    double readDrinksPrice = Double.parseDouble(st.nextToken());
                    boolean readAvailable = Boolean.parseBoolean(st.nextToken());
                
                    m[numObjArr] = new MainCourse(readMainCourse, readMainCoursePrice, readAvailable);
                    s[numObjArr] = new Sides(readMainCourse, readMainCoursePrice, readAvailable, readSides, readSidesPrice);
                    d[numObjArr] = new Drinks(readMainCourse, readMainCoursePrice, readAvailable, readDrinks, readDrinksPrice);
                    numObjArr++;
                }
                fr.close();
                br.close();
            }
            
            
            if (m[0].category())
            {
                for (int i = 0; i < 2; i++)
                {
                    if (m[i].checkAvailable())
                    {
                        mainCourse += (i + 1) +"." + m[i].getMainCourse() + " RM" + m[i].getMainCoursePrice() + "\n";
                    }
                }
                choiceInput = 1;
            }
            else
            {
                for (int i = 2; i < 4; i++)
                {
                    if (m[i].checkAvailable())
                    {
                        mainCourse += (i - 1) +"." + m[i].getMainCourse() + " RM" + m[i].getMainCoursePrice() + "\n";
                    }
                }
                choiceInput = 0;
            }
            
            
            
            do
            {
                mChoice = Integer.parseInt(JOptionPane.showInputDialog(null, mainCourse + "\n" +"What food would you like?"));
                
                if (mChoice < 1 && mChoice > 4)
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice please try again");
                }
            } while (mChoice < 1 && mChoice > 4);
            
            if (choiceInput == 1)
            {
                mChoice -= 1;
            }
            else
            {
                mChoice += 1;
            }
            
            MainCourse selectedMainCourse = m[mChoice];
            JOptionPane.showMessageDialog(null,"\n" + "You selected: " + selectedMainCourse.getMainCourse() + " RM" + selectedMainCourse.getMainCoursePrice() + "\n");

            
            if (s[0].type())
            {
                for (int i = 0; i < 2; i++)
                {
                    if (m[i].checkAvailable())
                    {
                        sides += (i + 1) +"." + s[i].getSides() + " RM" + s[i].getSidesPrice() + "\n";
                    }
                }
                choiceInput = 1;
            }
            else
            {
                for (int i = 2; i < 4; i++)
                {
                    if (m[i].checkAvailable())
                    {
                        sides += (i - 1) +"." + s[i].getSides() + " RM" + s[i].getSidesPrice() + "\n";
                    }
                }
                choiceInput = 0;
            }
            
            
            Sides sideChosen = new Sides();
            do
            {
                sChoice = Integer.parseInt(JOptionPane.showInputDialog(null, sides + "\n" + "What Sides would you like?"));

                if (sChoice < 1 && sChoice > 6)
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice please try again");
                }
                else
                {
                    if (choiceInput == 1)
                    {
                        sChoice -= 1;
                    }
                    else
                    {
                        sChoice += 1;
                    }
                    sideChosen.setSides(s[sChoice].getSides());
                    sideChosen.setSidesPrice(s[sChoice].getSidesPrice());
                }
            } while (sChoice < 1 && sChoice > 4);
            
            JOptionPane.showMessageDialog(null,"\n" + "You selected: " + sideChosen.getSides() + " RM" + sideChosen.getSidesPrice() + "\n");
            
            
            for (int i = 0; i < m.length; i++)
            {
                if (m[i] != null)
                {
                    if (m[i].checkAvailable())
                    {
                        drinks += (i + 1) +"." + d[i].getDrinks() + " RM" + d[i].getDrinksPrice() + "\n";
                    }    
                }
            }
            
            
            Drinks drinkChosen = new Drinks();
            do
            {
                dChoice = Integer.parseInt(JOptionPane.showInputDialog(null, drinks + "\n" + "What Drinks would you like?"));

                if (dChoice < 1 && dChoice > 6)
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice please try again");
                }
                else
                {
                    drinkChosen.setDrinks(d[dChoice - 1].getDrinks());
                    drinkChosen.setDrinksPrice(d[dChoice - 1].drinkSize());
                }
            } while (dChoice < 1 && dChoice > 4);
            
            
            
            JOptionPane.showMessageDialog(null,"\n" + "You selected: " + drinkChosen.getDrinks() + " RM" + drinkChosen.getDrinksPrice() + "\n");
            
            
            
            double totalPrice = selectedMainCourse.getMainCoursePrice() + sideChosen.getSidesPrice() + drinkChosen.getDrinksPrice();
            
            
            do
            {
                paymentChoice = Integer.parseInt(JOptionPane.showInputDialog(null,"Total To Pay: RM" + df.format(totalPrice) + "\n" + "How would you like to pay?" + "\n" + "1. Cash" + "\n" + "2. FPX" + "\n" + "3. Credit/Debit card"));
    
                if(paymentChoice < 1 && paymentChoice > 3 )
                {
                    JOptionPane.showMessageDialog(null,"Wrong choice Please try again!");
                }
            
            } while(paymentChoice < 1 && paymentChoice > 3);
    
            
            do
            {
                paymentInput = Double.parseDouble(JOptionPane.showInputDialog(null,"Input amount : RM " ));
    
                if(paymentInput < totalPrice)
                {
                    JOptionPane.showMessageDialog(null,"You don't have enough to complete this transcation, please try again");
                    JOptionPane.showMessageDialog(null,"Total To Pay: RM" + df.format(totalPrice));
                }
                
            } while(paymentInput < totalPrice);
            
            Receipt rec = new Receipt(cust, r[rChoice - 1], totalPrice, paymentInput );
            
            rec.setPay(paymentInput);
            
            JOptionPane.showMessageDialog(null,rec.printReceipt());
            
            in.close();
            
        }
        catch (IOException e)
        {
            JOptionPane.showMessageDialog(null,"Error opening file","Error",JOptionPane.ERROR_MESSAGE);
        }
        
    }
}