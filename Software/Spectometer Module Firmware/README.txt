#Spectometer Module Fimware

This firmware is responsible for spectometer data aquisition.

Tasks:

1 - Data aquisition of the CCD Array.

2 - Control the temperature of the CCD Array with peltier module.
2.1 - Read the temperature with a termistor.
2.2 - Modulate a pwm to control the peltier power.
2.3 - Control the Peltier Fan.

3 - Interface with external world by USB and serial interface