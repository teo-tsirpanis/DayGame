@echo off

REM This script requires version 6.0.0 of Inno Setup to be added to PATH.
rmdir published /S /Q
dotnet publish Source\DayGame.csproj -c Release -o published --no-self-contained
iscc DayGame.iss
