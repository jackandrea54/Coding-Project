#include <stdio.h>
void nhapMang(float arr[],int index){
	int i;
	printf("Nhap vao cac phan tu cua mang: ");
	for(i=0;i<index;i++){
		scanf("%f",&arr[i]);
	}
}
float tongMang(float arr[],int index){
	float sum = 0;
	int i;
	for(i=0;i<index;i++){
		sum+= arr[i];
	}
	return sum;
}
void inMang(float arr[],int index){
	int i;
	for(i=0;i<index;i++){
		printf("%f ",arr[i]);
	}	
}




int main(){
	int index;
	float arr[100],sum;
	printf("Nhap so phan tu cua mang: ");
	scanf("%d",&index);
	nhapMang(arr,index);
	sum = tongMang(arr,index);
	printf("Tong cac phan tu cua mang la: %f",sum);
	inMang(arr,index);
	return 0;
}
