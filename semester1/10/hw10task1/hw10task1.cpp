#include <iostream>
//#include "list.h"
using namespace std;

struct List
{
	int coeff;
	int exp;
	List *next;
};

void deletList(List *x)
{
	if (x->next)
		deletList(x->next);
	delete x;
}
void add (List *head, int x, int y)
{
	List *tmp = new List;
	tmp->next = head->next;
	tmp->exp = x;
	tmp->coeff = y;
	head->next = tmp;
}

void sortedAdd(List *head)
{
	int k = -1;
	int exp = 0;
	int coeff = 0;
	List *x = NULL;
	cout << " 0 - exit \n 1 - add element \n";
	while (k != 0)
	{
		cin >> k;
		if (k == 1)
		{
			cout << "exp = ";
			cin >> exp;
			cout << "coeff = ";
			cin >> coeff;
			x = head;
			while ((x->next) && !(exp >= x->next->exp))
				x = x->next;
			add (x, exp, coeff);
		}
	}
}

bool equals(List *head1, List *head2)
{
	while (head1->next && head2->next)
	{
		head1 = head1->next;
		head2 = head2->next;
		if ((head1->coeff != head2->coeff) || (head1->exp != head2->exp))
			return false;
		
	}
	return true;
}

int value(List *head, int x)
{
	int value = 0;
	while (head->next)
	{
		head = head->next;
		int tmp_x = 1;
		for (int i = 1; i <= head->exp; i++)
			tmp_x *= x;
		value += tmp_x*head->coeff;
	}
	return value;
}

List* addPolynom(List *head, List *head1, List *head2)
{
	List *result = head;
	head1 = head1->next;
	head2 = head2->next;
	while(head1 && head2)
	{		
		if (head1->exp > head2->exp)
		{
			head->next = head1;
			head1 = head1->next;
			head = head->next;
		}
		else if (head2->exp > head1->exp)
		{
			head->next = head2;
			head2 = head2->next;
			head = head->next;
		}
		else if (head2->exp == head1->exp)
		{
			List *tmp = new List;
			tmp->next = NULL;
			tmp->exp = head2->exp;
			tmp->coeff = head1->coeff + head2->coeff;
			head->next = tmp;
			head1 = head1->next;
			head2 = head2->next;
			head = head->next;
		}
	}
	if (head1)
		head->next = head1;
	if (head2)
		head->next = head2;
	return result;
}

void printLis(List *head)
{
	while(head->next)
	{
		head = head->next;
		if (head->coeff > 0)
			cout<< "+"<<head->coeff;
		else
			cout<< "-"<< head->coeff;
		cout<< "x^"<< head->exp;
	}
	cout << "\n";
}


int main()
{
	List *head_p = new List;
	head_p->exp = 0;
	head_p->coeff = 0;
	head_p->next = NULL;
	List *head_q = new List;
	head_q->exp = 0;
	head_q->coeff = 0;
	head_q->next = NULL;
	sortedAdd(head_p);
	sortedAdd(head_q);
	int a = -1;
	int x = 0;
	while (a != 0)
	{
		cout << " 1-equals(p,q)\n 2-value(p,x)\n 3-add(p,q,r)\n 0-exit\n";
		cin >> a;
		if (a == 1)
			if(equals(head_p, head_q))
				cout << "yes\n";
			else
				cout << "no\n";
		if (a == 2)
		{
			cout << "x = ";
			cin >> x;
			cout << value(head_p,x) << "\n";
		}
		if (a == 3)
		{
			List *head_r = new List;
			head_r->exp = 0;
			head_r->coeff = 0;
			head_r->next = NULL;
			head_r = addPolynom(head_r, head_p, head_q);
			printLis(head_r);
			deletList(head_r);
		}
	}
	deletList(head_p);
	deletList(head_q);
	return 0;
}
	




	


