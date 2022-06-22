/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package ws1;

/**
 *
 * @author ADMIN
 */
public class WS1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        boolean result = isPrime(0);
        System.out.println("0? " + result);
        System.out.println("123? " + isPrime(123));
        System.out.println("13? " + isPrime(13));
        System.out.println("101? " + isPrime(101));

    }

    //in cac so ngto tu 1..1000
    public static void printPrimeList() {
        for (int i = 2; i < 1001; i++) {
            if (isPrime(i)) {
                System.out.print(i + " ");
            }
        }
    }

    //Kiem tra 1 so co phai so nguyen to
    public static boolean isPrime(int n) {
        if (n < 2) {
            return false;
        }
        if (n == 2) {
            return true;
        }
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }

        return true;
    }

}
