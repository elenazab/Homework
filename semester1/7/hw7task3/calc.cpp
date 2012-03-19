#include <iostream>
#include "stack.h"
using namespace std;


bool isDigit(char x)
{
  return (x >= '0' && x <= '9');
}

void calc(Stack *digit, Stack *operat)
{
	int a = 0;
	int b = 0;
	b = pop(digit);
	a = pop(digit);
	if (operat->next->data == '*')
		a *= b;
	if (operat->next->data == '+')
		a += b;
	if (operat->next->data == '-')
		a -= b;
	if (operat->next->data == '/')
		a /= b;
	push(digit, a);
	a = pop(operat);
}

void calculator(char *s, Stack *digit, Stack *operat)
{
	int x = 0;
	for (int i = 0; s[i] != '\0'; i++)
	{
		if (isDigit(s[i]))
		{
			x = s[i]-'0';
			push(digit, x);
		}
		if (s[i] == '(')
			push(operat, s[i]);
		if (s[i] == '*')
		{
			if (operat->next)
			{
				if (operat->next->data == '/')
				{
					calc(digit, operat);
					push(operat, s[i]);
				}
				else
					push(operat, s[i]);
			}
			else
				push(operat, s[i]);
		}
		if (s[i] == '/')
		{
			if (operat->next)
			{
				if (operat->next->data == '*')
				{
					calc(digit, operat);
					push(operat, s[i]);
				}
				else
					push(operat, s[i]);
			}
			else
				push(operat, s[i]);
		}
		if (s[i] == '+')
		{
			if (operat->next)
			{
				if (operat->next->data == '(')
					push(operat, s[i]);
				else
				{
					calc(digit, operat);
					push(operat, s[i]);
				}
			}
			else
				push(operat, s[i]);
		}
		if (s[i] == '-')
		{
			if (operat->next)
			{
				if (operat->next->data == '(')
					push(operat, s[i]);
				else
				{
					calc(digit, operat);
					push(operat, s[i]);
				}
			}
			else
				push(operat, s[i]);
		}
		if (s[i] == ')')
		{
			while(operat->next->data != '(')
				calc(digit, operat);
			x = pop(operat);
		}
	}
}
