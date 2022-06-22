/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package data;

/**
 *
 * @author ADMIN
 */
public class Dog {
    
    private String name;
    private int yob;
    private double weight;
    
    public Dog(String name, int yob, double weight) {
        this.name = name;
        this.yob = yob;
        this.weight = weight;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getYob() {
        return yob;
    }

    public void setYob(int yob) {
        this.yob = yob;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    @Override
    public String toString() {
//        String tmpMsg = String.format("|GOGO|%-10s|%4d%4.1f|", name,yob,weight);
//        return tmpMsg;
        
        return String.format("|GOGO|%-10s|%4d|%4.1f|", name,yob,weight);
//        return "Dog{" + "name=" + name + ", yob=" + yob + ", weight=" + weight + '}';
    }
    
    
    
    
}

//class - tuong duong voi khuon, code chinh la cac dac diem ben trong khuon