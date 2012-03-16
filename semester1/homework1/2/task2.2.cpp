
#include <iostream>
using namespace std;

int main()
{
	int a = 0;
	int b = 0;
	cout << "Enter a, b\n";
	cin >> a;
	cin >> b;
	int i = 0;
	while(a > b)
	{
		a = a - b;
		i = i + 1;
	}
	cout << i;
	cin >> a;
	return 0;
}