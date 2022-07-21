/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package arraylistdemo;

import java.util.Comparator;
import java.util.Iterator;
import java.util.TreeSet;

/**
 *
 * @author ADMIN
 */
public class TreeSetDemo {
    public static void main(String[] args) {
        
        TreeSet set = new TreeSet();
//        TreeSet t = new TreeSet<>(Comparator.reverseOrder());  //Sap xep theo thu tu nguoc voi hàm compareTo
        Student s1 = new Student("Nghia", "Nguyen", 80);
        Student s2 = new Student("To", "Quang", 70);
        Student s3 = new Student("Huy", "Dinh", 90);
        
        //MUỐN ADD OBJECT VÀO TREESET THÌ PHẢI IMPLEMENT COMPARABLE<STUDENT> Ở CLASS STUDENT RỒI SỬA LẠI METHOD compareTo()
        set.add(s1);
        set.add(s2);
        set.add(s3);
        set.add(new Student("An", "Le", 90));
        
        Iterator it = set.iterator();
        while (it.hasNext()) {
            System.out.println(it.next());
            
        }

//        System.out.println(t);
    }
}
