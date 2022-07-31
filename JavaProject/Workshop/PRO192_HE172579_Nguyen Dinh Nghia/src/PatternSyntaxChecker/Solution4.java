/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PatternSyntaxChecker;

/**
 *
 * @author ADMIN
 */
import java.util.Scanner;
import java.util.regex.*;

public class Solution4
{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int testCases = Integer.parseInt(sc.nextLine());
		while(testCases>0){
			String pattern = sc.nextLine();
          	//Write your code
                        Pattern check = Pattern.compile(pattern);
                        System.out.println(check);
                
                        testCases--;
		}
	}
}

