
/**
 * Write a description of class FileWriteDemo here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import java.util.Scanner;
import java.io.*;
public class FileWriteDemo
{
    public static void main (String args[]) throws IOException
    {
        String filename;
        String friendName;
        int numFriends;
        
        //Create scanner object for keyboard input
        Scanner keyboard = new Scanner(System.in);
        
        //Get the number of friends
        System.out.println("How many friends do you have?");
        numFriends = keyboard.nextInt();
        
        //Consume the remaining newline character
        keyboard.nextLine();
        
        //Get the filename
        System.out.println("Enter the filename:");
        filename = keyboard.nextLine();
        
        //Open the file
        PrintWriter outputFile = new PrintWriter(filename);
        
        //Get data and write it to the file
        for (int i = 0; i < numFriends; i++)
        {
            //Get the name of a friend
            System.out.println("Enter the name of friend number " + (i + 1) + ":" );
            friendName = keyboard.nextLine();
            
            //Write the name to the file
            outputFile.println(friendName);
        }
        
        outputFile.close();
        System.out.println("Data written to the file.");
    }
}
