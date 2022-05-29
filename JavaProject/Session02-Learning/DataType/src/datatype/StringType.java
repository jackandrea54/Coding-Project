/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datatype;

/**
 *
 * @author ADMIN
 */
public class StringType {

    public static void main(String[] args) {
//        String name = "Nguyen Dinh";
//        // Nối chuỗi kí tự
//        name += " Nghia ";
//        name += 5; // Do 5 la int ma string thi data type cao hon nen 5 bi chuyen thanh dang string
//        name = name.concat(" + xyz")
//        System.out.println("My name is " + name);

        // Type conversion and Explicit Casting 
        int x = 42;
        double y = (Double.valueOf(x)); // Phải dùng Class để ép kiểu, không như C dùng function //Widening conversion
        double t = 3.4444;
        x = (int)t; // Narrowing conversion, possible loss of precision ( Must use explicit casting) 
        System.out.println("y = " + y);
        System.out.println("x = " + x);
    }
}
