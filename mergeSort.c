#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
	int data;
	struct node * next;
	struct node *prev;
}node;

node * createLinkedList(int numRows);
void insertDataValues(node * head);
void displayList(node * head);
void clearMem(node * head);
node * sort(node * inp);

int main(int argc, char **argv)
{
	int numNodes;
	node * inp = NULL;
	node *outp = NULL;
	
	printf("input number of values in sequence to sort: ");
	scanf("%d",&numNodes);
	printf("\n");
	/*creates a linked list to store input sequence.*/
	inp = createLinkedList(numNodes);
	/*input sequence values*/
	insertDataValues(inp);
	
	if(numNodes == 1)
	{
		printf("Sorted list:\n");
		displayList(inp);
	}
	else
	{
		outp = sort(inp);
		printf("Sorted list:\n");
		displayList(inp);
		
	}
	clearMem(inp);
	return 0;
}

node * createLinkedList(int numNodes)
{
	int i;
	node * head = NULL;
	node * nd = NULL;
	node * iter = NULL;
	node * pre;
	
	for(i = 0; i < numNodes;i++)
	{
		nd = (node*)malloc(sizeof(node));
		nd->next = NULL;
		nd->prev = NULL;
		nd->data = 0;
		
		if(head == NULL)
		{
			head = nd;
			pre = nd;
		}
		else
		{
			iter = head;
			while(iter->next != NULL)
				iter = iter->next;
			
			iter->next = nd;
			iter->prev = pre;
			
			pre = iter;
		}
	}
	return head;
}

void insertDataValues(node * head)
{
	node * nd = head;
	
	while(nd != NULL)
	{
		printf("Input data: ");
		scanf("%d",&(nd->data));
		printf("\n");
		nd = nd->next;
	}
}

void displayList(node * head)
{
	node * iter = head;
	while(iter != NULL)
	{
		printf("Data = %d \n",iter->data);
		iter = iter->next;
	}
}

void clearMem(node * head)
{
	node * iter;
	while(head != NULL)
	{
		iter = head;
		head = head->next;
		free(iter);
	}	
}

node * sort(node * inp)
{
	
}
