/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CheckingPrime;

/**
 *
 * @author ADMIN
 */
import java.io.*;
import static java.lang.System.in;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.reflect.*;

class Prime {
    
    static boolean isPrime(int n)
    {
        // Corner case
        if (n <= 1)
            return false;
        if (n <= 3)
            return true;
  
        // This is checked so that we can skip
        // middle five numbers in below loop
        if (n % 2 == 0 || n % 3 == 0)
            return false;
  
        for (int i = 5; i * i <= n; i = i + 6)
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
  
        return true;
    }
    
    public static void checkPrime(int... arr) {
        for (int i : arr) {
            if(isPrime(i)) System.out.print(i + " ");
        }
        System.out.println("");
    }
}

public class Solution6 {

    public static void main(String[] args) {
        try {
            BufferedReader br = new BufferedReader(new InputStreamReader(in));
            Random rand = new Random();
            int n = rand.nextInt();
            Prime ob = new Prime();

            Prime.checkPrime(9, 10, 32, 89, 66);
            Prime.checkPrime(19, 78, 98, 100, 787, 8989, 12817, 11, 192);
            Prime.checkPrime(90, 2, 31, 890, 8278, 87892, 12, 10);
            Method[] methods = Prime.class.getDeclaredMethods();
            Set<String> set = new HashSet<>();
            boolean overload = false;
            for (int i = 0; i < methods.length; i++) {
                if (set.contains(methods[i].getName())) {
                    overload = true;
                    break;
                }
                set.add(methods[i].getName());

            }
            if (overload) {
                throw new Exception("Overloading not allowed");
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
