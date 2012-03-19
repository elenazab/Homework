#include <iostream>
#include <algorithm>
using namespace std;

bool divisors(int a, int b)
{
	for (int i = 2; i <= a; i++)
	{
		if (((a%i) == 0) && ((b%i) == 0))
			return false;
	}
	return true;
}

void sort(int *a, int k)
{
	for (int i = 0; i <= k; i = i + 2)
	{
		for (int j = 0; j <= k-3; j = j + 2 )
		{
			if ( a[j] * a[j+3] >= a[j+1] * a[j+2])
			{
				swap (a[j], a[j+2]);
				swap (a[j+1], a[j+3]);
			}
		}
	}
}




int main()
{
	int n = 0;
	cout << "enter n\n";
	cin >> n;
	int *a = new int[n*n];
	int k = 0;
	for (int i = 2; i <= n; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			if (divisors(j,i))
			{
				a[k] = j;
				a[k+1] = i;
				k = k + 2;
			}
		}
	}
	k--;
	sort(a, k);
	for (int i = 0; i <= k-1; i = i + 2)
		cout << a[i] << "/" << a[i+1] << "\n";
	delete [] a;
	cin >> n;
	return 0;
}






