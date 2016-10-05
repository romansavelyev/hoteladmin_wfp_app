#ifndef HOTEL_H
#define HOTEL_H

#include "hotelroom.h"
#include "client.h"
#include <QString>
#include <QVector>


// test class
class Hotel
{
public:
    Hotel();

private:
    QVector<HotelRoom*> mHotelRoomV;
    QVector<Client*> mClientV;
};

#endif // HOTEL_H
