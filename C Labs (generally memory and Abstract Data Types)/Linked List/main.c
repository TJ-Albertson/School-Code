#include "lab.h"

int main() {
    Node *head = initList();
    int *error = malloc(sizeof(int));
    int *data = malloc(sizeof(int));

    insertAtTail(head, 1, error);
    insertAtTail(head, 1, error);
    insertAtTail(head, 3, error);
    insertAtTail(head, 4, error);
    insertAtTail(head, 5, error);
    
    head = removeFromHead(head, data);

    printListReverse(head);

    //testing count
    int count = countOccurrences(head, 1);
    printf("count: %d\n", count);

    freeList(head);
}