#include <iostream>
using namespace std;

int fibon(int n)
{
	if ((n == 1) || (n == 2))
		return 1;
	else 
		return fibon(n - 1) + fibon(n - 2);
}

int main()
{
	int num = 0;
	int fib = 0;
	cout << "enter number\n";
	cin >> num;
	fib = fibon(num);
	cout << "Fibonacci number = ";
	cout << fib;
	cin >> fib;
	return 0;
}

