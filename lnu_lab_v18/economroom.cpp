#include "economroom.h"

EconomRoom::EconomRoom()
{

}

EconomRoom::EconomRoom(QString &roomClass,int &amountOfPeople, double &priceForRoom):
    mRoomClass{roomClass},
    mAmountOfPeople{amountOfPeople},
    mPriceForRoom{priceForRoom}
{

}

double EconomRoom::moneyForRoom()
{
   return mMoneyForRoom;
}

