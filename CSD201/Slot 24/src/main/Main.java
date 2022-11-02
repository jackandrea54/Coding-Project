/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import com.sun.org.apache.xalan.internal.xsltc.util.IntegerArray;
import sort.QuickSort;

/**
 *
 * @author ADMIN
 */
public class Main {
    public static void main(String[] args) {
        QuickSort qSort = new QuickSort();
        qSort.sort(0, qSort.integerArray.length-1);
        qSort.display();
    }
}
