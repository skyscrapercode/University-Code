
/**
 * Write a description of class PlayerMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class PlayerMain
{
    public static void main(String args[]){
        String n, ga, ge, a, r;
        int age,rank;
        
        n = JOptionPane.showInputDialog(null, "Input Name:");
        ga = JOptionPane.showInputDialog(null, "Input Game:");
        ge = JOptionPane.showInputDialog(null, "Input Gender:");
        a = JOptionPane.showInputDialog(null, "Input Age:");
        
        age = Integer.parseInt(a);
        
        r = JOptionPane.showInputDialog(null, "Input Rank:");
        
        rank = Integer.parseInt(r);
        
        Player player1 = new Player();
        Player player2 = new Player(n, ga, ge, age, rank);
        Player player3 = new Player(player2);
        
        System.out.println("Data of player 1");
        System.out.println(player1);
        System.out.println();
        System.out.println("Data of player 2");
        System.out.println(player2);
        System.out.println();
        System.out.println("Data of player 3");
        System.out.println(player3);
        
        
    }
}
