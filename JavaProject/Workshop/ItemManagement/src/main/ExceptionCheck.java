/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class ExceptionCheck {
    public static int checkInteger(String msg){
        int n = 0;
        Scanner sc = new Scanner(System.in);
        do{
            try {
                System.out.print(msg);
                n = Integer.parseInt(sc.nextLine());  
            } catch (Exception e) {
                System.out.println("Required integer! ");
            }
        } while(n == 0);
        
        return n;
    }
}
