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
public class Array {

    public static void main(String[] args) {
//        //Mang 2 chieu trong Java
//        int[][] arr = {{1, 20, 50, 21}, {31, 42, 80, 72}, {58, 63, 100, 999}};    
//        //Vong for trong Java: Kha tuong tu trong C
//        for (int i = 0; i < arr.length; i++) {
//            for (int j = 0; j < arr[i].length; j++) {          
//                //In cac phan tu o vi tri chan
//                if (i % 2 == 0 && j % 2 == 0) {
//                    System.out.print("arr[" + i + "][" + j + "] = " + arr[i][j] + "\n");
//                }
//            }
//        }
//        
        //Enhanced for loop
        int[] anArray = {1, 2, 5, 7, 9};
        for (int x : anArray) {
            x += 1;
            System.out.println("x = " + x);
        }
        // However the enhanced for loop can only read, it can't be used to modify the true array
        for (int i = 0; i < anArray.length; i++) {
            System.out.print("anArray[" + i + "] = " + anArray[i] + "\n");
        }
    }
}
