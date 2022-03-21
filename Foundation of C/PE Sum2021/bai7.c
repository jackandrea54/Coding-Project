#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <ctype.h>

// Nhap n phan tu. Tim phan xuat hien nhieu lan nhat

int main() {
  system("cls");
  //INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
  	int i,j,n,arr[1000],acc_for[1000] = {0},total[1000] = {0};
	int index=0,num[1000],code,maxNum;
  	scanf("%d", &n); //Nhap so phan tu 
  	for(i = 0; i < n;i++)
  	{
  		scanf("%d", &arr[i]);	// Nhap n phan tu 
	}
  
  	for (i = 0; i < n; i++)
        if (!acc_for[i])
        {
            code = arr[i];
            for (j = i; j < n; j++)
                if (arr[j] == code){
                	num[index] = code;
                    total[index]++;
                    acc_for[j] = 1;
                }
            index++;
        }

  
	// Fixed Do not edit anything here.
	printf("\nOUTPUT:\n");
	//@STUDENT: WRITE YOUR OUTPUT HERE:
	//In ra phan tu co lan xuat hien nhieu nhat trong day
	maxNum = 0;
	for(i=0;i<index;i++)
		if(total[i]>total[maxNum])
			maxNum = i;
	printf("%d",num[maxNum]);
			





  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
