#include <iostream>
using namespace std;

int exp(int b, int e)
{
	if ((e == 0) || (b == 1))
		return 1;
	if (e == 2)
		return b * b;
	else
	{
		if (e%2)
			return exp(exp(b, e/2), 2) * b;
		else 
			return exp(exp(b, e/2), 2);
	}
}



int main()
{
	int b = 0;
	cout << "enter base\n";
	cin >> b;
	int e = 0;
	cout << "enter exponent\n";
	cin >> e;
	b = exp(b,e);
	cout << b;
	cin >> b;
	return 0;
}

