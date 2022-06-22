/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package inheritancerectangle;

/**
 *
 * @author ADMIN
 */
public class InheritanceRectangle {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Box b = new Box(10,15,5);
        System.out.println("DIen tich xung quanh cua khoi hop la: " + b.getArea());
        Box b1 = new Box(2,1,3);
        System.out.println("Dien tich xung quanh b1: " + b1.getArea());
        System.out.println("The tich b1: " + b1.getVolume());
        
        Rectangle r = new Box(0, 0, 0); // Class con (Box) bi convert thanh class cha ( Rectangle) *Nguoc lai thi khong duoc
        //Khi convert class con ve class cha, neu co 2 method cung ten (method bi override) thi se lay method cua class cha.
    }
    
}
