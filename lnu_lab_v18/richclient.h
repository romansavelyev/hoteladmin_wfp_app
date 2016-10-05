#ifndef RICHCLIENT_H
#define RICHCLIENT_H

#include "client.h"

class RichClient : public Client
{
public:
    RichClient();
    RichClient(int &passportData,int &accomodationDate, int &checkOutDate, int &roomNumber);
    virtual void amountOfMoney() override;
};

#endif // RICHCLIENT_H
