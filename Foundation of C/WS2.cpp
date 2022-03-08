#include <stdio.h>
#include <math.h>

void chiaHet(int a, int b , int c){
	int i;
	for(i=a;i<=b;i++){
		if(i%c == 0)
			printf("%d chia het cho %d\n",i,c); 
	}
}

int tinhTong(int a, int b, int c){
	int i,sum;
	sum = 0;
	for(i=a;i<=b;i++){
		if(i%c == 0)
			sum += i;
	}
	return sum;
}

int main() {
    int a,b,c,sum;
    scanf("%d %d %d",&a,&b,&c);
    chiaHet(a,b,c);
    sum = tinhTong(a,b,c);
    printf("Tong cac so la: %d",sum);
	  
    return 0;
}
