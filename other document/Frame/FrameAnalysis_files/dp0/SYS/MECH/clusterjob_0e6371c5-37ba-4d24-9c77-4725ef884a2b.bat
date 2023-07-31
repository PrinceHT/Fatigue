@ECHO OFF
SETLOCAL
CHCP 65001
ECHO Job started on %COMPUTERNAME%
SET /A errno=0
ECHO ClusterSharedDirectory=C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811
IF NOT EXIST "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\." goto NOSTAGINGDIR
ECHO AWP_ROOT232=%AWP_ROOT232%
IF "%AWP_ROOT232%" == "" GOTO NOAWPROOTENV
IF NOT EXIST "%AWP_ROOT232%\." goto NOAWPROOTDIR
ECHO Command=%AWP_ROOT232%/commonfiles/CPython/3_10/winx64/Release/python/python.exe
IF NOT EXIST "%AWP_ROOT232%/commonfiles/CPython/3_10/winx64/Release/python/python.exe" goto NOCOMMAND
ECHO running the commmand
ECHO command: "%AWP_ROOT232%/commonfiles/CPython/3_10/winx64/Release/python/python.exe" -B -E "%AWP_ROOT232%/RSM/Config/scripts/ClusterJobs.py" "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\control_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsm"
"%AWP_ROOT232%/commonfiles/CPython/3_10/winx64/Release/python/python.exe" -B -E "%AWP_ROOT232%/RSM/Config/scripts/ClusterJobs.py" "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\control_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsm"
IF %ERRORLEVEL% NEQ 0 SET /A errno=%ERRORLEVEL%
GOTO END
:NOAWPROOTENV
ECHO The AWP_ROOT232 environment variable was NOT detected.
ECHO 1000 > "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\exitcode_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsmout"
SET /A errno=1000
GOTO END
:NOCOMMAND
ECHO Command was NOT detected on execution host.
ECHO 1007 > "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\exitcode_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsmout"
SET /A errno=1007
GOTO END
:NOSTAGINGDIR
ECHO Shared cluster directory does not exist on execution node, make sure it is shared and can be accessed from all nodes.
ECHO 1008 > "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\exitcode_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsmout"
SET /A errno=1008
GOTO END
:NOAWPROOTDIR
ECHO AWP_ROOT232 directory does not exist on execution host.
ECHO 1009 > "C:\Users\vu.le\OneDrive - Bluetech Finland Oy\Tiedostot\GitHub\Fatigue\other document\Frame\_ProjectScratch\Scr9811\exitcode_0e6371c5-37ba-4d24-9c77-4725ef884a2b.rsmout"
SET /A errno=1009
GOTO END
:END
EXIT /B %errno%
