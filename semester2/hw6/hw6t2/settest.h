#include <QtCore/QtCore>
#include <QtTest/QtTest>
#include "set.h"

class SetTest : public QObject
{
    Q_OBJECT
public:
    explicit SetTest(QObject *parent = 0):QObject(parent){}

private slots:

    void init()
    {
        obj = new Set<int>;
        obj2 = new Set<int>;
    }

    void testAdd()
    {
        QVERIFY(!obj->exist(1));
        obj->add(1);
        QVERIFY(obj->exist(1));
    }

    void testExist()
    {
        obj->add(8);
        QVERIFY(obj->exist(8));
    }

    void testDel()
    {
        obj->add(1);
        obj->add(2);
        QVERIFY(obj->exist(1) && obj->exist(2));
        obj->del(2);
        QVERIFY(obj->exist(1));
        QVERIFY(!obj->exist(2));
    }

    void testUnion()
    {
        obj->add(1);
        obj->add(2);
        obj2->add(3);
        obj->unionOfSet(obj2);
        QVERIFY(obj->exist(2) && obj->exist(1) && obj->exist(3));
    }

    void testIntersection()
    {
        obj->add(1);
        obj->add(2);
        obj2->add(3);
        obj2->add(2);
        obj->intersectionOfSet(obj2);
        QVERIFY(obj->exist(2));
        QVERIFY(!obj->exist(1));
        QVERIFY(!obj->exist(3));
    }

private:
    Set<int> *obj;
    Set<int> *obj2;
};
