import java.util.Scanner;
import java.io.File;            //new statement
import java.util.StringTokenizer;

public class VaccineMainFAOgos22
{
    public static void main(String arg[]){
        //x diperlukan dalam exam bertulis
         File inputFile = new File("VacData.txt");            
         
         //i
         Stack vacStack = new Stack();
         

         //get input data from file
         try {
             Scanner inFile = new Scanner(inputFile); 
             while (inFile.hasNextLine()) {
                String s = inFile.nextLine();
                String delimiter = ";";
                StringTokenizer st = new StringTokenizer(s, delimiter);
                 
                //read from s using st
                String vacNo = st.nextToken();
                double vacPrice = Double.parseDouble(st.nextToken());
                double vacYear = Double.parseDouble(st.nextToken());
                String vacType = st.nextToken();
                             
                Vaccine vc = new Vaccine(vacNo, vacPrice, vacYear, vacType);
                vacStack.push(vc);
              }
            }catch (Exception e)             
            {                                
                System.out.println(e);       
            }
            
        Stack tempStack = new Stack();
        System.out.println("List of vaccine: ");
        System.out.println("=================");
        while(!vacStack.isEmpty()){
            Object obj = vacStack.pop();
            Vaccine vc = (Vaccine) obj;
            tempStack.push(vc);
            
            System.out.println(vc.toString() + "\n");
        }
        
        while(!tempStack.isEmpty()){
            Object obj = tempStack.pop();
            vacStack.push(obj);
        }
        
        
        //Question b i.
        Stack pfStack = new Stack();
        
        while (!vacStack.isEmpty())
        {
            Object obj = vacStack.pop();
            Vaccine v = (Vaccine) obj;
            
            if (v.getVacYear() == 2021)
                pfStack.push(v);
            else
                tempStack.push(v);
                
                
        }
        
        while (!tempStack.isEmpty())
        {
            vacStack.push(tempStack.pop());
        }
        
        System.out.println("Details in PFStack: " + pfStack.print());
        System.out.println("Details in vacStack: " + vacStack.print());
        
        //Question b ii.
        int count = 0;
        double total = 0, avg;
        while (!vacStack.isEmpty())
        {
            Object obj = vacStack.pop();
            Vaccine v = (Vaccine) obj;
            tempStack.push(v);
            if (v.getVacType().equalsIgnoreCase("Sinovac"))
            {
                total += v.getVacPrice();
                count++;
            }
            
        }
        
        while (!pfStack.isEmpty())
        {
            Object obj = pfStack.pop();
            Vaccine v = (Vaccine) obj;
            tempStack.push(v);
            if (v.getVacType().equalsIgnoreCase("Sinovac"))
            {
                total += v.getVacPrice();
                count++;
            }
            
        }
        
        while (!tempStack.isEmpty())
        {
            vacStack.push(tempStack.pop());
        }
        
        avg = total/count;
        
        System.out.println("The average price for Sinovac is RM" + avg);
        
        //Question b iii.
        while (!vacStack.isEmpty())
        {
            Object obj = vacStack.pop();
            Vaccine v = (Vaccine) obj;
            
            if (v.getVacNo().equals("007") && v.getVacType().equalsIgnoreCase("AstraZeneca"))
            {
                v.setVacPrice(1999);
                System.out.println("The updated information: " + v.toString() );
            }
            
            tempStack.push(v);
        }
        
        while (!tempStack.isEmpty())
        {
            vacStack.push(tempStack.pop());
        }
        
        
       }
    }