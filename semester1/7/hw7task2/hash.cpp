#include "hash.h"
#include <iostream>
using namespace std;

List** create()
{
	List **hash = new List*[size];		
	for (int k = 0; k < size; k++)
	{
		hash[k] = new List[size];
		hash[k]->next = NULL;
		hash[k]->value = 0;
	}
	return hash;
}

void deleteList(List *x)
{
	if (x->next)
		deleteList(x->next);
	delete x;
}

void clear(char *str)
{
	for (int i = 0; i < size; i++)
		str[i] = ' ';
}

bool equiv(char *str1, char *str2)
{
	int i = 0;
	while((str1[i] != ' ') && (str2[i] != ' '))
	{
		if (str1[i] != str2[i])
			return false;
		i++;
	}
	return true;
}

int h(char *str)
{
	int result = 0;
	for (int i = 0; str[i] != ' '; ++i)
		result = (result + str[i])%size;
	return result;
}

void add(char *str, List **hash)
{
	int tmp_hash = 0;
	List *tmp_string = new List;
	tmp_string->next = NULL;
	tmp_string->value = 0;
	for (int i = 0; i < size; i++)
		tmp_string->data[i] = str[i];

	tmp_hash = h(tmp_string->data);
	hash[tmp_hash]->value++;
	if (!(hash[tmp_hash]->next))
	{
		hash[tmp_hash]->next = tmp_string;
		hash[tmp_hash]->next->value++;
	}

	else
	{
		List *tmp = hash[tmp_hash];
		bool eq = (equiv(tmp->data, tmp_string->data));
		while(tmp->next && !eq)
		{
			tmp = tmp->next;
			eq = (equiv(tmp->data, tmp_string->data));
		}
		if (eq)
		{
			tmp->value++;
			delete tmp_string;
		}
		else
		{
			tmp->next = tmp_string;
			tmp->next->value++;
		}
	}
}

List *find (char *str, List **hash)
{
	int tmp_hash = h(str);
	List *tmp = hash[tmp_hash];
	bool eq = (equiv(str, tmp->data));
	while(tmp->next && !eq)
		{
			tmp = tmp->next;
			eq = (equiv(tmp->data, str));
		}
	if (eq)
		return tmp;
	else
	{
		cout << "not found";
		return tmp;
	}
}

void del (char *str, List **hash)
{
	int tmp_hash = h(str);
	List *tmp = hash[tmp_hash];
	List *prev = tmp;
	bool eq = (equiv(str, tmp->data));
	while(tmp->next && !eq)
		{
			prev = tmp;
			tmp = tmp->next;
			eq = (equiv(tmp->data, str));
		}
	if (eq)
	{
		prev->next = tmp->next;
		delete tmp;
	}
		
	else
		cout << "not found";
}








		
	
	
