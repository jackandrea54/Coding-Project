/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

/**
 * 1. primitive: int, float, double, long, short, boolean
 * 2. Object: String, Student, Vehicle,..
 * @author ADMIN
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int x = -1;
        System.out.println("-1 << 1 = " + (x<<1) );
        System.out.println("-1 >> 1 = " + (x>>1) );
        System.out.println("-1 >>> 1 = " + (x>>>1) );
        String S = "Hello";
        boolean result = S instanceof String;
        System.out.println("Hello is an instance of String: " + result);
//        Khai bao bien y,z
        float y = 12.3f;
        double z = 123.4;
  
        System.out.println("Float y: " + y);
        System.out.println("Double z: " + z);

    }
    
}
