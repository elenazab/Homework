#include <iostream>
#include <algorithm>
#include <stdlib.h>
using namespace std;

int main()
{
	int n = 0;
	cout << "enter size of array\n";
	cin >> n;
	int *a = new int[n];
	for (int i = 0; i < n; i++)
		a[i] = rand() % 100;

	bool sort = true;
	while(sort)
	{
		sort = false;
		for (int i = 0; i < n-1; i++)
		{
			if (a[i] < a[i+1])
			{
				swap(a[i], a[i+1]);
				sort = true;
			}
		}
	}
	for (int i = 0; i < n; i++)
		cout << a[i] << " ";
	cin >> n;
	delete []a;
	return 0;
}





