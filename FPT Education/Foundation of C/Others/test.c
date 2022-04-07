#include<stdio.h>
#include <math.h>


void swap(int *xp, int *yp)
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}
 
void bubbleSort(int num[], int n)
{
    int i, j;
    for (i = 0; i < n-1; i++)    
    for (j = 0; j < n-i-1; j++)
        if (num[j] > num[j+1])
            swap(&num[j], &num[j+1]);
}

int main(){
	int i,j,k,n,chenhlechMin,idealNum=0;
	float ideal=0;
	int to1,to2;
	scanf("%d",&n);
	int num[n];	
	for(i=0;i<n;i++){
		scanf("%d",&num[i]);
		ideal+=num[i];
	}
		
//	Sap xep lai
	bubbleSort(num,n);
//	printf("Day so la: ");
//	for(i=0;i<n;i++){
//		printf("%d ",num[i]);
//	}
	ideal /= 2;
	
	for(i=0;i<n;i++){
		if(ideal >= num[n-1]){
			idealNum = n-1;
			break;
		}
		if(fabs(num[i] - ideal) < fabs(num[idealNum] - ideal)){
			idealNum = i;
		}
	}
//	printf("%d",num[idealNum]);
	
	for(i=0;i<n-1;i++){
		to1 = num[idealNum];
		to2 = 0;
		for(j = i-1; j >= 0 && j != idealNum; j--)
			to1 += num[j];
		for(k = i; k < n && k != idealNum; k++)
			to2 += num[k];
		if(i==0)
			chenhlechMin = abs(to1-to2);
		else if(chenhlechMin > abs(to1-to2)){
//			printf("To1: %d To2: %d\n",to1,to2);
			chenhlechMin = abs(to1-to2);
		}
			
	}

	printf("%d",chenhlechMin);
	return 0;
}
