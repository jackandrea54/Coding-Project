/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package studentsdemo;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class StudentsDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int n;
        System.out.print("Nhap so luong thong tin tu 1-10: ");
        Scanner s = new Scanner(System.in);
        n = s.nextInt();
        s.nextLine();
        Student[] students = new Student[n];
        int young_index = -1;
        int max_year = 0;
        for (int i = 0; i < n; i++) {
            students[i] = new Student();
            System.out.print("----------------------------\nNhap thong tin sinh vien thu " + (i+1) + ":\nNhap ID: ");
            students[i].setId(s.nextInt());
            s.nextLine(); //De lay ki tu newline sau nextInt
            System.out.print("Nhap ten sinh vien: ");
            students[i].setFullname(s.nextLine());
            System.out.print("Nhap sinh nhat sinh vien: ");
            students[i].setBirthday(s.nextLine());
            System.out.print("Nhap dia chi sinh vien: ");
            students[i].setAddress(s.nextLine());
            
            
            int year = Integer.parseInt(students[i].getBirthday().substring(6, 9)); //Lay substring tu vi tri 6 den vi tri 9 roi parse ve Int
            if(year > max_year) {
                max_year = year;
                young_index = i;
            }
        }
        
        System.out.println("Sinh vien tre nhat la: " + students[young_index].getFullname());
    }
    
}
