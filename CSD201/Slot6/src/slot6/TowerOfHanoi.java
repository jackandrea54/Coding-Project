/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot6;

/**
 *  BAI TOAN THAP HA NOI, CHUYEN TOAN BO DIA TU COT 1 SANG COT 2
 * COT 3 SE LA COT TRUNG GIAN
 * @author ADMIN
 */
public class TowerOfHanoi {
    static int count = 0;
    public static void main(String[] args) {
        int n = 5;
        moveDisk(n, 'A', 'B', 'C');
        System.out.println(count);
    }
    
    public static void moveDisk(int n, char cot1, char cot2, char cot3){
        if (n == 1) {
            System.out.println("Move from " + cot1 + " to " + cot2);
        }else{
            moveDisk(n-1, cot1, cot3, cot2);
            moveDisk(1, cot1, cot2, cot3);
            moveDisk(n-1, cot3, cot2, cot1);
        }
        count ++;
        
    }
}
