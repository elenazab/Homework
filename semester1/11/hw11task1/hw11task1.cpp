#include <stdlib.h>
#include <iostream>
using namespace std;
const int length = 100;

bool syntax(char *c);
bool plusOrMinus(char *&c);
bool multOrDiv(char *&c);
bool bracketOrNumber(char *&c);
void delSpace(char *&c);

bool isSign(char c)
{
	return c == '-' || c == '+';
}

bool isDigit(char c)
{
	return c >= '0' && c <= '9';
}

bool isDot(char c)
{
	return c == '.';
}

bool isE(char c)
{
	return c == 'e' || c == 'E';
}



bool checkDouble(char *&c)
{
	int state = 0;
	while(true)
	{
		switch (state)
		{
			case 0 :
				if(isSign(*c))
					state = 1;
				else if(isDigit(*c))
					state = 2;
				else
					return false;
				break;
			case 1 :
				if(isDigit(*c))
					state = 2;
				else
					return false;
				break;
			case 2 :
				if(isDigit(*c))
					state = 3;
				else if(isDot(*c))
					state = 4;
				else 
					return true;
				break;
			case 3 :
				if(!isDigit(*c))
					return true;
				break;
			case 4:
				if(isDigit(*c))
					state = 5;
				else
					return false;
				break;
			case 5:
				if(isDigit(*c))
					state = 5;
				else if(isE(*c))
					state = 6;
				else
					return true;
				break;
			case 6:
				if(isSign(*c))
					state = 7;
				else
					return false;
				break;
			case 7:
				if(isDigit(*c))
					state = 8;
				else
					return false;
				break;
			case 8:
				if(isDigit(*c))
					state = 8;
				else
					return true;
				break;
		}
		c++;
	}
}

bool plusOrMinus(char *&c)
{
	delSpace(c);
	if (!multOrDiv(c))
		return false;
	delSpace(c);
	while (*c == '+' || *c == '-')
	{
		c++;
		if (!multOrDiv(c))
			return false;
	}
	return true;
}

bool multOrDiv(char *&c)
{
	delSpace(c);
	if (!bracketOrNumber(c))
		return false;
	delSpace(c);
	while (*c == '*' || *c == '/')
	{
		c++;
		if (!bracketOrNumber(c))
			return false;
	}
	return true;
}

bool bracketOrNumber(char *&c)
{
	delSpace(c);
	if (*c == '(')
	{
		c++;					
		if (!plusOrMinus(c))
			return false;
		if (*c == 0)
			return false;
		if (*c != ')')
			return false;
		c++;
		return true;
	} else
		return checkDouble(c);
}

bool syntax(char *c)
{
	return plusOrMinus(c);
}

void delSpace(char *&c)
{
	while (*c == ' ')
		c++;
}


int main()
{
	char string[length];
	gets(string);
	if(syntax(string))
		cout << "true";
	else
		cout << "false";
	cin.get();
	return 0;
}