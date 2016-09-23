# CJMCU-MLX90614

![Board Image](/board.jpg)

This little interface board is available on places like DealExtreme and BangGood, it appears to contain a Melexis MLX90614 non-contact IR thermometer and a small micro controller. By default the unit outputs TTL level serial data at 115200 baud and the data as per the output by default appears to contain the target temperature and the ambient temperature in four bytes of 16 bit data. This small bit of Visual Basic should help you decode the data and turn it into a readable format for use in your projects, please consider that you may wish to have some additional error checking in the returned data to ensure that you are indeed reading a temperature and not any of the other data. The data format I have found so far is;

Byte Number | Data Type
------------ | -------------
1 | Frame Header (102)
2 | Frame Header (102)
3 | Data Output Mode (1 if left in continuous mode)
4 | Data Length
5 | Target Temp High Byte
6 | Target Temp Low Byte
7 | Ambient Temp High Byte
8 | Ambient Temp Low Byte
9 | Data Parity Bit (appears to be 0)

The Visual Basic file on this project should hopefully give you an idea about how you can deal with the data in the unit directly into your serial ports (with appropriate level conversion).
