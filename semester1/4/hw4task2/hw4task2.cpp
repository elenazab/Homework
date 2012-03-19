#include <iostream>
using namespace std;

int main()
{
	int size = 0;
	cout << "enter size of array\n";
	cin >> size;
	int **a = new int*[size-1];
	for (int i = 0; i < size; i++)
		a[i] = new int[size-1];

	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			a[i][j] = rand() % 10;
			cout << a[i][j] << " ";
		}
		cout << "\n" << "\n";
	}
	int line = 1;
	int i = (size-1)/2;
	int j = (size-1)/2;
	
	cout << a[i][j] << " ";

	do
	{
		if (line%2)
		{
			for (int k = 0; k < line; k++)
			{
				cout << a[i-1][j] << " ";
				i--;
			}
			for (int k = 0; k < line; k++)
			{
				cout << a[i][j+1] << " ";
				j++;
			}
		}
		if (!(line%2))
		{
			for (int k = 0; k < line; k++)
			{
				cout << a[i+1][j] << " ";
				i++;
			}
			for (int k = 0; k < line; k++)
			{
				cout << a[i][j-1] << " ";
				j--;
			}
		}
		line ++;
	}	while (line <= (size-1));
	for (int k = 0; k < (size-1); k++)
	{
		cout << a[i-1][j] << " ";
		i--;
	}
	for (int k = 0; k < (size-1); k++)
		delete []a[k];
	delete []a;
	cin >> size;
	return 0;
}


