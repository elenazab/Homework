#include <iostream>
#include "list.h"
using namespace std;


/*

List *merge(List *head1, List *head2)
{
	List *head = head1;
	List *tmp = head;
	while (head1 && head2)
	{
		if (head1->data >= head2->data)
		{
			head = head1;
			head1 = head1->next;
			head = head->next;
		}

		else
		{
			head = head2;
			head2 = head2->next;
			head = head->next;
		}
		
	}
	if (head1 == NULL)
		head = head2;
	else 
		head = head1;
	printList(tmp);
	return tmp;
}
*/


List *merge(List *head1, List *head2)
{
	List *tmp1 = head1;
	List *tmp2 = head2;
	List *merg = createList();
	merg->data = 0;
	merg->next = NULL;
	while (head1 && head2)
	{
		if (head1->data <= head2->data)
		{
			queue(merg, head1->data);
			head1 = head1->next;
		}
		else
		{
			queue(merg, head2->data);
			head2 = head2->next;
		}
	}
	while (head1)
	{
		queue(merg, head1->data);
			head1 = head1->next;
	}
	while (head2)
	{
		queue(merg, head2->data);
			head2 = head2->next;
	}
	deleteList(tmp1);
	deleteList(tmp2);
	return merg->next;
}






List *MergeSort(List *head)
{
	int x = length(head);
	List *head1 = head;
	List *tmp = head1;
	for (int i = 1; i <= x/2; i++)
		tmp = tmp->next;
	List *head2 = tmp->next;
	tmp->next = NULL;


	if (!(head2) && (head1))
		return head1;
	else
	{
		
		if (head1->next && head2->next)	
		{
			head1 = MergeSort(head1);
			head2 = MergeSort(head2);
			
		}
	}
	return merge(head1, head2);
}
	


int main()
{
	List *head = createList();
	head->data = 0;
	head->next = NULL;
	int x = 0;
	cout << "enter length\n";
	cin >> x;
	int value = 0;
	for (int i = 1; i <= x; i++)
	{
		cout << "enter value\n";
		cin >> value;
		add(head, value);
	}
	
	head->next = MergeSort(head->next);
	printList(head->next);
	deleteList(head);
	cin >> x;
	return 0;
}

