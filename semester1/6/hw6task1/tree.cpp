#include "tree.h"
#include <iostream>
Tree *createTree()
{
	Tree *tmp = new Tree();
	tmp->value = NULL;
	tmp->left = NULL;
	tmp->right = NULL;
	return tmp;
}

void add (Tree *t, int value)
{
	if (t->value == value)
		return;
	
	if (t->value < value)
	{
		if(t->right == NULL)
		{
			Tree *tmp = new Tree;
			tmp->left = NULL;
			tmp->right = NULL;
			tmp-> value = value;
			t->right = tmp;
		}
		else 
			add(t->right, value);
	}

	if (t->value > value)
	{
		if(t->left == NULL)
		{
			Tree *tmp = new Tree;
			tmp->left = NULL;
			tmp->right = NULL;
			tmp-> value = value;
			t->left = tmp;
		}
		else 
			add(t->left, value);
	}
}

bool exists(Tree *t, int value)
{
	if (t == NULL)
		return false;
	if (t->value == value)
		return true;
	if (t->value < value)
		return exists(t->right, value);
	if (t->value > value)
		return exists(t->left, value);
}

int deleteMin(Tree *&t)
{
	if (t->left == NULL)
	{
		int result = t->value;
		//t = t->right;
		delete t;
		t = NULL;
		return result;
	}
	else
		return deleteMin(t->left);
}

void deleteElement(Tree *&t, int value)
{
	if (t == NULL)
		return;
	

		if (value < t->value)
			deleteElement(t->left, value);
		else
		if (value > t->value)
				deleteElement(t->right, value);
			else
				if (t->left == NULL && t->right == NULL)
				{
					delete t;
					t = NULL;
				}
				else
					if (t->left == NULL)
					{
						t = t->right;
						delete t->right;
						t->right = NULL;
					}
					else
						if (t->right == NULL)
						{
							t = t->left;
							delete t->left;
							t->left = NULL;
						}

						else
							t->value = deleteMin(t->right);
	}
}