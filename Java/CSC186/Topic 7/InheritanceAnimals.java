
/**
 * Write a description of class InheritanceAnimals here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class InheritanceAnimals
{
    public static void main (String args[])
    {
        Dog Charlie;
        Cat Rick;
        boolean hasFur;
        
        Charlie = new Dog("Carnivora", "Canis lupus familiaris", "Charlie", false, "Collie");
        
        String order = JOptionPane.showInputDialog(null, "Enter order :");
        String species = JOptionPane.showInputDialog(null, "Enter the species :");
        String name = JOptionPane.showInputDialog(null, "Enter name of animal :");
        String fur = JOptionPane.showInputDialog(null, "Does it have fur?");
        if (fur.equalsIgnoreCase("yes"))
            hasFur= true;
        else
            hasFur = false;
        hasFur = Boolean.parseBoolean(fur);
        String color = JOptionPane.showInputDialog("Color : ");
        
        Rick = new Cat(order, species, name, hasFur, color);
        
        System.out.println("Dog" + "\n" + Charlie);
        System.out.println("Cat" + "\n" + Rick);
    }
}
