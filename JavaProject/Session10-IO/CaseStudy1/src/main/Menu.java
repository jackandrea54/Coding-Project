/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import java.util.Scanner;
import java.util.Vector;

/**
 *
 * @author ADMIN
 */
public class Menu extends Vector<String> {

    public Menu() {
        super();
    }

    void addMenuItem(String S) {
        this.add(S);
    }

    int getUserChoice() {
        int choice;
        for (int i=0; i < this.size();i++) {
                    System.out.println((i+1)+"-"+this.get(i));
                }      
        do {          
            try {
                
                System.out.print("Select 1..6: ");
                Scanner sc = new Scanner(System.in);
                choice = sc.nextInt();
                sc.nextLine();
                return choice;
            } catch (Exception e) {
                System.out.println("Invalid number, please re-enter");
            }

        } while (true);

    }
    
}
