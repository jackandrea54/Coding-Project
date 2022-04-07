#include <iostream>
using namespace std;

void whileloop(){
  int i = 0;
  while (i < 5) {
    cout << i << "\n";
    i++;
  }
}

void do_whileloop(){ //This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
	int i = 0;
  do {
    cout << i << "\n";
    i++;
  }
  while (i < 5);
  //The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested
}

int main() {
  whileloop();
  do_whileloop();
  return 0;
}
