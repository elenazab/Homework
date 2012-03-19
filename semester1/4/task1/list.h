struct List
{
	char data;
	List *next;
};

void deleteList(List *x);
List *createList();
void add (List *head, char x);
void del(List *head);
void printList(List *head);

