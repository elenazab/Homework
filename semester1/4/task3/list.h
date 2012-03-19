using namespace std;

struct List
{
	int data;
	List *next;
};

void deleteList(List *x);
List *createList();
void add (List *head, int x);
void del(List *head);
void printList(List *head);