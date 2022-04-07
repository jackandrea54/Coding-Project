#include <iostream>
#include <string>
using namespace std;
// pointer  is a variable that stores the memory address as its value.

void modifyPointer();
int main() {
 	string food = "Pizza";  // A food variable of type string
	string* ptr = &food; // A pointer variable, with the name ptr, that stores the address of food
	
 	// Output the value of food (Pizza)
  	cout << food << "\n";  
  	
	// Output the memory address of food 
	cout << &food << "\n";
	
	//Reference: Output the memory address of food with the pointer 
	cout << ptr << "\n";
	
	//However you can also use the pointer to get the value of the valuable	
	// Dereference: Output the value of food with the pointer (Pizza)
	cout << *ptr << "\n";

	/* Note that the * sign can be confusing here, as it does two different things in our code:
		When used in declaration (string* ptr), it creates a pointer variable.
		When not used in declaration, it act as a dereference operator.*/

  return 0;
}


//Note that the type of the pointer has to match the type of the variable you're working with.

void modifyPointer(){
	string food = "Pizza";
	string* ptr = &food;
	// Output the value of food (Pizza)
	cout << food << "\n";
	
	// Output the memory address of food (0x6dfed4)
	cout << &food << "\n";
	
	// Access the memory address of food and output its value (Pizza)
	cout << *ptr << "\n";
	
	// Change the value of the pointer
	*ptr = "Hamburger";
	
	// Output the new value of the pointer (Hamburger)
	cout << *ptr << "\n";
	
	// Output the new value of the food variable (Hamburger)
	cout << food << "\n";
}
