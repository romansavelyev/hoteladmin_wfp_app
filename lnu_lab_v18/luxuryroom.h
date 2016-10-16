#ifndef LUXURYROOM_H
#define LUXURYROOM_H

#include "hotelroom.h"

class LuxuryRoom : public HotelRoom
{
public:
    LuxuryRoom();
    LuxuryRoom(QString roomClass,int amountOfPeople, double priceForRoom);
    double moneyForRoom();
    virtual void showMoneyForRoom() override;

private:
    double mMoneyForRoom;
};

#endif // LUXURYROOM_H
