/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.util.Collections;
import java.util.Scanner;
import java.util.StringTokenizer;
import java.util.Vector;

/**
 *
 * @author ADMIN
 */
public class EmpList extends Vector<Employee>{
    Scanner sc = new Scanner(System.in);
    public EmpList(){
        super();
    }
    
    public void AddFromFile(String fName){
        try {
            File f = new File(fName);
            if(!f.exists()) return;
            FileReader fr = new FileReader(f); //read{}
            BufferedReader bf = new BufferedReader(fr); //readLine{}
            String details; 
            while((details = bf.readLine()) != null){
                //Splitiing details into elements
                StringTokenizer stk = new StringTokenizer(details, ",");
                String code = stk.nextToken().toUpperCase();
                String name = stk.nextToken().toUpperCase();
                int salary = Integer.parseInt(stk.nextToken());
                //Create an employee
                Employee emp = new Employee(code, name, salary);
                this.add(emp); //adding this employee to the list
              
            }
            bf.close();
            fr.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
    
    public void saveToFile(String fname){
        if(this.size() == 0){
            System.out.println("Empty list");
            return;
        }
        try {
            File f = new File(fname);
            FileWriter fw = new FileWriter(f); //write()
            PrintWriter pw = new PrintWriter(fw); // println()
            for (Employee x : this) {
                pw.println(x.getCode() + ","+x.getName()+","+x.getSalary());
            }
            pw.close();
            fw.close();
        } 
        catch (Exception e) {
            System.out.println(e);
        }
    }
    
    //Find an employee code
    private int find(String eCode){
        for (int i = 0; i < this.size(); i++) {
            if(this.get(i).getCode().equals(eCode)) return i;
        }
        return -1;
    }
    
    //Add new employess
    public void addNewEmp(){
        String newCode, newName;
        int newSalary;
        int pos;
        boolean valid = true;
        System.out.println("Enter New Employee Details:");
        do {            
            System.out.print("    Code: ");
            newCode = sc.nextLine().toUpperCase();
            pos = find(newCode); //Check if code already exist
            valid = newCode.matches("^E\\d{3}$"); //Pattern: E and 3 digits
            if (pos>=0) System.out.println("    The code is duplicated.");
            if (!valid) System.out.println("    The code must be in format: E and 3 digits");            
        } while(pos>=0 || (!valid) );
        System.out.print("    name: ");
        newName = sc.nextLine().toUpperCase();
        System.out.print("    salary: ");
        newSalary = Integer.parseInt(sc.nextLine());
        this.add(new Employee(newCode, newName, newSalary));
        System.out.println("New Employee has been added! ");
    }
    
    //Remove an employee
    public void removeEmp(){
        String code;
        System.out.print("Enter the code of removed Employee: ");
        code = sc.nextLine().toUpperCase();
        int pos = this.find(code);
        if(pos < 0) System.out.println("This code does not exist.");
        else{
            this.remove(pos);
            System.out.println("The employee "+ code +" has been removed.");
        }
    }
    
    //Promote an employee's salary
    public void promote(){
        String code;
        System.out.print("Enter the code of promoted Employee: ");
        code = sc.nextLine().toUpperCase();
        int pos = this.find(code);
        if(pos < 0) System.out.println("This code does not exist.");
        else{
            int oldSalary = this.get(pos).getSalary();
            int newSalary;
            do {                
                System.out.println("Old salary: "+ oldSalary +", new salary: ");
                newSalary = Integer.parseInt(sc.nextLine());
            } while (newSalary < oldSalary);
            this.get(pos).setSalary(newSalary);
            System.out.println("The employee "+ code +"'s salary has been updated!");           
        }
    }
    
    // Print out the list
    public void print() {
        if (this.size() == 0) {
            System.out.println("Empty LIST!");
            return;
        }
        Collections.sort(this);
        System.out.println("\nEMPLOYEE LIST\n---------------------------------");
        for (Employee x : this) x.print();
    }
}
