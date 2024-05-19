
/**
 * Write a description of class mathOperators here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
import javax.swing.JOptionPane;
public class mathOperators{
   public static void main(String args[])
    {
    int answer1, answer2, answer3, answer4;
    int  score;
        char  grade;
    answer1   =    4  +   5 ;
    answer2   =    3  -  1 ;
    answer3   =    17  /  4 ;
    answer4   =    17  %  4  ;
    
    String output  =  "  ANSWERS  ";
    output  +=  answer1 ;
    output  +=  answer2 ;
    output  +=  answer3 ;
    output  +=  answer4 ;
    JOptionPane.showMessageDialog(null, output," ex 2.3.2 ",    JOptionPane.INFORMATION_MESSAGE);
    
        String scoreInput =JOptionPane.showInputDialog(null," enter student’s score  :  ");
        score  = Integer.parseInt(scoreInput);

    if  (  score  >=  80  )
    {     grade  =  'A';
              JOptionPane.showMessageDialog(null,"SCORE:"+score +"\n");
              JOptionPane.showMessageDialog(null,"CONGRATULATIONS! YOU RECEIVED  GRADE  :  " + grade + "\n");
    }

    System.exit(0);
    }
  }