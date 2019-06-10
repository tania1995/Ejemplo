@echo off
rem START or STOP Services
rem ----------------------------------
rem Check if argument is STOP or START

if not ""%1"" == ""START"" goto stop


"D:\tarea tania\instalar\mysql\bin\mysqld" --defaults-file="D:\tarea tania\instalar\mysql\bin\my.ini" --standalone --console
if errorlevel 1 goto error
goto finish

:stop
"D:\tarea tania\instalar\apache\bin\pv" -f -k mysqld.exe -q

if not exist "D:\tarea tania\instalar\mysql\data\%computername%.pid" goto finish
echo Delete %computername%.pid ...
del "D:\tarea tania\instalar\mysql\data\%computername%.pid"
goto finish


:error
echo MySQL could not be started

:finish
exit
