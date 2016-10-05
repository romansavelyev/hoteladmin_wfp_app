TEMPLATE = app

QT += qml quick
CONFIG += c++11

SOURCES += main.cpp \
    hotelroom.cpp \
    hotel.cpp \
    client.cpp \
    richclient.cpp \
    poorclient.cpp \
    luxuryroom.cpp \
    economroom.cpp

RESOURCES += qml.qrc

# Additional import path used to resolve QML modules in Qt Creator's code model
QML_IMPORT_PATH =

# Default rules for deployment.
include(deployment.pri)

HEADERS += \
    hotelroom.h \
    hotel.h \
    client.h \
    richclient.h \
    poorclient.h \
    luxuryroom.h \
    economroom.h
