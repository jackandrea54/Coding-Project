/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Inheritance;

/**
 *
 * @author ADMIN
 */
public class MainClass {

    public static void main(String[] args) {
        InterfaceDemo obj = new A();
        obj.m1();
        obj.m2();
        obj.m3();
        obj.m4();
        System.out.println("15 x 15=" + InterfaceDemo.sqr(15));
    }
}
