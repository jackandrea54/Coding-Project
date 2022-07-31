/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import java.util.ArrayList;
import java.util.List;
import data.Student;

/**
 *
 * @author ADMIN
 */
public class StudentManagement {

    public static void main(String[] args) {
        playWithArrayList();
    }

    public static void playWithArrayList() {

        //List arr = new ArrayList(); tui nay dung lon xon du loai con tro
        //Tui dong nhat chi luu con tro Student
        List<Student> arr = new ArrayList();
        //List<Student> arr = new ArrayList<>();
        //List<Student> arr = new ArrayList<Student(); Cac kieu viet nay tuong duong nhau
        arr.add(new Student("SE172456", "Nguyen Dinh Nghia", 2003, 9.0));

        Student s1 = new Student("SE123456", "An Nguyen", 2001, 8.0);
        Student s2 = new Student("SE123459", "Binh Le", 2002, 8.5);
        arr.add(s1);
        arr.add(s2);

        arr.add(s1); //Add trung 1 nguoi vao danh sach,
        //Set thi khong bao loi nhung ma chi lay 1 con tro thoi

        System.out.println("The Student List: ");
        for (int i = 0; i < arr.size(); i++) {
            arr.get(i).showProfile();
        }
        
        arr.remove(1);
        
        System.out.println("The Student List after remove has " + arr.size() + " student(s): ");
        for (Student x : arr) {
            x.showProfile();
        }
        
       
    }
}
