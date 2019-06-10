@echo off
rem START or STOP Services
rem ----------------------------------
rem Check if argument is STOP or START

if not ""%1"" == ""START"" goto stop

if exist D:\tarea tania\instalar\hypersonic\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\server\hsql-sample-database\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\ingres\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\ingres\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\mysql\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\mysql\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\postgresql\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\postgresql\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\apache\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\apache\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\openoffice\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\openoffice\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\apache-tomcat\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\apache-tomcat\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\resin\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\resin\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\jboss\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\jboss\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\jetty\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\jetty\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\subversion\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\subversion\scripts\ctl.bat START)
rem RUBY_APPLICATION_START
if exist D:\tarea tania\instalar\lucene\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\lucene\scripts\ctl.bat START)
if exist D:\tarea tania\instalar\third_application\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\third_application\scripts\ctl.bat START)
goto end

:stop
echo "Stopping services ..."
if exist D:\tarea tania\instalar\third_application\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\third_application\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\lucene\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\lucene\scripts\ctl.bat STOP)
rem RUBY_APPLICATION_STOP
if exist D:\tarea tania\instalar\subversion\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\subversion\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\jetty\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\jetty\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\hypersonic\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\server\hsql-sample-database\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\jboss\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\jboss\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\resin\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\resin\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\apache-tomcat\scripts\ctl.bat (start /MIN /B /WAIT D:\tarea tania\instalar\apache-tomcat\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\openoffice\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\openoffice\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\apache\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\apache\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\ingres\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\ingres\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\mysql\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\mysql\scripts\ctl.bat STOP)
if exist D:\tarea tania\instalar\postgresql\scripts\ctl.bat (start /MIN /B D:\tarea tania\instalar\postgresql\scripts\ctl.bat STOP)

:end

