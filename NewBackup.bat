
COLOR 1f

TITLE YEDEK


SET M=1

cd yedek

:silme
if exist %M%.rar goto artir
rar a -r -x*.rar -x*.exe -x*.pdb -ed -ep1 %M% "D:\Projeler\Huseyin\Nova Plastik\AmbarPPC"

cls

SET FAIL="Dosyalar Yedeklendi " %M%

FOR /F "tokens=1,2,3 delims=/ " %%I IN ('DATE /T') DO SET date1=%%I%%J%%K
FOR /F "tokens=1,2 delims=: " %%I IN ('TIME /T') DO SET time1=%%I:%%J
ECHO %date1% %time1%  %FAIL% >>backup.log& GOTO :EOF

exit

:artir
set /a M=%M%+1
goto silme
