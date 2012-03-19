#include <iostream>

using namespace std;


int main()
{
	FILE *file;
	file = fopen("text.txt", "r");
	int n = 0;
	n = fgetc(file) -  '0';

	int *a = new int[n+1];
	int student = 0;
	int hw = 0;
	int tmp = 0;
	while (!feof(file))
	{
		tmp = fgetc(file);
		student = fgetc(file) - '0';
		tmp = fgetc(file);
		hw = fgetc(file) - '0';

		a[student] = hw;

	}

	
	for (int i = 1; i <= n; i++)
	{
		if (a[i] <= 3)
			cout << i << a[i] << "\n";
		else
		{
			
			while (a[i] > 3)
			{
				hw = a[i];
				a[i] = a[hw];
			}
			cout << i << a[i] << "\n";
		}
	}

	fclose(file);
	delete []a;
	cin >> hw;
	return 0;
}
