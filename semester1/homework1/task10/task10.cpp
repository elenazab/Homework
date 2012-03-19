#include <iostream>
#include <string>
using namespace std;

bool palind(string s)
{
	int j = s.length() - 1;
	for (int i = 0; i != j ; i++, j--)
	{ 
		if (s[i] != s[j])
			return false;
	}
	return true;
}

int main()
{
	string s;
	cout << "enter string";
	getline(cin, s);
	if (palind(s))
		cout << "it is palindrome";
	else
		cout << "it is not palindrome";
	getline(cin, s);
	return 0;
}
