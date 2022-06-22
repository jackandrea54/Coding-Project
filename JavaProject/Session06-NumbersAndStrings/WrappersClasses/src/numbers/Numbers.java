/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numbers;

import java.util.Random;

/**
 *
 * @author ADMIN
 */
public class Numbers {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double i = Math.E;
        // Su dung Math, thuc hien in ra man hinh 1 so ngau nhien trong khoang 10-20
        // Math.random(): [0.0-1.0]
        System.out.println("GIa tri random: " + (Math.round(Math.random() * 10) + 10));

        // Random(10): [0-10)
        Random rand = new Random();
        System.out.println("random number: " + (rand.nextInt(10) + 10));
        Character chObj = new Character('c');
        Character chObj1 = new Character('c');  
        // so sanh 2 object xem co bang nhau khong
        // so sanh 2 gia tri cua 2 object xem co bang nhau hay khong
        //CHU Y: So sanh 2 Object phai dung .equals(), khong dung ==
        if (chObj.equals(chObj1)) {
            System.out.println("2 object is equal");
        } else {
            System.out.println("2 object is NOT the same");
        }
        
        
        chObj1 = chObj;
        chObj = null;
        System.out.println("chObj1 " + chObj1);
        
    }

}
