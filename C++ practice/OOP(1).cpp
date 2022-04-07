#include <stdio.h>
#include <iostream>
using namespace std;

class MyClass {       // The class
  public:             // Access specifier
    int myNum;        // Attribute (int variable)
    string myString;  // Attribute (string variable)
    
    void myMethod() {  // Method/function defined inside the class
      cout << "Hello World!";
    }
};

int main(){
	MyClass ClassA1;  // Create an object of MyClass
	ClassA1.myMethod();  // Call the method
	
	 // Access attributes and set values
	ClassA1.myNum = 50;
	ClassA1.myString = "Lop 12A1";
	
	//Print values
	cout << ClassA1.myNum << endl;
	cout << ClassA1.myString << endl;
	
	return 0;
}
