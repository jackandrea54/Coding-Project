// With function overloading, multiple functions can have the same name with different parameters:
/* Example
int myFunction(int x)
float myFunction(float x)
double myFunction(double x, double y) */
// Note: Multiple functions can have the same name as long as the number and/or type of parameters are different.

#include <iostream>
using namespace std;

int plusFunc(int x, int y) {
  return x + y;
}

double plusFunc(double x, double y) {
  return x + y;
}

int main() {
  int myNum1 = plusFunc(8, 5);
  double myNum2 = plusFunc(4.0, 6.26); //You have to put ".0" to make it a double data type instead of int 
  cout << "Int: " << myNum1 << "\n";
  cout << "Double: " << myNum2;
  return 0;
}

