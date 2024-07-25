
/**
 * Write a description of class BioTechMainQueue here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import java.util.*;
import java.io.*;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
public class BioTechMainQueue
{
    public static void main (String args[]) throws IOException
    {
        //Code for reading file input //
        File inputFile = new File ("vaccineDetails.txt");
        Queue BioTechQ = new Queue();
        Queue tempQ = new Queue();
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
                BioTechQ.enqueue(bt); 
                
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
                System.out.println("What would you like to do in BioTech Vaccine's Queue System?" + "\n\t" + 
                                    "====================================================" + "\n\t" +
                                    "|[1] Remove certain vaccines information           |" + "\n\t" + 
                                    "|[2] Search and display any vaccine information    |" + "\n\t" + 
                                    "|[3] Update any vaccine information                |" + "\n\t" + 
                                    "|[4] Access and display any vaccine information    |" + "\n\t" + 
                                    "|[5] Calculate if the vaccine has expired          |" + "\n\t" + 
                                    "|[6] Exit                                          |" + "\n\t" +
                                    "====================================================");
                System.out.print("\n\t                  = ");
                choice = s.nextInt();
                
                if (choice < 1 || choice > 6)
                {
                    System.out.println("Wrong Input, Please Input A Number Between 1 and 6");
                }
            }
            
            if (choice == 1)
            {
                //Adam's code
                s.nextLine();
                String str = "", input;
                int i = 1;
                boolean notRemoved = true;
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    str += "[" + i + "] " + BT.getVacID() + "\n";
                    i++;
                    tempQ.enqueue(BT);
                }
                
                while (!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
                System.out.println("Which vaccine ID would you like to remove:");
                System.out.println("==========================================");
                System.out.println(str);
                System.out.println("==========================================");
                System.out.print("\n\t                  = ");
                input = s.nextLine(); 
                
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    
                    if (BT.getVacID().equalsIgnoreCase(input))
                    {
                        System.out.println("The below vaccine information has been removed: " + BT.toString());
                        notRemoved = false;
                    }
                    else
                    {
                        tempQ.enqueue(BT);
                    }
                }
                
                while (!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
                int printChoice = 0;
                
                if (notRemoved)
                {
                    System.out.println("Wrong Input, Please Input the correct vaccine ID");
                    printChoice = 2;
                }
                else
                {
                    while (printChoice < 1 || printChoice > 2)
                    {
                        System.out.println("\tWould you like to write the new data in a text file?\n" +
                                                "\t======================================================\n" +
                                                "\t|              [1]Yes              [2]No             |\n" +
                                                "\t======================================================");
                            System.out.print("\n\t                  = ");
                        printChoice = s.nextInt();
                        if (printChoice < 1 || printChoice > 2)
                        {
                            System.out.println("Wrong Input, Please Input either 1 or 2");
                        }
                        
                    }    
                }
                
                
                String fileName;
                if (printChoice == 1)
                {
                    System.out.println("\tWhat would you like the new file to be named: ");
                    System.out.println("\t==============================================");
                    System.out.print("\n\t                  = ");
                    s.nextLine();
                    fileName = s.nextLine();
                    
                    PrintWriter pw = new PrintWriter(new FileWriter(fileName + ".txt"));
                    while (!BioTechQ.isEmpty())
                    {
                        Object objFile = BioTechQ.dequeue();
                        BioTech BT = (BioTech) objFile;
                        pw.write(BT.toStringToFile());
                        tempQ.enqueue(BT);
                    }
                    pw.close();
                    
                    System.out.println("\tFile name " + fileName + ".txt has been created.");
                    System.out.println("\t===============================================");
                    
                    while (!tempQ.isEmpty())
                    {
                        BioTechQ.enqueue(tempQ.dequeue());
                    }
                }               
            }
            else if (choice == 2)
            {
                //Azim's code
                s.nextLine();
                int i = 1;
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    System.out.println("[" + i + "] " + BT.getVacID());
                    i++;
                    tempQ.enqueue(BT);
                }
                
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
                System.out.println("\tEnter the Vaccine ID you want to search:");
                System.out.println("\t==============================================");
                System.out.print("\n\t                  = ");
                String search = s.nextLine(); 
                BioTech found = null;
                while(!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech bi = (BioTech) obj;
                    if(bi.getVacID().equalsIgnoreCase(search))
                    {
                        found = bi;
                    }
                    tempQ.enqueue(bi);
                }
                
                if(found != null)
                {
                    System.out.println("Information for the searched vaccine ID:\n" + found.toString());
                }
                else
                {
                    System.out.println("Information for the Vaccine ID NOT FOUND");
                }
                
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
            }
            else if (choice == 3)
            {
                //Azim's code
                s.nextLine();
                int i = 1, option = 0;
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    System.out.println("[" + i + "] " + BT.getVacID());
                    i++;
                    tempQ.enqueue(BT);
                }
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
                System.out.println("\tEnter Vaccine ID you want to update:");
                System.out.println("\t=====================================");
                System.out.print("\n\t                  = ");
                String search2 = s.nextLine();
                boolean indicator = false; BioTech found2 = null;
                while(!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech bi = (BioTech) obj;
                    if(bi.getVacID().equalsIgnoreCase(search2))
                    {
                        indicator = true;
                        found2 = bi;
                    }
                    tempQ.enqueue(bi);
                }
                if(indicator)
                {
                    System.out.println("\tWhat do you want to update?\n" +
                                        "\t================================" + "\n" +
                                        "\t|[0]Exit                       |\n" + 
                                        "\t|[1]Vaccine Name               |\n" +
                                        "\t|[2]Vaccine Expiry Date        |\n" +
                                        "\t|[3]Vaccine Type               |\n" +
                                        "\t|[4]Vaccine Price              |\n" +
                                        "\t|[5]Vaccine Stock              |\n" +
                                        "\t|[6]Vaccine ID                 |\n" +
                                        "\t================================");
                    System.out.print("\n\t                  = ");
                    option = s.nextInt();
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
                    
                    
                    int printChoice = 0;
                    if (option != 0)
                    {
                        System.out.println("\n" + found2.toString());
                        do
                        {
                            System.out.println("\tWould you like to write the new data in a text file?\n" +
                                                "\t======================================================\n" +
                                                "\t|              [1]Yes              [2]No             |\n" +
                                                "\t======================================================");
                            System.out.print("\n\t                  = ");
                            printChoice = s.nextInt(); s.nextLine();
                            if(printChoice < 1 || printChoice > 2)
                            {
                                System.out.println("Wrong input, Please input either 1 or 2");
                            }
                        }while(printChoice < 1 || printChoice > 2);   
                    }
                
                    if(printChoice == 1)
                    {
                        System.out.println("\tWhat would you like the new file to be named:");
                        System.out.println("\t===============================================");
                        System.out.print("\n\t                  = ");
                        String fileName = s.nextLine();
                        PrintWriter pw  = new PrintWriter(new FileWriter(fileName + ".txt"));
                        while(!tempQ.isEmpty())
                        {
                            Object obj = tempQ.dequeue();
                            BioTech BT = (BioTech) obj;
                            pw.print(BT.toStringToFile()); 
                            BioTechQ.enqueue(obj);
                        }
                        pw.close();
                        System.out.println("\tFile named: " + fileName + ".txt has been successfully created!");
                    }
                }
                else
                {
                    System.out.println("Information for the Vaccine ID NOT FOUND");
                }
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
            }
            else if (choice == 4)
            {
                //Adam's code
                int i = 1, option = 0;
                String vacID;
                boolean found = false;
                System.out.println("Which vaccine ID would you like to get more information on:");
                System.out.println("===========================================================");
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    System.out.println("[" + i + "] " + BT.getVacID());
                    i++;
                    tempQ.enqueue(BT);
                }
                
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                s.nextLine();
                System.out.print("\n\t                  = ");
                vacID = s.nextLine();
                
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    tempQ.enqueue(BT);
                    if (BT.getVacID().equalsIgnoreCase(vacID))
                    {
                        found = true;
                        while (option < 1 || option > 6)
                        {
                            System.out.println("\tWhat do you want to search?\n" +
                                        "\t================================" + "\n" +
                                        "\t|[0]Exit                       |\n" + 
                                        "\t|[1]Vaccine Name               |\n" +
                                        "\t|[2]Vaccine Expiry Date        |\n" +
                                        "\t|[3]Vaccine Type               |\n" +
                                        "\t|[4]Vaccine Price              |\n" +
                                        "\t|[5]Vaccine Stock              |\n" +
                                        "\t|[6]Vaccine ID                 |\n" +
                                        "\t================================");
                            System.out.print("\n\t                  = ");
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
                            else if (option == 0)
                            {
                                System.out.println("Exiting without searching");
                                break;
                            }
                            else
                            {
                                System.out.println("Wrong Input, Please Input 1-6");
                            }
                        }
                    }
                }
                
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                
                if (!found)
                    {System.out.println("Information for the Vaccine ID NOT FOUND");}
            }
            else if (choice == 5)
            {
                //iman's code
                int i = 1;
                LocalDate currentDate = LocalDate.now();
                s.nextLine();
                System.out.println("Enter Vaccine ID you want to check expiry:");
                System.out.println("==========================================");
                while (!BioTechQ.isEmpty())
                {
                    Object obj = BioTechQ.dequeue();
                    BioTech BT = (BioTech) obj;
                    System.out.println("[" + i + "] " + BT.getVacID());
                    i++;
                    tempQ.enqueue(BT);
                }
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
                }
                System.out.print("\n\t                  = ");
                String search = s.nextLine();
                String inputDate = "";
                BioTech found = null;
                
                while(!BioTechQ.isEmpty())
                {
                    BioTech BT = (BioTech) BioTechQ.dequeue();
                    tempQ.enqueue(BT);
                    if(BT.getVacID().equalsIgnoreCase(search))
                    {
                         inputDate = BT.getVacDate();
                         found = BT;
                    }
                }
                while(!tempQ.isEmpty())
                {
                    BioTechQ.enqueue(tempQ.dequeue());
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
                System.out.println("Thank you for using our system, goodbye!");
                System.exit(0);
            }
            choice = 0;
        }
    }
}

