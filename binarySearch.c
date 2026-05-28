#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
	int numElements,*numbers,valToFind,mid,i,ub;
	int found = 0;
	int lb = 0;
	printf("Input number of elements in an array: ");
	scanf("%d",&numElements);
	ub = numElements - 1;
	
	if(!(numbers = (int *) calloc(numElements,sizeof(int))))
	{
		fprintf(stderr,"Invalid memory for numbers array\n");
		exit(1);
	}
	
	printf("Input %d values in ascending order\n",numElements);
	for(i=0;i<numElements;i++)
	{
		printf("Input value\n");
		scanf("%d",&numbers[i]);
	}
	
	printf("Input value in the array to find: ");
	scanf("%d",&valToFind);
	printf("\n");
	
		
	while(found != 1)
	{
		if(ub < lb)
		{
			printf("value not present\n");
			break;
		}
		
		mid = lb + (ub - lb)/2;
		
		if(numbers[mid] < valToFind)
			lb = mid + 1;
		if(numbers[mid] > valToFind)
			ub = mid - 1;
		if(numbers[mid] == valToFind){
			printf("%d found at position: %d\n",valToFind,mid);
			found = 1;
		}
	}
	free(numbers);
	return 0;
}
