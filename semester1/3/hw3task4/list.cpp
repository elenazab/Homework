#include <iostream>
#include "list.h"
using namespace std;

void printList(List *head)
{
	while (head)
	{
		cout << head->data << " ";
		head = head->next;
	}
}


List *createList()
{
  List *tmp = new List();
  tmp->next = NULL;
  return tmp;
}

int length( List * head)
{
	int k = 0;
	List *tmp = head;
	while (tmp->next)
	{
		k++;
		tmp = tmp->next;
	}
	return k;
}


void add (List *head, int x)
{
	List *tmp = new List;
	tmp->next = head->next;
	tmp->data = x;
	head->next = tmp;
}

void queue(List *head, int x)
{
	List *tmp = new List;
	List *headtmp = head;
	tmp->data = x;
	tmp->next = NULL;
	while (headtmp->next)
		headtmp = headtmp->next;
	headtmp->next = tmp;
}

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}