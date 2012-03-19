#include <iostream>
using namespace std;

void print (int a)
{
	if (a < 0)
		a = -a;
	if (a != 1)
	{
		while (a > 0)
			{
				cout << " ";
				a /= 10;
			}
	}
}

int main()
{
	int degree = 0;
	cout << "degree of the polynomial\n";
	cin >> degree;
	int *a = new int[degree+1];
	for (int i = degree; i >=0 ; i--)
	{
		cout << "coefficient\n";
		cin >> a[i];
		//a[i] = 50 - rand() % 100;
	}
	for (int i = degree; i > 1 ; i--)
	{
		if (a[i] != 0)
		{
			print(a[i]);
			cout << "  "<< i;
		}
	}
	cout << "\n";
	for (int i = degree; i >0 ; i--)
	{
		if (a[i]!= 0)
		{
			if (a[i] > 0)
			{
				if (a[i] != 1)
					cout << "+" << a[i] << "x";
				else 
					cout << "+" << "x";
			}
			else 
			{
				if (a[i] != -1)
					cout << "-" << -a[i] << "x";
				else
					cout << "-" << "x";
			}
			print(i);
		}
	}
	if (a[0] != 0)
	{
		if (a[0] > 0)
				cout << "+" << a[0];
			else 
				cout << "-" << -a[0];
	}

	delete []a;
	cin >> degree;
	return 0;
	
}
		


