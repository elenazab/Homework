#include <iostream>
#include "uniquelist.h"
#include "tests.h"

//using namespace std;

int main()
{
    Tests test;
    QTest::qExec(&test);
    return 0;
}

