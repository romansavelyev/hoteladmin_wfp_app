#include "client.h"

Client::Client()
{

}

Client::Client(int &passportData, int &accomodationDate, int &checkOutDate, int &roomNumber):
    mPassportData{passportData},
    mAccomodationDate{accomodationDate},
    mCheckOutDate{checkOutDate},
    mRoomNumber{roomNumber}
{

}

int Client::passportData() const
{
    return mPassportData;
}

void Client::setPassportData(const int &passportData)
{
    mPassportData = passportData;
}

int Client::accomodationDate() const
{
    return mAccomodationDate;
}

void Client::setAccomodationDate(const int &accomodationDate)
{
    mAccomodationDate = accomodationDate;
}

int Client::checkOutDate() const
{
    return mCheckOutDate;
}

void Client::setCheckOutDate(const int &checkOutDate)
{
   mCheckOutDate = checkOutDate;
}

int Client::roomNumber() const
{
    return mRoomNumber;
}

void Client::setRoomNumber(const int &roomNumber)
{
   mRoomNumber = roomNumber;
}
