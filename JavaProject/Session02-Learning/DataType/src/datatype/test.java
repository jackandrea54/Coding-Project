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
public class test {
    public static void main(String[] args) {
        int x = -1;
        System.out.println("-1 << 1 = " + (x<<1) );
        System.out.println("-1 >> 1 = " + (x>>1) );
        System.out.println("-1 >>> 1 = " + (x>>>1) );
        String S = "Hello";
        boolean result = S instanceof String;
        System.out.println("Hello is an instance of String: " + result);
        //Khai bao bien y,z
        float y = 12.3f;
        double z = 123.4;
  
        System.out.println("Float y: " + y);
        System.out.println("Double z: " + z);
    }
}
