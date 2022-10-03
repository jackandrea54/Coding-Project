/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot9;

import java.io.IOException;

/**
 *
 * @author ADMIN
 */
public class Main {
    public static void main(String[] args) throws InterruptedException, IOException {
        BSTree tree = new BSTree();
        tree.insert(30);
        tree.insert(10);
        tree.insert(35);
        tree.insert(5);
        tree.insert(20);
        tree.insert(25);
        tree.insert(15);
        
//      ----------------
        System.out.println("BS Tree before rotate:");
        tree.breadth(tree.root);
        System.out.println("");
        System.out.println("BS Tree after rotate:");
//        tree.root = tree.left_right_Rotate(tree.root);
//        tree.insert(3);
//        tree.insert(2);
        tree.balance(tree.root, tree.root);
        tree.breadth(tree.root);
        
//        tree.insert(9);
//        tree.insert(15);
//        tree.insert(5);
//        tree.insert(2);
//        tree.insert(7);
//        tree.insert(6);
//        tree.insert(14);
//        tree.insert(16);
//        tree.insert(10);
//        tree.readFile("data.txt");
//        System.out.println("Pre-order: ");
//        tree.preOrder(tree.root);
//        System.out.println("");
//        System.out.println("In-order: ");
//        tree.inOrder(tree.root);
//        System.out.println("");
//        System.out.println("Post-order: ");
//        tree.postOrder(tree.root);
//        System.out.println("");
//        System.out.println("Breadth-first: ");
//        tree.breadth(tree.root);
//        int x = 44;
//        tree.removeByMerge(x);
//        System.out.println("");
//        System.out.println("Tree after remove " + x + " :");
//        tree.breadth(tree.root);
//        System.out.println("");
//        System.out.println("Do cao cua node chua gia tri " + x +" = "+ tree.height(x));
        
    }
}
