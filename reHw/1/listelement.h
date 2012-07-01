#pragma once

class ListElement
{
public:
    ListElement(): value(0), next(0)
    {}
    ListElement(int a, ListElement*b): value(a), next(b)  
    {}    
    int setValue()
    {
        return value;
    }
    ListElement * getNext()
    {
        return next;
    }
    void setNext(ListElement *a)
    {
        next =  a;
    }
private:
    int value;
    ListElement * next;
};
