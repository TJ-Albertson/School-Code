#include "lab.h"

int main() {

    int size = 5;
    char* s1 = allocateString(size);

    //const char s2[] = {'H', 'e', 'l', 'l', 'o' , '\0'};
    const char s2[] = {'W', 'e', 'l', 'c', 'o', 'm', 'e', '\0'};
    const char copy[] = {'H', 'e', 'l', 'l', 'o' , '\0'};

    /*
    int maxSize = strLen(s1);
    printf("The max size of the allocated string is %d.\n\n", maxSize);
    */

    for (int i = 0; i <= size; i++) {
        s1[i] = copy[i];
    }

    strComp(s1, s2);

    freeString(s1);

}