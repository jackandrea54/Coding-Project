#include <iostream>
#include <cmath>
using namespace std;

void maxmin(){
	//max(x,y) function can be used to find the highest value of x and y
	cout << max(5, 10)<<endl; 
	//min(x,y) function can be used to find the lowest value of x and y
	cout << min(5, 10)<<endl;
//Other functions, such as sqrt (square root), round (rounds a number) and log (natural logarithm), can be found in the <cmath> header file:
	cout << sqrt(64)<<endl;
}


int main(){
	maxmin();
	return 0;
}
