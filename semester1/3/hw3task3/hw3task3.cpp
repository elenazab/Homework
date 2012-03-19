#include <iostream>
#include <string>
#include "stack.h"
using namespace std;




bool isDigit(char x)
{
  return (x >= '0' && x <= '9');
}




int main()
{
	Stack *top = new Stack;
	top->data = '0';
	top->next = NULL;
	cout << "enter infix notation\n";
	string s;
	//getline (cin, s);

	/*int l = s.length() - 1;
	for (int i = 0; i <= l; i++)
	{
			
		if (isDigit(s[i]))
			cout << s[i];
		else
		{
			cout << " ";
			if (isEmpty(top))
				push(top,s[i]);
			else
			{
				if (s[i] == '^')
					push (top, s[i]);

				if (s[i] == '*' || s[i] == ':')
				{
					if (top->next->data == '^' || top->next->data == '*' || top->next->data == ':')
						while (!(top->next->data == '+' || top->next->data ==  '-' || isEmpty(top)))
						{
							cout << top->next->data;
							del_one(top);
						}						
					push (top, s[i]);
				}

				if (s[i] == '+' || s[i] == '-')
				{
					if (isEmpty (top))
						push (top, s[i]);
					else
					{
						while (!(isEmpty (top)))
						{
							cout << top->next->data;
							del_one (top);							
						}
						push (top, s[i]);
					}
				}
			}
		}
	}
	
	while (top->next)
	{
		cout << top->next->data;
		del_one(top);	
	} */
	getline (cin, s);
	return 0;
}





					






