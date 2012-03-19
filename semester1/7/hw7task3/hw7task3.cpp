#include <iostream>
#include <string>
#include "stack.h"
#include "calc.h"
using namespace std;


int main()
{
	Stack *digit = new Stack;
	digit->data = '0';
	digit->next = NULL;
	Stack *operat = new Stack;
	operat->data = '(';
	operat->next = NULL;
	cout << "enter notation\n";
	string s;
	getline (cin, s);
	int int_s = s.length();
	char *a = new char[int_s];
	for (int i = 0; i < int_s; i++)
		a[i] = s[i];
	calculator(a, digit, operat);
	while (operat->next)
		calc(digit, operat);
	cout << digit->next->data;
	cin >> s;
	deleteStack(digit);
	deleteStack(operat);
	delete [] a;
	return 0;
}






