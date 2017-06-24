# Open Raman

The History:

I started this project for fun. I'm a science lover, especially involving physics and chemistry.

I have a lot of experience designing 3D printer parts for the industry, so i decided apply this knowledge to design an easy to build Professional Raman Spectrometer, using FDM and SLS 3D printer technology.

The goal of the project is, have in the end of the project, a reliable spectrometer costing less than 1K euros, for research purposes and everything that you consider fun to use a high end spectrophotometer.

The 5 pillars of the project:

The spectrometer case made of laser cutting steel sheets ( as a lab and sensitive equipment, I think a metal case can be better for reliability of the equipment).

All the custom made parts of the equipment designed to be printed in FDM and SLS 3D printers, SLS is expensive but it make our lifes easier to align the optics.

The spectometer unit will be constructed in a module form factor, and with independent eletronic for control the data acquisition, the reason to do that what is with this approach the unit can be used for another spectometer techniques and different uses.

The electronics will use cheap devlopment boards with simpler as possible shields to provide the interface for all the hardware.

The design will focus on use of less as possible expensive optics but without loose quality of amostration.

Electronics Description:

The electronics will be composed of two ST Microeletronics Devlopment boards: 

IHM: https://developer.mbed.org/platforms/ST-Discovery-F469NI/

A cheaper devlopment board with a nice high resolution LCD to show the wavelenght captured with a Cortex M4 processor with a lot of headroom for a richer GUI.

Main Board:  https://developer.mbed.org/platforms/ST-Nucleo-F429ZI/

A cheaper devlopment board with ethernet connection to allow remote control of the spectometer and access to spectro database information on web, to provide to end users true data about the sample composition.

Another details of the project will be supplied in Project Documentation Folder.


This work is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.