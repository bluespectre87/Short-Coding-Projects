#include <stdio.h>
#include <stdlib.h>

int main(int argc, char **argv)
{
	int num_elements,num;
	int *elements,i,tempStore;
	int counter = 0;
	
	/*get number of elements */
	printf("Enter number of elements:\n");
	scanf("%d",&num_elements);
	
	/*assign dynamic memory and check that it has allocated ok*/
	if(!(elements = (int *)calloc(num_elements, sizeof(int))))
	{
		printf("Insufficient memory available\n");
		return 1;
	}
	
	/*get values */
	for(i=0;i<num_elements;i++)
	{
		printf("Enter number:\n");
		scanf("%d",&num);
		elements[i] = num;
	}
	
	/*sort*/
	while(counter != num_elements)
	{
		for(i=num_elements - 1;i>-1;i--)
		{
			if(elements[i] < elements[i - 1])
			{
				tempStore = elements[i];
				elements[i] = elements[i -1];
				elements[i - 1] = tempStore;
			}
		}
		counter ++;
	}
	
	
	/*prints*/
	for(i = 0;i < num_elements; i++)
		printf("%d ",elements[i]);
	printf("\n");
	
	/*free's dynamic memory */
	free(elements);
	return 0;
}
