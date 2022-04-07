#include <stdio.h>

int main(){
	FILE *fp = NULL;
	int a = 3;
	double b = -7.2;
	// write se xoa het file roi ghi lai
	fp = fopen("out.txt", "w");
	// add se add them vao file nhung khong xoa file
	//	fp = fopen("out.txt", "a");
	if (fp != NULL)
	{
		fprintf(fp, "%s", "Hi everyone\n");
		fprintf(fp, "%d %.1lf\n", a , b);
		
		fclose(fp);
	}
	else
		printf("Failed to open file!");
		
	
	return 0;
}
