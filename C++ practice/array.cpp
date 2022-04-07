#include <iostream>
#include <string>
using namespace std;

int main() {
  string cars[5] = {"Volvo", "BMW", "Ford"};
  cars[3] = "Mazda";
  cars[4] = "Tesla";
  for(int i = 0; i < 5; i++) {
    cout << cars[i] << "\n";
  }
  return 0;
}

// You don't have to specify the size of the array. But if you don't, it will only be as big as the elements that are inserted into it:
// string cars[] = {"Volvo", "BMW", "Ford"}; // size of array is always 3
// This is completely fine. However, the problem arise if you want extra space for future elements. Then you have to overwrite the existing values
