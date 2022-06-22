/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nghia.main;

import nghia.util.MyToys;

/**
 *
 * @author ADMIN
 */
public class Stage {
    public static void main(String[] args) {
        System.out.println("PI: "+MyToys.PI);
        
        int width = MyToys.getAnInteger("Vui long nhap chieu rong: ");
        int length = MyToys.getAnInteger("Vui long nhap chieu dai: ");
        System.out.println("Width: " + width);
        System.out.println("Length: "+length);
    }
}
