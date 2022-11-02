/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sort;

import java.util.ArrayList;

/**
 *
 * @author ADMIN
 */
public class RadixSort {
    public static void main(String[] args) {
        int arr[] = { 170, 45, 75, 90, 802, 24, 2, 66 };
        int n = arr.length;
 
        // Function Call
        radixsort(arr, n);
        printArr(arr, n);
    }

    private static void radixsort(int[] arr, int n) {
        ArrayList<Integer> list1[] = new ArrayList[10];       
        for (int i = 0; i < 7; i++) {
            
        }
        
    }

    private static void printArr(int[] arr, int n) {
        for (int i = 0; i < n; i++)
            System.out.print(arr[i] + " ");
    }
}
