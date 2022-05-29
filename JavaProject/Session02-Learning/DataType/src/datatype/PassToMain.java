/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datatype;

/**
 *
 * @author ADMIN
 */
public class PassToMain {

    public static void main(String[] args) {
//        double w = Double.parseDouble(args[0]);
//        double h = Double.parseDouble(args[1]);
//        double chuVi = 2*(w + h);
//        System.out.println("chuVi = " + chuVi);
//        System.out.println("String: " + args[2]);   
        int a = 5, b = 10, c;
        if (a < b) {
            c = a + b;
        }
        else{
            c = a - b;
        }
        System.out.println("c = "+ c); // Neu khoi tao biến c rồi để if thì phải có else không thì sẽ lỗi vì máy tính toán rằng có thể sẽ không có giá trị của c.
    }
}
