#include <iostream>
#include <math.h>
using namespace std;

bool prime(int a)
{
	int i = 2;
	for ( i = 2; i < a; i++)
	{
		if (!(a%i)) 
			return false;
	}
	return true;
}



int main()
{
	int a = 0;
	cout << "a=";
	cin >> a;
	int i = 0;
	for (i = 1; i < a; i++)
	{
		if(prime(i))
			cout << i << "\n";
	}
	cin >> a;
	return 0;
}
