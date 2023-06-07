/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aatest;

/**
 *
 * @author ADMIN
 */
import java.util.*;

public class Main2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();
        int test[][] = new int[t][3];
        int lap_plug[][] = new int[t][4];
        int result[] = new int[t];
        for (int i = 0; i < t; i++) {
            for (int j = 0; j < 3; j++) {
                test[i][j] = sc.nextInt();
            }
        }
        for (int i = 0; i < t; i++) {
            for (int j = 0; j < 4; j++) {
                lap_plug[i][j] = sc.nextInt();
            }
        }
        for (int i = 0; i < t; i++) {
            result[i] = 0;
//            if (result[i] < ) {
//                
//            }
        }
        
    }

}
