#include <iostream>
#include "list.h"
using namespace std;

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}

List *createList()
{
  List *tmp = new List();
  tmp->next = NULL;
  return tmp;
}

void add (List *head, char x)
{
	List *tmp = new List;
	tmp->next = head->next;
	tmp->data = x;
	head->next = tmp;
}


void del(List *head)
{
	List *tmp = head->next;	
	head->next = head->next->next;
	delete tmp;
}

void printList(List *head)
{
	while (head->next)
	{
		cout << head->next->data;
		head = head->next;
	}
}