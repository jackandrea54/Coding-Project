/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package array;

/**
 *
 * @author ADMIN
 */
public class Student {
    private String ID;
    private String name;
    private int yob;
    private double gpa;

    public Student(String ID, String name, int yob, double gpa) {
        this.ID = ID;
        this.name = name.toUpperCase();
        this.yob = yob;
        this.gpa = gpa;
    }

    
    
    public String getID() {
        return ID;
    }

    public void setID(String ID) {
        this.ID = ID.toUpperCase();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getYob() {
        return yob;
    }

    public void setYob(int yob) {
        this.yob = yob;
    }

    public double getGpa() {
        return gpa;
    }

    public void setGpa(double gpa) {
        this.gpa = gpa;
    }

    @Override
    public String toString() {
        return "Student{" + "ID=" + ID + ", name=" + name + ", yob=" + yob + ", gpa=" + gpa + '}';
    }
    
    public void showProfile(){
        System.out.printf("|%8s|%-25s|%4d|%4.1f|\n",
                            ID, name, yob, gpa);
    }
}
