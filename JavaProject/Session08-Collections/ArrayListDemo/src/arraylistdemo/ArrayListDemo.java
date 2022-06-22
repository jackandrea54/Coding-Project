/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package arraylistdemo;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;

/**
 *
 * @author ADMIN
 */
public class ArrayListDemo {
//Can add anything with any type, except null elements

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        List list = new ArrayList();
        for (int i = 11; i <= 20; i++) {
            list.add(i);
        }
//        Nigga n = null;
//        list.add(n);
        for (int i = 0; i < list.size(); i++) {
            System.out.print(list.get(i) + ", ");
        }
        System.out.println("");
        //Cach 2: Dung Iterator
        System.out.println("Iterator display:");
        Iterator itoIt = list.iterator();
        while (itoIt.hasNext()) {
            System.out.print(itoIt.next() + ", ");
        }
        System.out.println("");

        //Array List voi Object
        List<Student> listStu = new ArrayList<>();
        Student s1 = new Student("Nguyen", "Nghia", 10);
        Student s2 = new Student("Tran", "Hoang", 19);
        listStu.add(s1);
        listStu.add(s2);
        listStu.add(s2);
        listStu.add(s2);
        
        System.out.println("index of s2: " + listStu.indexOf(s2) + ", last index of s2: " + listStu.lastIndexOf(s2));
        for (int i = 0; i < listStu.size(); i++) {
            System.out.println(listStu.get(i) + ", ");
        }
        System.out.println("Iterator display: ");
        Iterator<Student> itoObj = listStu.iterator();
        while (itoObj.hasNext()) {
            System.out.println(itoObj.next());
        }
        
        System.out.println("Cach 3:");
        for (Student s : listStu) {
            System.out.println(s.toString());
        }
        //PRINT THE ARRAY LIST
        System.out.println("THE ARRAY LIST: "+listStu);
    }
    
}

class Nigga {
    
}
