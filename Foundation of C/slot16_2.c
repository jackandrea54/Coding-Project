#include <stdio.h>
#include <stdlib.h>

int main()
{
    int TV[12]= {2,3,4,5,6,7,9,11,17,25,29,36};
    int cable[12] = {17,20,16,6,3,18,8,11,61,12,28,4};
	int low=0,high=11,mid,tv_num,result=-1;
    
    printf("Nhap so TV: ");
    scanf("%d", &tv_num);
    do{
    	mid = (high+low+1)/2;
    	printf("Mid:%d\n",mid);
    	printf("High and low: %d %d\n",high,low);
    	if(tv_num == TV[mid]){
    		result = mid;
		}
		else if(tv_num < TV[mid]){
			high = mid-1;
		}
		else if(tv_num > TV[mid]){
			low = mid+1;
		}
		
	}while(result == -1 && low<=high);
	
	if(result == -1){
    	printf("Khong co",cable[mid]);
	}
	else
    	printf("Cable cua TV la: %02d",cable[mid]);
    
    return 0;
}
