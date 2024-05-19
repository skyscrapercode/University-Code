import java.util.Scanner;
import java.io.File;            
import java.util.StringTokenizer;

public class MainMotivatorFile
{
    public static void main(String arg[]){
        File inputFile = new File("MotivatorData.txt");
        
        //i.    Declaration of an linkedlis list in the main class to store Watch objects;  
        Queue motivatorQ = new Queue();
        
        try {
                 Scanner inFile = new Scanner(inputFile); 
                 while (inFile.hasNextLine()) {
                    String s = inFile.nextLine();
                    String delimiter = ";";
                    StringTokenizer st = new StringTokenizer(s, delimiter);   
          
                    String motivatorID = st.nextToken();          
                    String motivatorName = st.nextToken();          
                    String faculty = st.nextToken();
                    String programmeCode = st.nextToken();        
                    double totalPrice = Double.parseDouble(st.nextToken());
                    
                    // Create Delivery object and add to the LL
                    Motivator m= new Motivator(motivatorID , motivatorName, faculty, programmeCode, totalPrice);  
                    motivatorQ.enqueue(m);
                    }
                }
                catch (Exception e)             
                {                                
                    System.out.println(e);       
                }
                
        //iii.    Display the data of all motivator. - tidak diperlukan dalam soalan
        System.out.println("\nAll Motivator");   
        System.out.println("===============");
        
        Queue qTemp = new Queue();        
        
        // display the list after insert new student      
        System.out.println("\nList of students");
        System.out.println("================");
        while (!motivatorQ.isEmpty()){
            Object obj   = motivatorQ.dequeue();
            Motivator st  = (Motivator) obj;
            qTemp.enqueue(st);              //store data in qTemp
            System.out.println(st.toString() + "\n");                
        }
    
        //move data in qTemp to original queue
        while(!qTemp.isEmpty()){ 
            Object obj = qTemp.dequeue(); 
            motivatorQ.enqueue(obj);
        }
        
        
        int count = 0;
        while (!motivatorQ.isEmpty())
        {
            Object obj = motivatorQ.dequeue();
            Motivator mo = (Motivator) obj;
            qTemp.enqueue(mo);
            
            if (mo.getProgramCode().startsWith("CS"))
            {
                count++;
            }
            
        }
        
        while (!qTemp.isEmpty())
        {
            motivatorQ.enqueue(qTemp.dequeue());
        }
        
        System.out.println("Number of CS motivators: " + count);
        
        double lowestMark = -9999;
        while (!motivatorQ.isEmpty())
        {
            Object obj = motivatorQ.dequeue();
            Motivator mo = (Motivator) obj;
            qTemp.enqueue(mo);
            
            if (mo.getMarks() > lowestMark)
            {
                lowestMark = mo.getMarks();
            }
            
        }
        
        while (!qTemp.isEmpty())
        {
            motivatorQ.enqueue(qTemp.dequeue());
        }
    }
}