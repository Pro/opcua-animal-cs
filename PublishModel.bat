@ECHO off
REM ****************************************************************************************************************
REM ** --
REM ** This script demonstrates how to use the model compiler to generate source code from a variety
REM ** of XML files that adhere to the 'Nodeset2.xml' format. Please refer to the UA Specifications Part 6
REM ** for more information.
REM ** --
REM ****************************************************************************************************************
SETLOCAL

SET DIR=%~dp0
set MODELCOMPILER=.model_compiler\Bin\Debug\Opc.Ua.ModelCompiler.exe
set SOURCE=%1
set TARGET=%2
set OUTPUT=..\nodesets

IF NOT "%3"=="" (set OUTPUT=%OUTPUT%\%3) else (set OUTPUT=%OUTPUT%\master)
IF NOT "%3"=="" set VERSION=-version %3
IF NOT "%4"=="" set EXCLUDE=-exclude %4

ECHO Building Model %TARGET%
IF NOT EXIST "%OUTPUT%\%TARGET%" MKDIR "%OUTPUT%\%TARGET%"
ECHO %MODELCOMPILER% %VERSION% %EXCLUDE% -d2 "%SOURCE%.xml" -cg "%SOURCE%.csv" -o2 "%OUTPUT%\%TARGET%\"
pushd .
cd %DIR%/model_compiler
%MODELCOMPILER% %VERSION% %EXCLUDE% -d2 "%SOURCE%.xml" -cg "%SOURCE%.csv" -o2 "%OUTPUT%\%TARGET%\"
popd
IF %ERRORLEVEL% NEQ 0 ( ECHO Failed %TARGET% & EXIT /B 3 )

ECHO Copying Model files to %OUTPUT%\%TARGET%\%SOURCE%
COPY "%SOURCE%.xml" "%OUTPUT%\%TARGET%\"
COPY "%SOURCE%.csv" "%OUTPUT%\%TARGET%\"
DEL /f /q "%OUTPUT%\%TARGET%\*NodeSet.xml"
GOTO theEnd

:noModelCompiler
ECHO.
ECHO ModelCompiler not found. Please make sure it is compiled in RELEASE mode.
ECHO Searched for: %MODELCOMPILER%

:theEnd
ENDLOCAL