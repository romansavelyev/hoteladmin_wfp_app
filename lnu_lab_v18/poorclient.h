#ifndef POORCLIENT_H
#define POORCLIENT_H

#include "client.h"

class PoorClient : public Client
{
public:
    PoorClient();
    PoorClient(int passportData,int accomodationDate, int checkOutDate, int roomNumber);
    virtual void amountOfMoney() override;
};

#endif // POORCLIENT_H
