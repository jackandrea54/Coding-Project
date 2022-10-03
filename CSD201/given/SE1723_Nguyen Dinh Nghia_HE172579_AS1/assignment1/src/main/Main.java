package main;

import bo.readfile;
import bo.listStudent;
import ui.Menu;
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author thangnv
 */
public class Main {

    public static void main(String[] args) throws Exception {
        System.out.println("infomation: Yêu cầu điền thông tin của mình vào đây");
        Menu mnu = new Menu();
        Scanner scan = new Scanner(System.in);
        //readfile.viewFile("data.txt");
        listStudent list = new listStudent();

        mnu.add("1. Test f1 (readfile)");
        mnu.add("2. Test f2 (remove a student by rollNumber)");
        mnu.add("3. Test f3 (remove a student by index)");
        mnu.add("4. Test f4 (display all students who can attend PE Exam)");
        mnu.add("5. Test f5 ");
        mnu.add("0. Exit");
        int sel = 0;
        //  System.out.println( list.getIndex("HE123"));
        do {
            sel = mnu.select();
            switch (sel) {
                case 1:
                    int pos = 0;
                    String cl = "";
                    System.out.print("Enter class name: (blank for all class) ");
                    cl = scan.nextLine();
                    if (cl.length() == 0) {
                        cl = "all";
                    }
                    System.out.print("Enter 0 for addHead, 1 for addTail: ");
                    pos = scan.nextInt();
                    scan.nextLine();
                    readfile.readfile("data.txt", list, pos, cl);
                    System.out.println("class = " + cl);
                    break;
                case 2:
                    String rollNumber;
                    System.out.print("Enter rollNumber: ");
                    rollNumber = scan.nextLine().trim();
                    list.remove(rollNumber);
                    list.display();
                    break;
                case 3:
                    int index = 0;
                    System.out.print("Enter index of Studnet want to delete:");
                    index = scan.nextInt();
                    scan.nextLine();
                    list.remove(index);
                    list.display();
                    break;
                case 4:
                    System.out.println("---- All students who can attend PE exam ----");
                    list.takeExam();
                    break;
                case 5:
                    break;
            }
            if (sel == 1) {
                list.display();
            } else if (sel == 2);
            System.out.println("--------------------------------");
            //  System.out.println(sel);
        } while (sel != 0);
    }
}
