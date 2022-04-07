#include <math.h>
#include <iostream>
using namespace std;
int main(){
	long long int n,k,i,tich=1;
	scanf("%ld%ld", &n, &k);
	for(i=2;i<=k;i++){
		if(i%k==n%k) {
			tich=tich*j;
			}
	}
	printf("Tich la: %lld", tich);
	return 0;
}
