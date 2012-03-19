#include <iostream>

using namespace std;

int main()
{
	int a = 0;
	cout << "a = ";
	cin >> a;
	int n = 0;
	cout << "n = ";
	cin >> n;
	int i = 1;
	int expon = 1;
	for (i = 1; i <= n; i++)
		expon = expon * a;

	cout << expon;
	cin >> a;
	
	return 0;
}