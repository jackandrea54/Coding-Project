#include<stdio.h>

int factorial(int a){
    int f,result1=1;
    for (f=2;f<=a;f++)
        result1*=f;
    return result1;
}

double Power(unsigned int a,int b){
    int k,result2=1;
    for (k=1;k<=b;k++)
        result2*=a;
    return result2;
}

int main()
{
    unsigned int x;
    double sum=1,sum_old=0;
    int n=1;
    scanf("%u", &x);
    do{
        sum_old=sum;
        sum= sum + Power(x,n)/factorial(n);
        n++;
	}
	while(sum-sum_old>0.001);
    printf("%lf", sum);
    return 0;
}
