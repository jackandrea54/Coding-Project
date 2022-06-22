/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package staticmodifier;

/**
 *
 * @author ADMIN
 */
public class StaticModifier {
        
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int x = 10;
        StaticVarDemo obj1 = new StaticVarDemo(5, 7);
        StaticVarDemo obj2 = new StaticVarDemo(10, 12);
        System.out.print("Object1 ");       
        obj1.output();
        System.out.print("Object2 ");
        obj2.output();
//        obj1.setN(12345);
        obj2.setN(1690);
        System.out.println("StaticVarDemo static variable N: " + StaticVarDemo.N);
        System.out.print("Object1 ");       
        obj1.output();
        System.out.print("Object2 ");
        obj2.output();
        System.out.println(Math.abs(obj1.x)); // Neu muon dung ham static method thi phai dung Object reference
    }
    
}
