package entity;


import entity.student;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author thangnv
 */
public class Node {
    public student inf;
    public Node next;

    public Node() {
    }

    public Node(student inf, Node next) {
        this.inf = inf;
        this.next = next;
    }
     public Node(student inf) {
        this.inf = inf;
        this.next = null;
    }

    public String toSring(){
       return inf.toString();
        //return inf.name+" "+inf.Rollnumber+" "+inf.Class+" "+inf.Pt1+" "+inf.Pt2+" "+inf.As1+" "+inf.As2+" "+inf.AT;
    
    }
}
