#include <iostream>
#include <cmath>
#include <string>
using namespace std;

void cond(){
	if(20>18){
		cout <<"your mom fat"<<endl;
	}
}

//SHORT HAND IF...ELSE (Ternary Operator) used to replace simple if else statements
void ternaryop(){
	int time = 20;
  	string result = (time < 18) ? "Good day." : "Good evening.";   //type variable = (condition) ? expressionTrue : expressionFalse;
  	cout << result;
}

int main(){
	cond();
	ternaryop();
	return 0;
}
