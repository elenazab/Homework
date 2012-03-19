#include <iostream>
#include "tree.h"
using namespace std;

bool isDigit(char x)
{
  return (x >= '0' && x <= '9');
}

void build(Tree *&t, FILE *file)
{
	char s = ' ';
	s = fgetc(file);
	if (s == ')')
		s = fgetc(file);
	if (s == '(')
	{		
		t = createTree();
		t->value = fgetc(file);
		build(t->left, file);
		build(t->right, file);
	}
	if (isDigit(s))
	{
		if (!t)
			t = createTree();
		t->value = s;
	}
}


char calc(Tree *t)
{
	if (!isDigit(t->left->value))
			t->left->value = calc(t->left);
	if (!isDigit(t->right->value))
			t->right->value = calc(t->right);
	if (isDigit(t->left->value) && isDigit(t->right->value))
	{
		t->left->value -= '0';
		t->right->value -= '0';
		if  (t->value == '*')
			t->value = (t->left->value) * (t->right->value) + '0';
		if  (t->value == '/')
			t->value = (t->left->value) / (t->right->value) + '0';
		if  (t->value == '+')
			t->value = (t->left->value) + (t->right->value) + '0';
		if  (t->value == '-')
			t->value = (t->left->value) - (t->right->value) + '0';
	}
	return t->value;
}
	



int main()
{
	FILE *file = fopen ("text.txt", "r");
	Tree *t = NULL;
	build(t, file);
	printTreeAsc(t);
	int c = calc(t) - '0';
	cout << "\n" << c;
	deleteTree(t);
	getchar();
	return 0;
}

