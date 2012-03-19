struct Stack
{
	char data;
	Stack *next;
};

void push(Stack *top, char x);
bool isEmpty (Stack *top);
void del_one(Stack *top);

