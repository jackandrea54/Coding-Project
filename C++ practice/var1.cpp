#include <iostream>
using namespace std;

void func1(){
	int myNum = 15;
	cout << myNum << endl;
}

void func2(){
	int myNum;
	myNum =10;
	cout << myNum << endl;
}

void displayVar(){
	int myAge = 18;
	cout << "I am " << myAge << " years old."<< endl;	
}

void addVar(){
	int x=3;
	int y=5;
	int sum = x + y;
	cout << sum << endl;
}

void declareMulti(){
	//Declare multiple variables of the same type
	int x = 5, y = 10, z = 15;
	cout << x + y + z;
}

int main(){
	func1();
	func2();
	addVar();
	displayVar();
	declareMulti();
	return 0;
}

// Double variable type has decimal --> recommended
/* Example : double myNum = 5.03;
Pretty cool ay? */

/* Other var types:
char myLetter = 'D'; //Character
string myText = "D"; //String (text)
bool myBoolean - true; //Boolean (True or False )
*/

/*
The general rules for constructing names for variables (unique identifiers) are:

Names can contain letters, digits and underscores
Names must begin with a letter or an underscore (_)
Names are case sensitive (myVar and myvar are different variables)
Names cannot contain whitespaces or special characters like !, #, %, etc.
Reserved words (like C++ keywords, such as int) cannot be used as names
*/

/*
When you do not want others (or yourself) to override existing variable values, use the const keyword (this will declare the variable as "constant", which means unchangeable and read-only):
Example: const int myNum = 15; //myNum will always be 15
*/
