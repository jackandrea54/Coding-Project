/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot6;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Fibbonaci {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        long num = sc.nextInt();
        for (int i = 0; i <= num; i++) {
            System.out.print(Fibbonaci(i) + " ");
        }
    }
    
    public static int Fibbonaci(int num){
        if(num < 2) return num;
        else{
            return Fibbonaci(num - 1) + Fibbonaci(num-2);
        }
        
    }
}
