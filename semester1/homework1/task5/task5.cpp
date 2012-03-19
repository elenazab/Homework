#include <iostream>
#include <string>
using namespace std;


int main()
{
	string s;
	cout << "enter string\n";
	getline(cin, s);
	int in = 0;
	int left = 0;
	int right = 0;
	int j = s.length()-1;
	for (int i = 0; i <= j; i++)
	{
		if (s[i] == '(')
			left += 1;
		if (s[i] == ')')
			right += 1;
		if (right > left)
			in++;			
	}
	if ((left == right) && !(in))
		cout << "yes";
	else
		cout << "no";
	getline(cin, s);
	return 0;
}


