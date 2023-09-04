/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package fsofttest;

/**
 *
 * @author ADMIN
 */
public class FSoftTest {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic her
        int arr[] = new int[]{3,4,4,4};
        vasu(4, arr);
    }

    public static int vasu(int n, int[] a) {
        int maxSum = 0;
        int temp;
        temp = maxSum;
        for (int i = a.length - 1; i >= 0; i--) {
            if (a[i] >= 0) {
                temp += a[i];
            }
            if(temp > maxSum){
                maxSum = temp;
            }
            for (int j = 0; j < i; j++) {
                 a[j] = a[j] - 1;
//                System.out.println("I:" + i + "; a[j] = " + a[j]);
            }
        }
//        System.out.println(maxSum);
        return maxSum;
    }

    public static int kumab(int n) {
        int emptybottle = 0;
        int promotional = 0;
        int extra = 0;
        int totalBeer = n;
        while (n >= 10) {
            promotional = (n / 10) * 3;
//            System.out.println("promo:"+promotional);
            totalBeer += promotional;
//            System.out.println(totalBeer);
            n = n % 10 + promotional;
            promotional = n;
//            System.out.println(n);
        }

//        System.out.println("N:" + n);
//        System.out.println("extra:" + extra);
//        System.out.println("promo:"+promotional);
//        System.out.println(totalBeer);
        return totalBeer;
    }
}
