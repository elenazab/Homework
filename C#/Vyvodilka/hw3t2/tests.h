#include <QtTest/QtTest>
#include "xodilka.h"
#include "vyvestinakonsol.h"
#include "vyvestivfile.h"

class Tests : public QObject
{
    Q_OBJECT
public:
    explicit Tests(QObject *parent = 0):QObject(parent){}

private slots:

    void init()
    {

       obj = new VyvestiNaKonsol<int>;

    }

    void test()
    {
        int b[3][3]={5,3,2,7,1,8,4,3,2};
        Xodilka<int> x (obj);
        x.obojty(b);
        //!!!!!!!!!!
    }

private:
    Vyvodilka<int> *obj;
};
