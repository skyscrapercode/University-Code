
/**
 * Write a description of class FruitMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

//driver class
public class FruitMain
{
    public static void main (String args[]){
        
        //instantiate objects from class Fruit
        
        Fruit fruit1 = new Fruit();
        Fruit fruit2 = new Fruit("Apple", 6.50, 0.5, "orange");
        
        System.out.println("State of fruit1");
        System.out.println(fruit1);
        System.out.println();
        System.out.println("State of fruit2");
        System.out.println(fruit2);
        System.out.println();
        
        fruit1.setFruit("Banana", 4.00, 1, "yellow");
        System.out.println("New state of fruit one");
        System.out.println(fruit1);
        
        String color = fruit2.getColor();
        System.out.println("\n The color of fruit2 is "+ color);
        System.out.println();
        
        Fruit fruit3 = new Fruit(fruit1);
        System.out.println("State of fruit3");
        System.out.println(fruit3);
        
        
    }
}
