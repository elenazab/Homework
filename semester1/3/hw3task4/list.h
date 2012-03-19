#include <iostream>
using namespace std;


struct List
{
	int data;
	List *next;
};

void printList(List *head);
List *createList();
int length( List * head);
void add (List *head, int x);
void queue(List *head, int x);
void deleteList(List *x);