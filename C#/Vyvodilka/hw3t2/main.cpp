#include <iostream>
#include "vyvodilka.h"
#include "xodilka.h"
#include "vyvestinakonsol.h"
#include "vyvestivfile.h"
#include "tests.h"


int main()
{
    Tests test;
    QTest::qExec(&test);
    return 0;
}
