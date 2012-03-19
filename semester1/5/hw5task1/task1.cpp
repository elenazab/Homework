#include <iostream>
#include <string.h>
#include <stdio.h>

using namespace std;

const int length = 100;

bool isFirstChar (char string[], int i1, int i2)
{
	for (int k = i1; k < i2; k++)
	{
		if (string[k] == string[i2])
		return false;
	}
	return true;
}


void clear(char string[])
{
	for (int i = 0; i < length; i++)
	{
		string[i] = '\n';
	}	
}


int main()
{
	int i = 0;
	int j = 0;
	char string[length];
	FILE *file;
	file = fopen("text.txt", "r");	
	clear(string);
	while (!feof(file))
	{
		
		fgets(string, length, file);
		i = 0;
		j = i;
		while (string[i] != '\n' )
		{
			j = i;
			while (string[i] != ' ' && string[i] != '\n')
			{
				if (isFirstChar(string, j, i))
					printf("%c", string[i]);
				
				i++;
			}
			printf(" ");
			i++;
			
			//j = i;	
		}
		printf("\n"); 
		clear(string);
	} 
	fclose(file); 
	cin.get();
	return 0;
}