#include <iostream>
using namespace std;

struct List
{
	int data;
	List *next;
};

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}


int main()
{
	List *head = new List;
	head->data = 1;
	head->next = head;
	List *x = NULL;
	List *tmp = head;
	int length = 0;
	cout << "length = ?" << "\n";
	cin >> length;
	for ( int i = length; i > 1; i--)
	{
		x = new List;
		x->data = i;
		x->next = tmp;
		head->next = x;
		tmp = x;
	}


	int k = 1;
	int n = 0;
	cout << "last element = ?" << "\n";
	cin >> n;
	cout << "\n" << "k = ";

	for (k = 1; k <= length; k++)
	{
		while (x->next != head)
		x = x->next;
	
		while ((x->next) != x)
		{
			for (int i = 1; i < k; i++)
				x = x->next;
			tmp = x->next;
			x->next = tmp->next;
			delete tmp; 
		}

		if (x->data == n)
			cout << k << " ";
		
		head = x;
		head->data = 1;
		List *tmp = head;
		for ( int i = length; i > 1; i--)
		{
			x = new List;
			x->data = i;
			x->next = tmp;
			head->next = x;
			tmp = x;
		}
	}
	while (x->next != head)
		x = x->next;
	x->next = NULL;
	x= head;
	deleteList (x);
	
	cin >> k;
	return 0;
}













