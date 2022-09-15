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
public class Main {
    public static void main(String[] args) {
        DoubleLinkedList list = new DoubleLinkedList();
        list.addHead(new Node2(1));
        list.addHead(new Node2(2));
        list.addHead(new Node2(4));
//        System.out.println("Add Head");
//        list.display();
        list.addTail(new Node2(15));
        list.addTail(new Node2(16));
        list.addTail(new Node2(17));
        list.display();
        System.out.println("Get: " + list.get(5));
        list.set(2, 3);
        list.display();
        list.delete(2);
        list.display();
        list.delete(1);
        list.display();
    }
}
