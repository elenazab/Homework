#include <iostream>
#include "list.h"
using namespace std;




int main()
{
	List *head = createList();
	head->data = 0;
	head->next = NULL;
	int k = -1;
	int value = 0;
	List *x = NULL;
	cout << " 0 - exit \n 1 - add value to sorted list \n 2 - remove value from list \n 3 - print list\n";
	while (k != 0)
	{
		cin >> k;
		if (k == 1)
		{
			cout << "value = ";
			cin >> value;
			x = head;
			while ((x->next) && !(value >= x->next->data))
				x = x->next;
			add (x, value);
		}
		if (k == 2)
		{
			cout << "value = ";
			cin >> value;
			x = head;
			while (x->next->data != value && x->next->next)
				x = x->next;
			if (x->next->data != value && x->next->next == NULL)
				cout << "incorrect value\n";
			else
				del (x);
		}
		if (k == 3)
			printList(head);
	}
	deleteList(head);
	cin >> k;
	return 0;
}



