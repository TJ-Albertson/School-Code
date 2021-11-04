#include "lab.h"

Node * initList() {
    //makes single node list
    Node *p;
    p = malloc(sizeof(Node));
    return p;
}

Node * insertAtTail(Node *head, int data, int *error) {
    Node *p = malloc(sizeof(Node));
    Node *l = head;
    p->data = data;
    *error = 1;

    //basically makes single node list
    if(head == NULL) {
        head = p;
        *error = 0;
        return head;
    }

    while (l->next != NULL) {
        l = l->next;
    }

    l->next = p;
    *error = 0;
    return head;
}

Node * removeFromHead(Node *head, int *data) {
    if (head == NULL) {
        return NULL;
    }
    
    //save head node data and set the head node to the next node
    Node *p = head;
    *data = p->data;
    head = head->next;

    return head;
}

void printListReverse(Node *head) {

    if (head == NULL) {
        return;
    }

    //recursion to print reverse
    Node *p = head;
    printListReverse(p->next);
    printf("%d\n", p->data);

}

int countOccurrences(Node *head, int data) {
    int count = 0;
    Node *p = head;
    //simple iteration and compare
    while(p) {
        if(p->data == data) {
            count++;
        }
        p = p->next;
    }
    return count;
}

void freeList(Node *head) {
    Node *p;
    //assign head node to p, remove head node, free p, repeat
    while (head != NULL) {
        p = head;
        head = head->next;
        free(p);
    }
}