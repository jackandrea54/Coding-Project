/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop.rec;

import oop.Shape;

/**
 *
 * @author ADMIN
 */
public class Rectangle extends Shape {

    // CONSTRUCTOR
    public Rectangle() {
        
    }
    public Rectangle(double ed) {
        width = ed;
        height = ed;
    }

    public Rectangle(double w, double h) {
        width = w;
        height = h;
    }
    
    // Private variable
    private double width = 0;
    private double height = 0;

    //method ~ function
    
    //overriding, cung ten method, cung tham so giong het parent, ghi de len method ke thua tu parent
    public double getArea(double w, double h) {
        return w * h;

    }
    
    //overloading, cung ten method nhung khac so luong tham so, hoac kieu du lieu
    public double getArea(double e) {
        return e * e;
    }

//    inherited from Shape
//    public double getPerimeter(double w, double h) {
//        return 2 * (w + h);
//    }
    
    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }
    
}
