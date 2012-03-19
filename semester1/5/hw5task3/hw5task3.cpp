#include <iostream>
#include <string.h>

using namespace std;

const int length = 100;

void clear(char string[])
{
	for (int i = 0; i < length; i++)
	{
		string[i] = '\n';
	}	
}

void print(char string[], int i)
{
	while (string[i] != '\n') 
	{
		printf("%c", string[i++]);
	}
	printf("\n");
}


int main()
{
	FILE *file;
	file = fopen("text.txt", "r");
	char string[length];
	while (!feof(file))
	{
		fgets(string, length, file);
		int i = 2;
		while (string[i] != '\n')
		{
			if (string[i - 2] == '\"')
			{
				while (string[i - 1] != '\"' && string[i] != '\n')
					i++;
				i+=2;
			}
			if ((string[i - 1] == '/') && (string[i - 2] == '/'))
			{
				print(string, i);
			}
			i++;
		}
		clear(string);
	}
	fclose(file);
	cin.get();
	return 0;
}