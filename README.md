# crm

## setup
* install docker desktop
* pull sql server image:
* * sudo docker pull mcr.microsoft.com/mssql/server:2022-latest
* run sql server on docker
* * docker run -d --name sql_server_test -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest 

to be continued....

