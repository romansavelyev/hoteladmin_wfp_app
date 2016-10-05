#ifndef CLIENT_H
#define CLIENT_H

#include <QString>
#include <QVector>
#include"hotel.h"


//abstract of client hierarchy
class Client
{
public:
    Client();
    Client(int &passportData,int &accomodationDate, int &checkOutDate, int &roomNumber);

    ~Client();

    virtual void amoutOfMoney() = 0;

    int passportData() const;
    void setPassportData(const int &passportData);

    int accomodationDate() const;
    void setAccomodationDate(const int &accomodationDate);

    int checkOutDate() const;
    void setCheckOutDate(const int &checkOutDate);

    int roomNumber() const;
    void setRoomNumber(const int &roomNumber);

private:
    int mPassportData;
    int mAccomodationDate;
    int mCheckOutDate;
    int mRoomNumber;
};

#endif // CLIENT_H
