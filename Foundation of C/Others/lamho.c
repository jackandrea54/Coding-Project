#include <stdio.h>
#include <stdlib.h>
struct tienLuong
{
    char name[31];
    float heso;
    int phucap;
    double luong;
};

int main(){
	FILE * fp = NULL;
	int n=0,i;
	char input[31];
	char name[31];
	float heso;
    int phucap;
    double luongTB=0;
	scanf("%[^\n]%*c",input);
	fp = fopen(input,"r");
	while(fscanf(fp,"%[^0-9]%f %d",&name,&heso,&phucap) != EOF){
		n+=1;
	}
	fclose(fp);
	
	struct tienLuong * ptr;
	ptr = (struct tienLuong*) malloc(n * sizeof(struct tienLuong));
	
	fp = fopen(input,"r");
	for(i = 0; i < n; ++i)
   	{
       
       fscanf(fp,"%[^0-9]%f %d", (ptr+i)->name, &(ptr+i)->heso, &(ptr+i)->phucap);
       (ptr+i)->luong = (double)((ptr+i)->heso * 1490000)+ (ptr+i)->phucap;
   	}
	fclose(fp);
	for(i = 0; i < n; ++i)
       luongTB += (ptr+i)->luong;
    luongTB /= n;
	for(i = 0; i < n; ++i)
		if((ptr+i)->luong >= luongTB)
			printf("%s",(ptr+i)->name);
	
	return 0;
	
}
