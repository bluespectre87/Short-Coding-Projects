#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
	int *array,numEls,i,numToFind;
	int found = 0;
	
	printf("How long is the list to search? ");
	scanf("%d",&numEls);
	
	if(!(array = (int *) calloc(numEls,sizeof(int))))
	{
		fprintf(stderr,"invalid memory availiable\n");
		exit(1);
	}
	
	for(i=0;i<numEls;i++)
	{
		printf("Enter value: \n");
		scanf("%d",&array[i]);
	}
	
	printf("Enter value to find: ");
	scanf("%d",&numToFind);
	i = 0;
	
	while(i != numEls)
	{
		if(array[i] == numToFind){
			printf("Number found at position %d\n",i);
			found = 1;
			exit(1);
		}
			
		i++;
	}
	
	if(found != 1)
	{
		printf("Value not found\n");
	}
	return 0;
}
