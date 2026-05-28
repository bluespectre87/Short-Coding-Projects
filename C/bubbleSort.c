#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
	int numItems, *toSort,i,j,temp1;
	printf("Enter number of items in the list to be sorted: ");
	scanf("%d",&numItems);
	
	if(!(toSort = (int *) calloc(numItems,sizeof(int))))
	{
		fprintf(stderr,"insuffiecient memory to create array\n");
		exit(1);
	}
	
	for(i=0;i<numItems;i++)
	{
		printf("enter digit:\n");
		scanf("%d",&toSort[i]);
	}
	
	printf("unsorted list: ");
	for(i=0;i<numItems;i++)
	{
		printf(", %d",toSort[i]);
	}
	printf("\n");
	
	for(i=0;i<numItems;i++)
	{
		for(j=0;j<numItems-1;j++)
		{
			if(toSort[j] > toSort[j+1])
			{
				temp1 = toSort[j];
				toSort[j] = toSort[j+1];
				toSort[j+1] = temp1;
			}
		}
	}
	
	printf("sorted list: ");
	for(i=0;i<numItems;i++)
	{
		printf(", %d",toSort[i]);
	}
	printf("\n");
	free(toSort);
	return 0;
}
