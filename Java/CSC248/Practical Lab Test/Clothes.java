public class Clothes {
    private String brand;
    private String size;
    private double price;

    public Clothes(String brand, String size, double price) {
        this.brand = brand;
        this.size = size;
        this.price = price;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getSize() {
        return size;
    }

    public void setSize(String size) {
        this.size = size;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String toString() {
        return "\nBrand: " + brand + ", \tSize: " + size + ", \tPrice: " + price;
    }
}