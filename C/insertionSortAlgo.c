#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
	int data;
	struct node * next;
	struct node *prev;
}node;

node * createLinkedList(int numRows);
node * sort(node * inp, node *outp);
void clearMem(node * head);
void insertDataValues(node * head);
void displayList(node * head);

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
	
	/*start a linked list to store output sequence*/
	outp = (node*)malloc(sizeof(node));
	outp->next = NULL;
	outp->prev = NULL;
	outp->data = 0;
		
	/*sort input*/
	outp = sort(inp,outp);
		
	/*print out sorted list*/
	printf("Sorted list\n");
	displayList(outp);
	
	clearMem(inp);
	clearMem(outp);
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

node * sort(node * inp, node *outp)
{
	node * inputHead = inp;
	node * outputHead = outp;
	node * inpNodebeingSorted = inp->next;
	node * nd = NULL;
	node * BNode = NULL;
	node * temp = NULL;
	
	BNode = (node*)malloc(sizeof(node));
	
	/*put the first in the input sequence into output sequence*/
	outputHead->data = inputHead->data;
	
	while(inpNodebeingSorted != NULL)
	{
		BNode = outputHead; /*make a copy of current head*/
		if(inpNodebeingSorted->data < outputHead->data)
		{
			nd = (node*)malloc(sizeof(node));
			nd->next = BNode;
			nd->prev = NULL;
			nd->data = inpNodebeingSorted->data;
			BNode->prev = nd;
			outputHead = nd;
		}
		else
		{		
			BNode = outputHead;	
			/*whilst we have not reached the end of the B list, check A value against B values*/
			while(BNode != NULL)
			{
				/*checks if A value is less then current B value and if so inserts it before */
				if(BNode->data - inpNodebeingSorted->data > 0)
				{
					temp = BNode->prev;
					nd = (node*)malloc(sizeof(node));
					nd->next = BNode;
					nd->prev = temp;
					nd->data = inpNodebeingSorted->data;
					BNode->prev = nd;
					temp->next = nd;
					break;
				}
				
				if(BNode->next == NULL)
				{
					nd = (node*)malloc(sizeof(node));
					nd->next = NULL;
					nd->prev = BNode;
					nd->data = inpNodebeingSorted->data;
					BNode->next = nd;
					break;
				}
				
				BNode = BNode->next;				
					
			}
			
		}
		
		inpNodebeingSorted = inpNodebeingSorted->next;
	}
	
	
	return outputHead;
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
