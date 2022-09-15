/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot2;

/**
 *
 * @author ADMIN
 */
public class Node2 {
    int inf;
    
    Node2 prev, next;
    public Node2() {
    }
    public Node2(int x){
        inf = x;
    }

    public Node2(int x, Node2 p, Node2 q) {
        inf = x;
        next = q;
        prev = p;
    }
}
