# Yu-NostalgiaMenu
Application that allows for Multiple PAN/NBT games run on Nostalgia Cabinet.
Its built in mind to run on a Nostalgia Cabinet using a Beatstream Image, as that image is prepped for all DX Options to allow BG Videos and other things work correctly. 

Ensure you fill out the games.ini file, the application will read what sections and values you put in, You can mix and match games and data. The ini file contains additional information. Ensure you have the "launcher" value pointed to the boot file for the specified game.

By default the it will launch what you put under DEFAULT GAME after 60 secs.

Its best to point the launcher parameter to the games start.bat bootstrap file, for nostalgia that would look like below.

> [NOSTALGIA Op.1 2017-06-27]
> 
> launcher=D:/games/PAN_2017062700/start.bat
    
    
> [NOSTALGIA Op.1 2018-06-20]
> 
> launcher=D:/games/PAN_2018062002/start.bat
    
    
> [DEFAULT GAME]
> 
> launcher=D:/games/PAN_081816/start.bat"
