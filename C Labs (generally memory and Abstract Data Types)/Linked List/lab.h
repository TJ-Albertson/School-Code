#include <stdio.h>
#include <stdlib.h>

typedef struct Node Node;

struct Node {
	int data;
	Node *next;
};

Node * initList();

Node * insertAtTail(Node *head, int data, int *error);

Node * removeFromHead(Node *head, int *data);

void printListReverse(Node *head);

int countOccurrences(Node *head, int data);

void freeList(Node *head);


//PreLab 7
void * getHead(Node *head);
void * getTail(Node *head);
Node * insertAtIndex(void *object, int index, Node *head, int *error);
void * removeHead(Node *head);
void * removeTail(Node *head);
void * removeIndex(int index, Node *head);
