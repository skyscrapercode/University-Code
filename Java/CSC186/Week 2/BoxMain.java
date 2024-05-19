
/**
 * Write a description of class BoxMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;

public class BoxMain
{
    public static void main (String args[])
    {
        String boxName;
        
        double height1 = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the height for box 1:" ));
        double width1 = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the width for box 1:" ));
        
        boxName = JOptionPane.showInputDialog(null, "What is the box 2 name:" );
        
        double height = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the of box 2 height:" ));
        double width = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the of box 2 width:" ));
        double length = Double.parseDouble(JOptionPane.showInputDialog(null, "What is the of box 2 length:" ));
        
        
        
        Box box1 = new Box();
        Box box2 = new Box(boxName, height, width, length);
        Box box3 = new Box(box1);
        
        box1.setWidth(width1);
        box1.setHeight(height1);
        
        System.out.println("Data of box 1");
        System.out.println(box1);
        System.out.println();
        System.out.println("Data of box 2");
        System.out.println(box2);
        System.out.println();
        System.out.println("Data of box 3");
        System.out.println(box3);
        
        System.out.println("Area of box 3");
        System.out.println(box3.calculateArea());
        System.out.println();
        System.out.println("Volume of box 2");
        System.out.println(box2.calculateVolume());
        System.out.println();
        
        if (box1.isSmaller(box2) && box1.isSmaller(box3))
            System.out.println("\n Object1 is smaller. \n Area:" + object1.calculateArea() + "\n Volume:" + object2.calculateVolume() );
        else if ()
        
        System.out.println("Is box 1 smaller? ");
        System.out.println(box1.isSmaller(box2));
        System.out.println();
        System.out.println("Is box 1 a cube");
        System.out.println(box1.isCube());
        System.out.println();
        System.out.println("Is box 2 a cube");
        System.out.println(box2.isCube());
        System.out.println();
        System.out.println("Is box 3 a cube");
        System.out.println(box3.isCube());
        
        
        
        
        
    }
}
