
Some alternative pseudorandom routines for C64 durexforth. 

Sidrnd uses Sid chip voice3 readback register with Noise waveform and fast updates. Also includes couple routines for rnd testing

LFSR uses linear feedbak shift register to generate bits. At the moment routine uses only 15 bit 
feedback register, might be usefull to add at least on byte on it. 
For xor-taps, https://www.xilinx.com/support/documentation/application_notes/xapp052.pdf
