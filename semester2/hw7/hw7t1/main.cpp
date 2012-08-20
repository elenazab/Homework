#include "iostream"
#include "exception.h"
#include "ololo.h"

using namespace std;

int main()
{
    try
    {
        Ololo ololo;
        throw Exception();
    }
    catch (Exception)
    {
        cout << "exception";
    }

    return 0;
}

