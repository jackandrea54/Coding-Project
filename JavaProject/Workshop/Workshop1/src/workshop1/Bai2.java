/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package workshop1;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Bai2 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //Input data (number of elements, the elements of the arrays)
        System.out.print("Input number of elements: ");
        int n = sc.nextInt();
        sc.nextLine();
        int[] arr = new int[n];
        System.out.println("Nhap cac phan tu");
        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }
        //Display all elements
        System.out.println("All elements: ");
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }
        //Sort all numbers in ascending order
        sort(arr);
        System.out.println("\nSort all elements in ascending order");
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }
        //Find the maximum value
        System.out.println("\nThe maximum value is: " + findMax(arr));
    }

    public static void sort(int[] arr) {
        int temp;
        for (int i = 0; i < arr.length - 1; i++) {
            for (int j = i; j < arr.length; j++) {
                if (arr[i] > arr[j]) {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    
    public static int findMax(int [] arr){
        int maxInt = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if(maxInt < arr[i]) maxInt = arr[i];
        }
        return maxInt;
    }
}
