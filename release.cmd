@echo off

REM This script requires version 6.0.0 of Inno Setup to be added to PATH.
rmdir published /S /Q
dotnet publish Source\DayGame.csproj -c Release -o published /p:PublishTrimmed=true -r win-x86 /bl
iscc DayGame.iss
