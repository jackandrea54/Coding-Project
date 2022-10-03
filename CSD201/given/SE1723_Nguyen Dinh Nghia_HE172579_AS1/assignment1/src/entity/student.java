package entity;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author thangnv
 */
public class student{
    public String name,Class,Rollnumber;
    public double Pt1,Pt2,As1,As2,AT;

    public student() {
    }

    public student(String name, String Rollnumber, String Class, double Pt1, double Pt2, double As1, double As2, double AT) {
        this.name = name;
        this.Class = Class;
        this.Rollnumber = Rollnumber;
        this.Pt1 = Pt1;
        this.Pt2 = Pt2;
        this.As1 = As1;
        this.As2 = As2;
        this.AT = AT;
    }
   public String toString(){
    return name+"  "+Rollnumber+"  "+Class+"  "+Pt1+"  "+Pt2+"  "+As1+"  "+As2+"  "+AT;
}
}