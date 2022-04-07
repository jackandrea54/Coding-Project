#include <iostream>
using namespace std;

int main() {
  int day = 4;
  switch (day) {
    case 6:
      cout << "Today is Saturday";
      break;
    case 7:
      cout << "Today is Sunday";
      break;
    default: //default keyword specifies some code to run if there is no case match:
      cout << "Looking forward to the Weekend";
    //Note: The default keyword must be used as the last statement in the switch, and it does not need a break.
  }
  return 0;
}

