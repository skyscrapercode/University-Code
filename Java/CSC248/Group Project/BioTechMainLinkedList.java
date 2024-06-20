/**
 * Write a description of class BioTechMainLinkedList here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;
import java.io.*;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
public class BioTechMainLinkedList
{
    public static void main (String args[]) throws IOException
    {
        //Code for reading file input //
        
        File inputFile = new File ("vaccineDetails.txt");
        LinkedList BioTechLL = new LinkedList();
        try{
            
            Scanner inFile = new Scanner (inputFile);
            while(inFile.hasNextLine())
            {
                String s = inFile.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(s,delimiter);
                
                String vName = st.nextToken();
                String vDate = st.nextToken();
                String vType = st.nextToken();
                double vPrice = Double.parseDouble (st.nextToken());
                Boolean vStock = Boolean.parseBoolean (st.nextToken());
                String vID = st.nextToken();
                 
                BioTech bt = new BioTech (vName,vDate,vType,vPrice,vStock,vID);
                BioTechLL.insertAtBack(bt); 
                
            }
            
        }
        catch (Exception e)
        {
            System.out.println(e);
        }
        
        // Let the user choose what they would like to do
        Scanner s = new Scanner(System.in);
        int choice = 0;
        
        
        while (choice != 6)
        {
            while (choice < 1 || choice > 6)
            {
                System.out.println("What would you like to do in BioTech Vaccine's LinkedList System?" + "\n" + "1. Remove certain vaccines information" + "\n" + "2. Search and display any vaccine information" + "\n" + "3. Update any vaccine information" + "\n" + "4. Access and display any vaccine information" + "\n" + "5. Calculate if the vaccine has expired" + "\n" + "6. Exit" );
                choice = s.nextInt();
                
                if (choice < 1 || choice > 6)
                {
                    System.out.println("Wrong Input, Please Input A Number Between 1 and 6");
                }
            }
            
            if (choice == 1)
            {
                //Adam's code
                String str = "", input;
                int index = -1, i = 1;
                boolean notRemoved = true;
                Object obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    str += i + ". " + BT.getVacName() + " " + BT.getVacID() + "\n";
                    i++;
                    obj = BioTechLL.getNext();
                }
                s.nextLine();
                System.out.println("Input the vaccine ID of the vaccine you would like to remove:");
                System.out.println(str);
                input = s.nextLine(); 
                
                Object obj2 = BioTechLL.getFirst();
                while (obj2 != null)
                {
                    BioTech BT = (BioTech) obj2;
                    index++;
                    
                    
                    if (BT.getVacID().equalsIgnoreCase(input))
                    {
                        Object removedNode = BioTechLL.removeChosenNode(index);
                        BioTech removed = (BioTech) removedNode;
                        System.out.println("The data information of: " + removed.toString() + " has been removed");
                        notRemoved = false;
                    }
                    
                    obj2 = BioTechLL.getNext();
                }
                
                if (notRemoved)
                {
                    System.out.println("Wrong Input, Please Input the correct vaccine ID");
                    System.exit(0);
                }
    
                
                int printChoice = 0;
                while (printChoice < 1 || printChoice > 2)
                {
                    System.out.println("Would you like to write the new data in a text file?" +"\n"+ "1.Yes" +"\n"+ "2.No");
                    printChoice = s.nextInt();
                    if (printChoice < 1 || printChoice > 2)
                    {
                        System.out.println("Wrong Input, Please Input either 1 or 2");
                    }
                    
                }
                
                String fileName;
                if (printChoice == 1)
                {
                    System.out.println("What would you like the new file to be named: ");
                    s.nextLine();
                    fileName = s.nextLine();
                    
                    PrintWriter pw = new PrintWriter(new FileWriter(fileName + ".txt"));
                    Object objFile = BioTechLL.getFirst();
                    while (objFile != null)
                    {
                        BioTech BT = (BioTech) objFile;
                        pw.write(BT.toStringToFile());
                        objFile = BioTechLL.getNext();
                    }
                    pw.close();
                    
                    System.out.println("File named " + fileName + ".txt has been created.");
                }
                
                
            }
            else if (choice == 2)
            {
                //Azim's code
                
                int i = 1;
                Object obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    System.out.println(i + "." + BT.getVacID());
                    i++;
                    obj = BioTechLL.getNext();
                }
                
                System.out.println("Enter Vaccine ID you want to search:");
                String search = s.nextLine();
                BioTech found = null;
                
                Object obj1 = BioTechLL.getFirst();
                while(obj1 != null)
                {
                    BioTech b = (BioTech) obj1;
                    if(b.getVacID().equalsIgnoreCase(search))
                    {
                         found = b;
                    }
                    obj1 = BioTechLL.getNext();
                }
                
                if(found != null)
                {
                    System.out.println("Searched Vaccine Information:\n" + found.toString());
                }
                else
                {
                    System.out.println("Information for the Vaccine ID NOT FOUND");
                }
                
            }
            else if (choice == 3)
            {
                //Azim's code
                int i = 1;
                Object obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    System.out.println(i + "." + BT.getVacID());
                    i++;
                    obj = BioTechLL.getNext();
                }
                
                System.out.println("Enter Vaccine ID you want to update:");
                String search2 = s.nextLine();
                boolean indicator = false; 
                BioTech found2 = null;
                
                Object obj1 = BioTechLL.getFirst();
                while(obj1 != null)
                {
                    BioTech b = (BioTech) obj1;
                    if(b.getVacID().equalsIgnoreCase(search2))
                    {
                         indicator = true;
                         found2 = b;
                    }
                    obj1 = BioTechLL.getNext();
                }
                
                if(indicator)
                {
                    System.out.println("What do you want to update?\n[0]Exit\n[1]Vaccine Name\n[2]Vaccine Expiry Date\n[3]Vaccine Type\n[4]Vaccine Price\n[5]Vaccine Stock\n[6]Vaccine ID");
                    int option = s.nextInt();
                    switch (option) {
                        case 1:
                            s.nextLine(); System.out.println("Enter new vaccine name:"); String newname = s.nextLine();
                            found2.setVacName(newname);System.out.println("Update complete!");break;
                        case 2:
                            s.nextLine(); System.out.println("Enter new vaccine Expiry Date:");String newdate = s.nextLine();
                            found2.setVacDate(newdate);System.out.println("Update complete!");break;
                        case 3:
                            s.nextLine(); System.out.println("Enter new vaccine type:");String newtype = s.nextLine();
                            found2.setVacType(newtype);System.out.println("Update complete!");break;
                        case 4:
                            s.nextLine(); System.out.println("Enter new vaccine price:");double newprice = s.nextDouble();
                            found2.setVacPrice(newprice);System.out.println("Update complete!");break;
                        case 5:
                            s.nextLine(); System.out.println("Enter new vaccine stock:");boolean newstock = s.nextBoolean();
                            found2.setVacStock(newstock);System.out.println("Update complete!");break;
                        case 6:
                            s.nextLine(); System.out.println("Enter new vaccine ID:");String newid = s.nextLine();
                            found2.setVacID(newid);System.out.println("Update complete!");break;
                        case 0:
                        default:
                            System.out.println("Exiting without making any updates.");
                            break;
                    }
                    System.out.println("\n" + found2.toString());
                }
                else
                {
                    System.out.println("Information for the Vaccine ID NOT FOUND");
                }
                
                
                int printChoice;
                do
                {
                    System.out.println("Would you like to write the new data in a text file?\n1.Yes\n2.No");
                    printChoice = s.nextInt(); s.nextLine();
                    if(printChoice < 1 || printChoice > 2)
                    {
                        System.out.println("Wrong input, Please input either 1 or 2");
                    }
                }while(printChoice < 1 || printChoice > 2);
                
                if(printChoice == 1)
                {
                    System.out.println("What would you like the new file to be named:");
                    String fileName = s.nextLine();
                    PrintWriter pw  = new PrintWriter(new FileWriter(fileName + ".txt"));
                    obj1 = BioTechLL.getFirst();
                    while(obj1 != null)
                    {
                        BioTech BT = (BioTech) obj1;
                        pw.print(BT.toStringToFile()); 
                        obj1 = BioTechLL.getNext();
                    }
                    pw.close();
                    System.out.println("File named: " + fileName + ".txt has been succesfully created!");
                }
                
            }
            else if (choice == 4)
            {
                //Adam's code
                int i = 1, option = 0;
                String vacID;
                System.out.println("Which vaccine ID would you like to get more information on?"); 
                
                Object obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    System.out.println(i + "." + BT.getVacID());
                    i++;
                    obj = BioTechLL.getNext();
                }
                s.nextLine();
                vacID = s.nextLine();
                obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    
                    if (BT.getVacID().equalsIgnoreCase(vacID))
                    {
                        while (option < 1 || option > 6)
                        {
                            System.out.println("What would you like to access: " +" \n" + "1. Vaccine Name" +"\n"+ "2. Vaccine Date" +"\n"+ "3. Vaccine Type" +"\n"+ "4. Vaccine Price" +"\n"+ "5. Vaccine Stock" +"\n"+ "6. Vaccine ID" );
                            option = s.nextInt();
                            if (option == 1)
                            {
                                System.out.println("The Vaccine Name is: " + BT.getVacName());
                            }
                            else if (option == 2)
                            {
                                System.out.println("The Vaccine Date is: " + BT.getVacDate());
                            }
                            else if (option == 3)
                            {
                                System.out.println("The Vaccine Type is: " + BT.getVacType());
                            }
                            else if (option == 4)
                            {
                                System.out.println("The Vaccine Price is: RM" + BT.getVacPrice());
                            }
                            else if (option == 5)
                            {
                                System.out.println("The Vaccine Stock is: " + BT.getVacStock());
                            }
                            else if (option == 6)
                            {
                                System.out.println("The Vaccine ID is: " + BT.getVacID());
                            }
                            else
                            {
                                System.out.println("Wrong Input, Please Input 1-6");
                            }    
                        }
                    }
                    obj = BioTechLL.getNext();
                }
                
                
                
            }
            else if(choice == 5)
            {
                //iman's code
                
                int i = 1;
                LocalDate currentDate = LocalDate.now();
                s.nextLine();
                System.out.println("Enter Vaccine ID you want to search:");
                
                Object obj = BioTechLL.getFirst();
                while (obj != null)
                {
                    BioTech BT = (BioTech) obj;
                    System.out.println(i + "." + BT.getVacID());
                    i++;
                    obj = BioTechLL.getNext();
                }
                
                String search = s.nextLine();
                
                String inputDate = "";
                BioTech found = null;
                
                
                Object exp = BioTechLL.getFirst();
                while(exp != null)
                {
                    BioTech BT = (BioTech) exp;
                    if(BT.getVacID().equalsIgnoreCase(search))
                    {
                         inputDate = BT.getVacDate();
                         found = BT;
                    }
                    exp = BioTechLL.getNext();
                }
                
                DateTimeFormatter format = DateTimeFormatter.ofPattern("yyyy-MM-dd");
                LocalDate targetDate = LocalDate.parse(inputDate, format);
                System.out.println( "Vaccine ID: " + found.getVacID() + " Vaccine expiry date : " + targetDate + "\nCurrent date : " + currentDate ); 
                long daysBetween = ChronoUnit.DAYS.between(currentDate, targetDate);
                
                if(daysBetween > 0)
                {
                    System.out.println(found.getVacID() + " expires in: " + daysBetween + " days");
                }
                else if (daysBetween == 0)
                {
                    System.out.println("The vaccine expires today");
                }
                else
                {
                    daysBetween = daysBetween * -1;
                    System.out.println(found.getVacID() + " has expired " + daysBetween + " days ago");
                }
            }
            else
            {
                System.exit(0);
            }
            
            choice = 0;
        }
        
    }
}
