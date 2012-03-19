#include <iostream>
#include <string>
#include "list.h"
using namespace std;



int main()
{
	List *head1 = createList();
	head1->data = 0;
	head1->next = NULL;
	List *head2 = createList();
	head2->data = 0;
	head2->next = NULL;
	string s1;
	string s2;
	cout << "string 1\n";
	getline (cin, s1);
	cout << "string 2\n";
	getline (cin, s2);
	if (s1.length() != s2.length())
		cout << "no";
	else
	{
		int l = s1.length() - 1;
		List *tmp = head1;
		for (int i = 0; i <= l; i++)
		{
			add(tmp, s1[i]);
			tmp = tmp->next;
		}
		tmp = head2;
		for (int i = 0; i <= l; i++)
		{
			add(tmp, s2[i]);
			tmp = tmp->next;
		}
		for (int i = 0; i <= l; i++)
		{
			tmp = head2;
			while ((tmp->next->next) && (tmp->next->data != head1->next->data))
				tmp = tmp->next;
			if (tmp->next->data == head1->next->data)
			{
				del(tmp);
				del(head1);
			}
		}
	}
	if (!(head1->next)&& s1.length() == s2.length())
		cout << "yes";
	if ((head1->next)&& s1.length() == s2.length())
		cout << "no";
		
	deleteList (head1);
	deleteList (head2);
	cin >> s1;
	return 0;
}


