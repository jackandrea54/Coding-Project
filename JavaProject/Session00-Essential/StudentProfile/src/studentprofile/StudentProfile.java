/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package studentprofile;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class StudentProfile {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        inputProfile();

    }

    public static void inputProfile() {
        String name, address;
        int yob;
        Scanner sc = new Scanner(System.in);

        System.out.println("Input name: ");
        name = sc.nextLine().toUpperCase();

        System.out.println("Input yob: ");
//        yob = sc.nextInt(); //Để lại \n trong bộ đệm, phải làm sạch bộ đệm sau khi nextInt
//      Cách 1:
//        sc.nextLine(); // Xoa bo dem cho nay
        //Cách 2: Dùng class Wrapper
        yob = Integer.parseInt(sc.nextLine());
        
        System.out.println("Input address: ");
        address = sc.nextLine().toUpperCase();
        
        System.out.println("Here is your profile: ");
        System.out.println("Name: " + name);
        System.out.println("Yob: " + yob);
        System.out.println("Address: " + address);
    }

}
