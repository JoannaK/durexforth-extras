
Some alternative pseudorandom routines for C64 durexforth. 

Sidrnd uses Sid chip voice3 readback register with Noise waveform and fast updates.

LFSR uses linear feedbak shift register to generate bits. At the moment routine uses only 15 bit 
feedback register, might be usefull to at at least on byte on it. 
