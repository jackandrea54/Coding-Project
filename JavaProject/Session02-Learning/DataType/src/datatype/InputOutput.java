/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datatype;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class InputOutput {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in); // Object for the keyboard
        String s = sc.nextLine();
//        int x = sc.nextInt(); // De nhap so nguyen
        int x = Integer.parseInt(sc.nextLine()); // Parse String ve dang Integer
        System.out.println("s = " + s);

        // Lam tron so  34.56789 den 3 con so
//        double x = 34.56789;
//        x *= 1000;
//        double y = Math.round(x);
//        y /= 1000;
//        System.out.println("y = " + y);
        // Cach 2
//        System.out.format("y = %10.3f\n", x);
//        System.out.printf("y = %10.3f\n", x);
        /*
        The key difference between printf and format methods is:
        printf: prints the formatted String into console much like System.out.println() but
        format: method return a formatted String, which you can store or use the way you want.
         */
//        int num = 5;
//        String str = String.format("%03d", num);  // 005
//        System.out.printf("Original number %d, leading with zero : %s\n", num, str);
    }
}
