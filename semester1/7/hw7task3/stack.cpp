#include <iostream>
#include "stack.h"
using namespace std;

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

int pop(Stack *top)
{
	Stack *tmp = top->next;	
	top->next = top->next->next;
	int result = tmp->data
	delete tmp;
	return result;
}

void deleteStack(Stack *top)
{
	while(top->next)
		deleteStack(top->next);
	delete top;
}
