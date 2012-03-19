#include <iostream>
#include <string.h>
using namespace std;
int const size = 101;

struct List
{
	List *next;
	char data[size];
};

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}
void clear(char *str)
{
	for (int i = 0; i < size; i++)
		str[i] = '\n';
}

void print(char *str, FILE *file)
{	
	int i = 0;
	while(str[i] != '\n')
	{
		fprintf(file, "%c", str[i]);
		i++;
	}
	fprintf(file, "\n");
}

bool equivalent(char *str1, char *str2)
{
	int i = 0;
	while((str1[i] != '\0') && (str2[i] != '\0'))
	{
		if (str1[i] != str2[i])
			return false;
		i++;
	}
	return true;
}



int main()
{
	List **hash = new List*[size];		
	for (int i = 0; i < 100; i++)
	{
		hash[i] = new List[size];
		hash[i]->next = NULL;
	}

	FILE *file1 = fopen("text1.txt", "r");
	FILE *file = fopen ("output.txt", "w");

	int tmp_hash = 0;
	int j = -1;

	while(!feof(file1))
	{
		List *tmp_string = new List;
		tmp_string->next = NULL;
		clear(tmp_string->data);
		while (tmp_string->data[j] != '\n' && !feof(file1))
		{	
			j++;
			tmp_string->data[j] = fgetc(file1);
			tmp_hash += tmp_string->data[j];			
		}
		if (feof(file1))
		{
			tmp_hash += '\n' - tmp_string->data[j];
			tmp_string->data[j] = '\n';
		}
		tmp_hash %= 101;
		if (!(hash[tmp_hash]->next))
			hash[tmp_hash]->next = tmp_string; 
		else
		{
			List *tmp = tmp_string;
			tmp->next = hash[tmp_hash]->next;
			hash[tmp_hash]->next = tmp;
		}
		tmp_hash = 0;
		j = -1;
	}
	fclose(file1);

	FILE *file2 = fopen("text2.txt", "r");
	while(!feof(file2))
	{		
		tmp_hash = 0;
		j = -1;
		char str[size];
		clear(str);
		while (str[j] != '\n' && !feof(file2))
		{
			j++;
			str[j] = fgetc(file2);
			tmp_hash += str[j];			
		}
		if (feof(file2))
		{
			tmp_hash += '\n' - str[j];
			str[j] = '\n';
		}
		tmp_hash %= 101;
		if (hash[tmp_hash]->next)
		{		
			List *tmp = hash[tmp_hash];
			while(tmp->next)
			{
				tmp = tmp->next;
				//if (strcmp(str, tmp->data) == 0)
				if (equivalent(str, tmp->data))
					print(str, file);
			}
		}
	}
	fclose(file2);
	fclose(file);
	for (int i = 0; i < 100; i++)
		deleteList(hash[i]);
	
	return 0;
}
			

