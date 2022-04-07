#include <iostream>
#include <string>
using namespace std;
//Operators are used to perform operations on variables and values.

//Arithmetic Operators
int add(){
	int sum1 = 150;
	int sum2 = 200;
	int sum3 = sum1 + sum2; //we use the + operator to add together two values
	return sum3;
}

//Assignment Operators
//The addition assignment operator (+=) adds a value to a variable:
void assign(){
	int x = 20;
	x += 10;
	
	cout << x << endl;
}
void assign2(){
	int x = 5;
	x += 2;
  	cout << x <<endl;
}

/*Comparison Operators
Comparison operators are used to compare two values.

Note: The return value of a comparison is either true (1) or false (0).*/
void compar(){
	int x = 5;
	int y = 3;
	cout << (x > y)<<endl; // returns 1 (true) because 5 is greater than 3
}

/*Logical Operators
Logical operators are used to determine the logic between variables or values:*/
void logic(){
	int x = 5;
  	cout << (x > 3 && x < 10)<<endl; // returns true (1) because 5 is greater than 3 AND 5 is less than 10
  	cout << (x > 3 || x < 4)<< endl; // returns true (1) because one of the conditions are true (5 is greater than 3, but 5 is not less than 4)
  	cout << (!(x > 3 && x < 10))<<endl; // returns false (0) because ! (not) is used to reverse the result
}


int main(){
	logic();
	printf("yo");
	return 0;
}











