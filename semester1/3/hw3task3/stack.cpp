#include "stack.h"
void push(Stack *top, char x)
{
	Stack *tmp = new Stack;
	tmp->next = top->next;
	tmp->data = x;
	top->next = tmp;
}

bool isEmpty (Stack *top)
{
	if (!(top->next))
		return true;
	return false;
}

void del_one(Stack *top)
{
	Stack *tmp = top->next;	
	top->next = top->next->next;
	delete tmp;
}