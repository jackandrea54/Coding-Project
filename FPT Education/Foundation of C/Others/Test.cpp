#include <stdio.h>

int main() {
  
  int n, i , t , count = 0, max = 1, min = 1;
    scanf("%d", &n);
    scanf("%d", &t);
    int a[n+1];  
    for (i = 1; i <= n; i++) {
        a[i] = 0;  
    }

    for (i = 1; i <= n; i++) {
        int num;
        scanf("%d", &num);
        if(num > max){
        	max = num;
		}
		if(num < min){
			min = num;
		}
        a[num]++;
    }

    for (i = min; i <= max; i++) {
    	if(t >= a[i] * i){
    		t = t - a[i]*i;
    		count += a[i];
		}else{
			while(a[i] > 0){
	    		if(t >= i){
	    			t = t - i;
	    			count++;
				}else{
					break;
				}
					a[i]--;
			}
		}
    	
        
    }
    
    printf("%d",count);
    


    return 0;
  
  
  
	  
	  
        
}
