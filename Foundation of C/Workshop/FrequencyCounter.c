#include<stdio.h>
#include<stdlib.h>
//#define max 100
void print_array(int a[], int n)
{
    for (int i = 0; i < n; i++)
    {
        printf("%d ", a[i]);
    }  
}
int main(){
    long n;
    scanf("%ld", &n);
    long max = n;
    int a[max],acc[max];
    long code, total;
    int cd[max], tt[max], c = 0;
    
    for(long i = 1; i <= n; i++)
    {
	    scanf("%d", &a[i]);
	    acc[i] = 0;
    }    
    for(long i = 1; i <= n; i++)
    {
        if(acc[i] != 1)
        {
            code = a[i];
            total = 0;
            for (long j = i; j <= n; j++)
            {
                if(code == a[j])
                {
                    total++;
                    acc[j] = 1;
                }
            }
            cd[c] = code;
            tt[c++] = total;
        }
    }
    
    for(long i = 0; i < c; i++)
	    for(long j = 0; j < c; j++)
		    if(cd[i] < cd[j]){
		        int temp = cd[i];
		        cd[i] = cd[j];
		        cd[j] = temp;
		
		        temp = tt[i];
		        tt[i] = tt[j];
		        tt[j] = temp;
		    }

    print_array(cd, c);
    printf("\n");
    print_array(tt, c);
}
