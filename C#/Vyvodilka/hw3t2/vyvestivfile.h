#pragma once
#include <fstream>
#include "vyvodilka.h"
using namespace std;

template <typename T>
class VyvestiVFile: public Vyvodilka<T>
{
public:
    VyvestiVFile();
    ~VyvestiVFile();
    virtual void vyvesty(T x);
};

template <typename T>
VyvestiVFile<T>::VyvestiVFile()
{
}

template <typename T>
VyvestiVFile<T>::~VyvestiVFile()
{
}

template <typename T>
void VyvestiVFile<T>::vyvesty(T x)
{
    ofstream fout("text.txt",ios::out|ios::app);
    fout << x << " ";
}
