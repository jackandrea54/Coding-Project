#include <stdio.h>
#include <math.h>

//He 10 -> 8
int DecToOct(int number){
    int p = 0;
    int octNumber = 0;
    while(number > 0){
        octNumber += (number % 8) * pow(10, p);
        p++;
        number /= 8;
    }
    return octNumber;
}
// He 10 -> 8
int Oct2Dec(int number){
    int p = 0;
    int decNumber = 0;
    while(number > 0){
        decNumber += (number % 10) * pow(8, p);
        p++;
        number /= 10;
    }
    return decNumber;
}


int main(){
    int octNumber;
    
}
 
