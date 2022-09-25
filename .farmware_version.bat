@echo off

REM ------------------------------------------------------------------------------
REM .NET Framework 4系バージョンの確認
REM ------------------------------------------------------------------------------
set NETFRAMEWORKPATH=%~dp0
cd /d "%windir%\system32\"

setlocal enabledelayedexpansion

REM 引数（リモート・コンピュータ名）の確認
if %1. == . (
    set RemoteName=
    echo ローカル・コンピュータ（%COMPUTERNAME%）
) else (
    set RemoteName=%1\
    echo %1
)

REM レジストリに参照できるか確認
reg query %RemoteName%HKLM\SOFTWARE\Microsoft 1>nul
if errorlevel 1 (
    echo %0： レジストリを参照できません。エラーが発生しました。
    pause
    endlocal
    exit /b
)

REM レジストリ・エントリの指定
REM .NET Frameworkのレジストリを参照
set RegKey11=%RemoteName%HKLM\SOFTWARE\Microsoft\NET Framework Setup\NDP

REM .NET Frameworkのバージョン確認
call :GetVersion ".NET Framework 4" "%RegKey11%\v4"

endlocal
echo.

pause
exit /b

REM -------------------------------------------------
REM  .NET Framework 4系のバージョン取得
REM -------------------------------------------------
:GetVersion
    set result=

    REM インストールの確認
    reg query "%~2\Full" /v "Install" 2>nul | find /I "Install" 2>nul | find /I "0x1" 1>nul 2>nul
    set nf4=%errorlevel%

    if %nf4%==1 (
            echo.
            echo .NETFramework4.0系統が未インストール
    ) else (
            FOR /F "TOKENS=1,2,*" %%A IN ('reg query "%~2\Full" /v "Release"') DO IF "%%A"=="Release" SET /A GET_VALUE=%%C
            set result="No 4.5 or later version detected"

            if !GET_VALUE! geq 378389 set result=4.5
            if !GET_VALUE! geq 378675 set result=4.5.1
            if !GET_VALUE! geq 379893 set result=4.5.2
            if !GET_VALUE! geq 393295 set result=4.6
            if !GET_VALUE! geq 394254 set result=4.6.1
            if !GET_VALUE! geq 394802 set result=4.6.2
            if !GET_VALUE! geq 460798 set result=4.7
            if !GET_VALUE! geq 461308 set result=4.7.1
            if !GET_VALUE! geq 461808 set result=4.7.2
            if !GET_VALUE! geq 528040 set result=4.8 or later
            echo.
            echo .NET Frameworkバージョン !result!
    )

exit /b0411