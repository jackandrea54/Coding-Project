/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package inheritancerectangle;

/**
 *
 * @author ADMIN
 */
public class Box extends Rectangle {

    private double height;

    public Box(double w, double l, double h) {
        super(w, l);//thay the cho 2 dong ben duoi
//        this.width = w;
//        this.length = l;
        this.height = h;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getArea() {
        //dien tich 2 day: 2* super.getArea();
        //dien tich xung quanh: h * (2 * (w + l));
        return (2 * super.getArea()) + (this.height * (2 * (this.getWidth() + this.getLength())));
    }


    public double getVolume() {
        return super.getArea() * this.height;
    }
}
