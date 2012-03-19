struct Stack
{
	char data;
	Stack *next;
};

void push(Stack *top, char x);
bool isEmpty (Stack *top);
int pop(Stack *top);
void deleteStack(Stack *top);

