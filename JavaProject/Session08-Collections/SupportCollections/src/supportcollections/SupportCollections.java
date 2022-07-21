/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package supportcollections;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;
import java.util.Vector;

/**
 *
 * @author ADMIN
 */
public class SupportCollections {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArrayList ar = new ArrayList();
        Vector v = new Vector();
        Random rd = new Random(); //Maximum value = 50;
        for (int i = 0; i <= 10; i++) {
            ar.add(rd.nextInt(100));
            v.add(rd.nextInt(100));
        }
        System.out.println("ar = "+ar);
        System.out.println("v = "+v);
        boolean dis = Collections.disjoint(ar, v);
        System.out.println("ar and v is dinjunct: "+ dis);
        Collections.addAll(v, ar.toArray());
        System.out.println("After adding, v = " + v);
        int minVal = (int)Collections.min(v);
        int maxVal = (int)Collections.max(v);
        System.out.println("min = "+minVal+", maxVal = "+maxVal);
        int fre = Collections.frequency(v, 10);
        System.out.println("Occurences of 10: " + fre);
        Collections.sort(v);
        System.out.println("After sorting, v = "+ v);
        int pos = Collections.binarySearch(v, 10);
        System.out.println("Position of 10: "+pos);
        Collections.shuffle(v);
        System.out.println("Affter shuffling, v = "+v);
    }
    
}
