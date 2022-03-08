#include <stdio.h>

int main()
{
    FILE *fp = NULL;
    int a, b,i;
    
    fp = fopen("inp.txt", "r");
    
	if (fp != NULL)
    {
        fscanf(fp, "%d%d", &a, &b);
        // Muon dung cung mot con tro cho 2 file khac nhau thi phai close file roi moi gan sang file khac
        fclose(fp);
        
        fp = fopen("out.txt", "w");
        if(fp != NULL)
        {
        	for(i =a; i <= b; i ++)
	        	if(i%2==0)
					fprintf(fp, "%d ",i);    	
			fclose(fp);
		}
        else
        	printf("Failed to open file out.txt");
    }
    else
        printf("Failed to open file inp.txt!");
        
    return 0;
}
