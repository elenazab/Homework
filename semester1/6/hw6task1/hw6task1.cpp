#include <iostream>
#include "tree.h"
using namespace std;


void printTreeAsc(Tree *t)
{
	if (t->left)
		printTreeAsc(t->left);
	cout << t->value;
	if (t->right)
		printTreeAsc(t->right);
}

void printTreeDes(Tree *t)
{
	if (t->right)
		printTreeDes(t->right);
	cout << t->value;
	if (t->left)
		printTreeDes(t->left);
}
		

int main()
{
	Tree *t = NULL;
	
	cout << " a - add value \n d - delete value \n p - print tree in ascending order \n o - print tree in descending order \n e - exit \n ";
	char i = ' ';
	int value = 0;
	while (true)
	{
		if (i == 'e')
			break;
		else
		{
			cin >> i;
			if (i == 'a')
			{
				cout << "enter value\n";
				cin >> value;
				if(!t)
				{
					t = createTree();
					t->value = value;
				}
				else
				add(t, value);
			}
			if (i == 'd')
			{
				cout << "enter value\n";
				cin >> value;
				if (exists(t, value))
					deleteElement(t, value);
				else
					cout << "incorrect value\n";
			}
			if (i == 'p')
				printTreeAsc(t);
			if (i == 'o')
				printTreeDes(t);
		}
	}


	

	cin >> i;
	return 0;
}

