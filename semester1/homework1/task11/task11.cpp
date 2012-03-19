#include <iostream>
#include <algorithm>
#include <stdlib.h>
using namespace std;

void sort(int a[], int low, int high)
{
	int i = low;
	int j = high;
int x = a[(low + (high-low)/2)];
            do {
              while (a[i] < x)
                ++i;
              while (x < a[j])
                --j;
              if (i <= j) {
                swap(a[i], a[j]);
                ++i;
                --j;
              }
            } while (i <= j);
            if (low < j)
              sort(a, low, j);
            if (i < high)
              sort(a, i, high);
}	

int main()
{
	int a[100];
	for (int i = 0; i!=100; i++)
		a[i] = rand() % 100;
	sort (a, 0, 99);
	for (int i = 0; i != 100; i++)
		cout << a[i] << " ";
	cin >> a[1];
	return 0;
}
