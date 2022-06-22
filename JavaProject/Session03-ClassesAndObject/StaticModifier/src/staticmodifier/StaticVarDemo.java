/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package staticmodifier;

/**
 *
 * @author ADMIN
 */
public class StaticVarDemo {
    static int N = 10;
    double xx = -3; 
    int x,y;
    public StaticVarDemo(int xx, int yy){
        this.x = xx;
        this.y = yy; 
    }
    public void setN (int nn){
        N = nn;
    }
    public void output(){
        System.out.println("N: " + N + ", X: " + x + ", Y: " + y);
    }
    static { //Static code run only one time when the first time the class containing them is accessed
        System.out.println("This is a static code lmao: " + N);
    }
    
    public static void staticMethod(){
        int z = 10;
        System.out.println("This is a static method " + z);
    }
    
    
}
