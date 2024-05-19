
/**
 * Write a description of class FileReadDemo here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.Scanner;
import java.io.*;
public class FileReadDemo
{
    public static void main(String args[]) throws IOException {
        
        try {
            
            File fileIN = new File("SomeData.txt");
            Scanner inputFile = new Scanner(fileIN);
            
            while (inputFile.hasNext()) {
                String friendName = inputFile.nextLine();
                
                System.out.println(friendName);
            }
            
            inputFile.close();
            }
        
        catch (FileNotFoundException f) {
                System.out.println(f.getMessage());
        }
    }
}
