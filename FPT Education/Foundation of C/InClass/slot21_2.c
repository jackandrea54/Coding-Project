#include <stdio.h>
#include <string.h>
#define MAX_LEN 50

void get_names(char names[][MAX_LEN], int *n);
void print_longest_names(char names[][MAX_LEN], int n);
void get_cont_string(;

int main()
{
    char names[100][MAX_LEN];
    int n, i;
    
    //get_names(names, &n);
    //print_longest_names(names, n);
    get_cont_string(str);
    return 0;
}

void get_names(char names[][MAX_LEN], int *n)
{
    int i;
    scanf("%d", n);
    for (i = 0; i < *n; i++)
    {
        printf("Name %d: ", i+1);
        scanf("%*c%[^\n]", names[i]);
    }
}

void print_longest_names(char names[][MAX_LEN], int n)
{
    int i,maxIn=0; 
    for (i = 0; i < n; i++)
    	if(strlen(names[i]) > strlen(names[maxIn])){
    		maxIn = i;
		} 		
	printf("Longest name is: %s",names[maxIn]);
        
}

void get_cont_string(){
	char s[100];
    int i, j;
    scanf("%[^\n]", s);
    
	// [   ab c  def g\0]
	// [abcdefg\0def g\0]
    
	for (i = 0, j = 0; i <= strlen(s); i++)
	    if (s[i] != ' ')
	        s[j++] = s[i];       
	printf("%s", s);
}

