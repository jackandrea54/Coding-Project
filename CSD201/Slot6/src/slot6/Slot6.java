/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot6;

import java.util.Scanner;

/**
 * RECURSIVE FOR FACTORIAL
 * @author ADMIN
 */
public class Slot6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        long num = sc.nextInt();
        System.out.println("Factorial of "+num +": " + Factorial(num));
    }
    
    public static long Factorial(long n){
        if(n == 1) return n;
        else{
            return n*Factorial(n-1);
        }
        
    }
    
}
