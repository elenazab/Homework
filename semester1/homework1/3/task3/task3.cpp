#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int a[200]; 
	int m = 0;
	cout << "m = ";
	cin >> m;
	int n = 0;
	cout << "n = ";
	cin >> n;
	int i = 1;
	int sum = 0;
	sum = n + m;
	for (i = 1; i <= sum; i++)
		cin >> a[i];
	
	for (i = 0; i < sum/2; i++)
		swap(a[i+1], a[m+n-i]); 

	for (i = 0; i < n/2; i++)
		swap(a[i+1], a[n-i]);

	
	for (i = 1; i <= n/2; i++)
		swap (a[n+i], a[sum+1-i]);
	
	for(i = 1; i <= sum; i++)
		cout << a[i];

	cin >> m;
	return 0;
}






