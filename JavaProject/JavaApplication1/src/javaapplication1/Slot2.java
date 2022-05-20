/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

/**
 * ARRAY
 * 
 */
public class Slot2 {
    public static void main(String[] args) {
        int[] anArray = {1,2,5,7,9};
        //Cach 2:
        int[] x = new int[10];
        x[2] = 10;
        x[4] = 4;
        
        System.out.println("x[9]= " + x[9]);
        System.out.println("x[1] = " + x[1]);
        for (int i = 0; i < x.length; i++) {
            System.out.print("x["+ i +"] = " + x[i] + "\n");
        }
        
        //COPY ARRAY
        char[] copyFrom = { 'd', 'e', 'c', 'a', 'f', 'f', 'e', 'i', 'n', 'a', 't', 'e', 'd' }; 
        char[] copyTo = new char[7]; 
        System.arraycopy(copyFrom, 2, copyTo, 0, 7); 
        System.out.println(new String(copyTo));

    }
}
