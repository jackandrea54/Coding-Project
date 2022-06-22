/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws2;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Q1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        float marks = 0;
        Scanner sc = new Scanner(System.in);
        Utility u = new Utility();
        marks = u.getFloat(sc, "Enter marks (0-10):", 0, 10);
        System.out.println("OUTPUT");
        System.out.printf("%3.1f\n",marks);
    }
    
    
}

class Utility{
    public float getFloat(Scanner sc, String msg, float min, float max){
        float num = 0;
        boolean flag = true;
        while(flag){
            System.out.print(msg);
            num = sc.nextFloat();
            if(num >= min && num <= max) flag = false;
        }
        
        return num;
    }
}