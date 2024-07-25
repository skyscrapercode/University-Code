public class Car {

    private String model;
    private double price;


    public Car(String m, double p){
        model =m;
        price = p;
    }

    //getter
    public String getModel(){
        return model;
    }
    public double getPrice(){
        return price;
    }

    //setter
    public void setModel(String m){
        model =m;
    }
    public void setPrice(double p){
        price = p;
    }

    //toString
    public String toString(){
        return "\n\nModel : " + model + "\nPrice : "+  +price;
    }
    
    public String toStringToFile(){
        return "\n" + model + ";"+ price;
    }
}