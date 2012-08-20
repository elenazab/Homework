#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QtCore/QDebug>

MainWindow::MainWindow(QWidget *parent)
    :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    connect(ui->spinBox, SIGNAL(valueChanged(int)), this, SLOT(changed()));
    connect(ui->spinBox_2, SIGNAL(valueChanged(int)), this, SLOT(changed()));
    connect(ui->comboBox, SIGNAL(currentIndexChanged(int)), this, SLOT(changed()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

int MainWindow::calc(int a, int b, char operation)
{
    switch (operation)
    {
    case '+':
        return a + b;
    case '-':
        return a - b;
    case '*':
        return a * b;
    case '/':
        return a / b;
    }
}

void MainWindow::changed()
{
    int a = ui->spinBox->value();
    int b = ui->spinBox_2->value();
    char c = ui->comboBox->currentText().data()[0].toAscii();
    if (b == 0 && c == '/')
        ui->textEdit->setText("error");
    else
    {
        int result = calc(a, b, c);
        ui->textEdit->setText(QString::number(result));
    }
}
