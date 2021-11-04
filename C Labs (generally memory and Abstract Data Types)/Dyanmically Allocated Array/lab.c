#include "lab.h"

char* allocateString(int size) {
    
    //adding 1 for \0
    size += 1;

    //allocating array with size at array[-1]
    char* string = malloc(sizeof(char) * (size + 1));
    string[0] = size;
    string += 1;
    
    //memory alloc check
    if (string == NULL) {
        return NULL;
    } else {
        return string;
    }
}

int strLen(char *string) {
    
    //subtracting 1 to not include \0
    int maxSize = string[-1] - 1;
    return maxSize;

}

int strComp(char *s1, const char *s2) {
    
    //get size with strLen function
    int size = strLen(s1);

    printf("s1 is %s\n", s1);
    printf("s2 is %s\n", s2);

    //comparing values
    for (int i = 0; i < size; i++) {
        if (s1[i] != s2[i]) {
            //printf("string comp fail\n");
            return 1;
        }
    }
    //printf("string comp success\n");
    return 0;
}

void freeString(char *string) {
    free(string - 1);
}

