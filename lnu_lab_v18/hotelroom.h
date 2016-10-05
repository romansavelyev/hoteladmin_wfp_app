#ifndef HOTELROOM_H
#define HOTELROOM_H

#include <QString>
#include <QVector>
#include"hotel.h"

//abstract of room hierarhy
class HotelRoom
{
public:
    HotelRoom();
    HotelRoom(QString &roomClass,int &amountOfPeople, double &priceForRoom);
    ~HotelRoom();

    virtual void showMoneyForRoom() = 0;

    QString roomClass() const;
    void setRoomClass(const QString &roomClass);

    int amountOfPeople() const;
    void setAmountOfPeople(const int &amountOfPeople);

    double priceForRoom() const;
    void setPriceForRoom(const double &priceForRoom);


private:
    QString mRoomClass;
    int mAmountOfPeople;
    double mPriceForRoom;

};

#endif // HOTELROOM_H
