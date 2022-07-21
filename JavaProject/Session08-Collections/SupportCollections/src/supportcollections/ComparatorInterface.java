/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package supportcollections;

import static java.nio.file.Files.list;
import java.util.ArrayList;
import java.util.Collections;
import static java.util.Collections.list;
import java.util.Comparator;
import java.util.List;

/**
 *
 * @author ADMIN
 */
public class ComparatorInterface {
    public static void main(String[] args) {
        ArrayList<Employee> listEmployees = new ArrayList<Employee>();
       listEmployees.add(new Employee("ID072","Michel",480));
       listEmployees.add(new Employee("ID001","Hanam",250));
       listEmployees.add(new Employee("ID004","Nghia",480));
        System.out.println("Sorting on IDs ascending");
        Collections.sort(listEmployees);
        System.out.println(listEmployees);
        System.out.println("Sorting descending salary then ascending IDs");
        Collections.sort(listEmployees, Employee.compareObj);
        System.out.println(listEmployees);
    }
}

class Employee implements Comparable {
    String ID = "", name = "";
    int salary = 0;
    public Employee(String id, String n, int s){
        ID = id;
        name = n;
        salary = s;
    }

    @Override
    public String toString() {
        return "Employee{" + "ID=" + ID + ", name=" + name + ", salary=" + salary + '}';
    }
    
    @Override
    public int compareTo(Object emp) {
        return ID.compareTo( ((Employee)emp).ID );
    }
    
    //Create an annoymous object compareObj from Comparator interface to compare 2 employees
    public static Comparator compareObj = new Comparator() {
        @Override
        public int compare(Object e1, Object e2) {
            Employee emp1 = (Employee) e1;
            Employee emp2 = (Employee) e2;
            int d = emp1.salary - emp2.salary;
            if(d>0) return -1; //lower salary -> move upper
            if(d==0) return emp1.ID.compareTo(emp2.ID);
            return 1;
        }
    };
        
    
}