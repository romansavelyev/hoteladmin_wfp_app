#include "hotelroom.h"

HotelRoom::HotelRoom()
{

}

HotelRoom::HotelRoom(QString &roomClass,int &amountOfPeople, double &priceForRoom):
    mRoomClass{roomClass},
    mAmountOfPeople{amountOfPeople},
    mPriceForRoom{priceForRoom}
{

}

QString HotelRoom::roomClass() const
{
    return mRoomClass;
}

void HotelRoom::setRoomClass(const QString &roomClass)
{
    mRoomClass = roomClass;
}

int HotelRoom::amountOfPeople() const
{
    return mAmountOfPeople;
}

void HotelRoom::setAmountOfPeople(const int &amountOfPeople)
{
    mAmountOfPeople = amountOfPeople;
}

double HotelRoom::priceForRoom() const
{
    return mPriceForRoom;
}

void HotelRoom::setPriceForRoom(const double &priceForRoom)
{
    mPriceForRoom = priceForRoom;
}
