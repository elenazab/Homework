#pragma once
#include <iostream>
using namespace std;

class List
{
public:
    List(): head (NULL)
    {}
    ~List();
    void add(int x);
    int valueHead();
    void print();
private:
ListElement *head;
};



