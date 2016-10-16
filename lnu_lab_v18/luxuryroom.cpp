#include "luxuryroom.h"

LuxuryRoom::LuxuryRoom()
{

}

LuxuryRoom::LuxuryRoom(QString roomClass,int amountOfPeople, double priceForRoom):
    mRoomClass{roomClass},
    mAmountOfPeople{amountOfPeople},
    mPriceForRoom{priceForRoom}
{

}

double LuxuryRoom::moneyForRoom()
{
    return mMoneyForRoom;
}

