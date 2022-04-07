#include <iostream>
//#include <string>
using namespace std;

void stringOutput(){
	string greeting = "Hello ";
	string greetend = "World";
	string greetFull = greeting + greetend;
	cout << greeting + greetend << endl;
}
void appendString(){
	string firstName = "Jack";
	string lastName = "Andrea";
	string fullName = firstName.append(lastName); //append is faster than +, but for testing use + for easy
	cout << fullName << endl;
}

void length(){
	// Declaring a string object
	int a;
    string str;
    cout << "Nhap so a: ";
    cin >> a ;
    cout << "So a la: " << a << endl;
    cin.ignore();  // thêm vào de xoá bo nho dem, tránh bi trôi lenh
    cout << "Enter a string: ";
    getline(cin, str);
    cout << "You entered: " << str << endl;
     
}


int main(){
	//int x;
	//cout << "Give me a number:" << endl;
	//cin >> x;  // Get user input from the keyboard
	//cout << "Your number is: " << x << endl; //Display the input value
	length();
	return 0;
}
