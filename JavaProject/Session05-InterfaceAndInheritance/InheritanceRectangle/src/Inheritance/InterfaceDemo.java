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
public interface InterfaceDemo {

    final int MAXN = 10; //Constant
    int n = 10; // Fields in interface must be initialized

    static public int sqr(int x) {
        return x * x;
    }

    public abstract void m1(); // abstract methods

    abstract public void m2();

    void m3();

    void m4();
}

class A implements InterfaceDemo {

    //overrriding methods
    public void m1() {
        System.out.println("M1");
    }

    public void m2() {
        System.out.println("M2");
    }

    public void m3() { //Default methods of an interface must be overriden as public methods in concrete classes.
        System.out.println("M3");
    }

    public void m4() {
        System.out.println("M4");
    }
}
