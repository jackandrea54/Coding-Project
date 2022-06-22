/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package inheritancerectangle;

/**
 *
 * @author ADMIN
 */
public class Rectangle {

    private double width;
    private double length;

    public Rectangle(double w, double h) {
        this.width = w;
        this.length = h;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }
    public double getArea(){
        return this.width * this.length;
    }
}
