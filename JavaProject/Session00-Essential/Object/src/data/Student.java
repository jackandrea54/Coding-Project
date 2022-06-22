package data;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author ADMIN
 */
public class Student {
    //biến static chỉ có một vùng ram duy nhất, chỉ được clone 1 lần là lần đầu tiên và được các object dùng chung
    //static là vùng ram duy nhất dùng chung cho mọi object được clone
    //Cấm tuyệt đối dùng static cho các đặc điểm/ hành vi của riêng Object (Ví dụ: Tên, ID, điểm,...)
    //Mọi Object giống nhau trên value đó sẽ ăn theo thằng cuối cùng được gán. Vì xài chung 1 biến, 
    private  String id;
    private  String name;
    private int yob;
    private double gpa;

    public Student(String id, String name, int yob, double gpa) {
        this.id = id;
        this.name = name;
        this.yob = yob;
        this.gpa = gpa;
    }

    public String getId() {
        return id;
    }

//    public void setId(String id) {
//        this.id = id;
//    }
    //Không nên đổi id
    //giống với primary key/identifier bên Database
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
        return String.format("|%8s|%-15s|%4d|%4.1f|", id, name, yob, gpa);
    }
    
    public void showProfile(){
        System.out.printf("|%8s|%-15s|%4d|%4.1f|\n", id, name, yob, gpa);
    }
    

}
