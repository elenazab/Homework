#include <iostream>
#include <algorithm>
#include <stdlib.h>
using namespace std;




void heap (int *a, int n)
{
	for (int j = (n-1)/2; j >= 0; j--)
	{
		if ((a[j] < a[2*j+1]) && (2 * j + 1) <=(n - 1))
			swap (a[j], a[2*j+1]);
		if ((a[j] < a[2*j+2]) && (2 * j + 2) <= (n - 1))
			swap (a[j], a[2*j+2]);
	}
}




int main()
{
	int n = 0;
	cout << "enter size of array\n";
	cin >> n;
	int *a = new int[n];
	for (int i = 0; i < n; i++)
		a[i] = rand() % 100;

	heap(a, n);
	swap (a[0], a[n-1]);

	for (int i = 0; i < n - 3; i++)
	{
		for (int j = 0; j <= (n-i-2)/2; j++)
		{	
			if ((a[j] < a[2*j+1]) && (a[2*j+1] >= a[2*j+2]) && (2 * j + 1) <=(n - 2 - i))
			swap (a[j], a[2*j+1]);
			if ((a[j] < a[2*j+2]) && (a[2*j+2] >= a[2*j+1]) && (2 * j + 2) <= (n - 2 - i))
			swap (a[j], a[2*j+2]); 		
		}
		swap(a[0], a[n-i-2]);		
	}	
	for (int i = 0; i < n; i++)
		cout << a[i] << " ";
	delete [] a;
	cin >> n;
	return 0;
}

		 



