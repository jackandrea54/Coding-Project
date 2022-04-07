#include <iostream>
#include <string>
using namespace std;
// You can also use a default parameter value, by using the equals sign (=).
//If we call the function without an argument, it uses the default value ("Norway"):

void myFunction(string country = "Norway") {
  cout << country << "\n";
}
void myFunction2(string fname, int age);

int main() {
  myFunction("Sweden");
  myFunction("India");
  myFunction();
  myFunction("USA");
  

  myFunction2("Liam", 3);
  myFunction2("Jenny", 14);
  myFunction2("Anja", 30); 
   return 0;
}
// Sweden
// India
// Norway
// USA


void myFunction2(string fname, int age) {
  cout << fname << " Refsnes. " << age << " years old. \n";
}
// Note that when you are working with multiple parameters, the function call must have the same number of arguments as there are parameters, and the arguments must be passed in the same order.
