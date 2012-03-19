#include <iostream>
const int length = 100;

using namespace std;

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
	return c == 'e';
}

bool isEnd(char c)
{
	return c == '\0';
}

bool checkDouble(char *string)
{
	int i = 0;
	int state = 0;
	while(true)
	{
		switch(state)
		{
			case 0:
				if(isSign(string[i]))
					state = 1;
				else if(isDigit(string[i]))
					state = 2;
				else
					state = 3;
					break;
			case 1:
				if(isDigit(string[i]))
					state = 2;
				else
					state = 3;
				break;
			case 2:
				if(isDigit(string[i]))
					state = 2;
				else if (isE(string[i]))
					state = 10;
				else if(isDot(string[i]))
					state = 4;
				else if(isEnd(string[i]))
					state = 9;
				else
					state = 3;
				break;
			case 3:
				return false;
				break;
			case 4:
				if(isDigit(string[i]))
					state = 5;
				else
					state = 3;
				break;
			case 5:
				if(isDigit(string[i]))
					state = 5;
				else if(isE(string[i]))
					state = 6;
				else if(isEnd(string[i]))
					state = 9;
				else
					state = 3;
				break;
			case 6:
				if(isSign(string[i]))
					state = 7;
				else
					state = 3;
				break;
			case 7:
				if(isDigit(string[i]))
					state = 8;
				else
					state =3;
				break;
			case 8:
				if(isDigit(string[i]))
					state = 8;
				else if(isEnd(string[i]))
					state = 9;
				else
					state = 3;
				break;
			case 9:
				return true;
				break;
			case 10:
				if (isDigit(string[i]))
					state = 10;
				else if (isEnd(string[i]))
					state = 9;
				else
					state = 3;
				break;

		}
		i++;
	}
}

int main()
{
	char string[length];
	gets(string);
	if (checkDouble(string))
		cout << "Yes";
	else
		cout << "No";
	cin.get();
	return 0;
}

