This service exposes hypixel profile data in smal easy to consume chunks.  
It caches each profile (split into parts) seperatetly in redis to safe bandwith and time.



## Configuration
See appsettings.json all of the settings in there can be overwritten by enviroment variables.  
The container port is `8000` it runs as nonroot user.


