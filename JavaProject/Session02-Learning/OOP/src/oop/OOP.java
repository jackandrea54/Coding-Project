/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oop;

import com.sun.org.apache.xalan.internal.lib.ExsltStrings;
import java.util.Scanner;
import oop.rec.Rectangle;

/**
 *
 * @author ADMIN
 */
public class OOP {
    public static int choice;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//        Rectangle rectA = new Rectangle(12, 15);
//        rectA.setWidth(15);
//        rectA.setHeight(8);
//        System.out.println("rectA width = " + rectA.getWidth());
//        System.out.println("rectA height = " + rectA.getHeight());
//        System.out.println("Perimeter: " + rectA.getPerimeter(rectA.getWidth(), rectA.getHeight()));
//        System.out.println("Area: " + rectA.getArea(rectA.getWidth(), rectA.getHeight()));
//
//        Rectangle square = new Rectangle(6);
//        System.out.println("Square's area: " + square.getArea(square.getHeight()));
//
//        /////////
//        Rectangle rec = new Rectangle();
//        rec.setWidth(3);
//        rec.setHeight(4);
//        System.out.println("w = " + rec.getWidth() + ", h = " + rec.getHeight() + ", perimeter = " + rec.getPerimeter(rec.getWidth(), rec.getHeight()));

        System.out.println("Nhap 1 so tu 1-10: ");
        Scanner input = new Scanner(System.in);
        choice = input.nextInt();
        Student arrObject[] = new Student[choice];
        for (int i = 0; i < choice; i++) {
            System.out.println("Nhap thong tin hoc sinh thu "+(i+1));
            arrObject[i] = new Student();
            System.out.print("Nhap id hoc sinh: ");
            int id = input.nextInt();
            System.out.print("Nhap ten day du cua hoc sinh: ");
            input.nextLine();
            String fullname = input.nextLine();
            System.out.print("Nhap ngay sinh cua hoc sinh: ");
            String birthday = input.nextLine();
            System.out.print("Nhap dia chi cua hoc sinh: ");
            String address = input.nextLine();
            arrObject[i].setData(id, fullname, birthday, address);
            System.out.printf("-------------------------------\n\n");
        }
        
        
//        ExsltStrings.split(birthday, '-')

    }
    
    public void findOldest(Student arrObject[]){
        int birthDate[] = new int[choice];
        int birthMonth[] = new int[choice];
        int birthYear[] = new int[choice];
        String birthparts[] = new String[3];
        for (int i = 0; i < choice; i++) {
            birthparts = arrObject[i].birthday.split("-");        
            birthDate[i] = Integer.parseInt(birthparts[0]);
            birthMonth[i] = Integer.parseInt(birthparts[1]);
            birthYear[i] = Integer.parseInt(birthparts[2]);
        }
        
        
    }

}
