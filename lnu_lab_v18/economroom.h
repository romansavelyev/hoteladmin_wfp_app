#ifndef ECONOMROOM_H
#define ECONOMROOM_H

#include "hotelroom.h"
class EconomRoom : public HotelRoom
{
public:
    EconomRoom();
    EconomRoom(QString roomClass,int amountOfPeople, double priceForRoom);
    double moneyForRoom();
    virtual void showMoneyForRoom() override;
private:
    double mMoneyForRoom;
};

#endif // ECONOMROOM_H
