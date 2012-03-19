#include <iostream>
#include <string>
using namespace std;


int main()
{
	string s;
	cout << "enter string\n";
	getline(cin, s);
	string sub;
	cout << "enter substring\n";
	getline(cin, sub);
	int sum = 0;
	int var = 0;
	int int_s = s.length();
	int int_sub = sub.length();
	for (int i = 0; i <= (int_s - int_sub-1); i++)
	{
		for (int j = 0; j <= (int_sub-1); j++)
		{
				if (s[i+j] == sub[j])
				var += 1;
		}
		if (var == int_sub)
			sum += 1;
		var = 0;
	}
	cout << sum;
	getline(cin,s);
	return 0;
}

			