#include <iostream>
#include "Set.h"
#include "settest.h"

//using namespace std;

int main()
{
    SetTest test;
    QTest::qExec(&test);
    return 0;
}

