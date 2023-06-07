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

public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        int count = 0, max = 1, min = 1;
        int n = sc.nextInt();
        int t = sc.nextInt();
        HashMap<Integer, Integer> hs = new HashMap();
        int num;
        for (int i = 1; i <= n; i++) {
            num = sc.nextInt();
            if (hs.get(num) != null) {
                hs.put(num, hs.get(num) + 1);
            } else {
                hs.put(num, 1);
            }
        }
        Set keys = hs.keySet();
        for (Iterator iterator = keys.iterator(); iterator.hasNext();) {
            int i = (int) iterator.next();
            if (t >= hs.get(i) * i) {
                t = t - hs.get(i) * i;
                count += hs.get(i);
            } else {
                while (hs.get(i) > 0) {
                    if (t >= i) {
                        t = t - i;
                        count++;
                        hs.put(i, hs.get(i) - 1);
                    } else {
                        break;
                    }
                }
            }
        }
    
        System.out.println(count);
    }

}
