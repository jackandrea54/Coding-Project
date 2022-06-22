/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package arraylistdemo;

import java.util.Vector;

/**
 *
 * @author ADMIN
 */
public class VectorDemo {
    public static void main(String[] args) {
        Vector v = new Vector();
        v.add(10);
        v.add("Hello");
        v.add(new Student("Dinh", "Thu Phuong", 19));
        v.add(10);
        
        for (int i = 0; i < v.size(); i++) {
            System.out.println(v.get(i));
        }
    }
}
