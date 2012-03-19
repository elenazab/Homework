#include <iostream>
using namespace std;


int next(int **a, int n)
{
	int town = 0;
	int len = 999;
	for (int j = 2; j <= n; j++)
	{
		if (a[1][j] < len && a[1][j] > 0)
		{
			town = j;
			len = a[1][j];
		}
	}
	return town;
}




int main()
{
	FILE *file;
	file = fopen("text.txt", "r");
	int n = fgetc(file) -  '0';
	int **a = new int*[n+1];
	for (int i = 0; i < n+1; i++)
		a[i] = new int[n+1];

	for (int i = 0; i < n+1; i++)
		for (int j = 0; j < n+1; j++)
			a[i][j] = 999;

	int tmp_i = fgetc(file);
	int tmp_j = fgetc(file);
	int len = fgetc(file);
	int tmp = 0;

	while (!feof(file))
	{
		tmp_i = fgetc(file) - '0';
		tmp = fgetc(file);
		tmp_j = fgetc(file) - '0';
		tmp = fgetc(file);
		len = fgetc(file) - '0';
		tmp = fgetc(file);
		a[tmp_i][tmp_j] = len;
	}
	fclose(file);

	int next_town = 0;

	for (int k = 1; k < n; k++)
	{
		next_town = next(a, n);
		
		cout << "town " << next_town << " " << "lenght " << a[1][next_town] << "\n";
		
		for (int i = 2; i <= n; i++)
			if (a[next_town][i] + a[1][next_town] < a[1][i] && a[1][i] > 0)
				a[1][i] = a[next_town][i] + a[1][next_town];

		a[1][next_town] = 0;
	}

	for (int k = 0; k < n+1; k++)
		delete []a[k];
	delete []a;

	cin >> n;
	return 0;
}
		



			
	


