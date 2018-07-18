color 1f

title YEDEKLEME

cd yedek
@echo if exist *.rar_XX goto sil else goto silme
@echo :sil
@echo del *.rar /p
@echo del backup.log
cls
:silme
//nologo
rar a -r -x*.rar -x*.exe -x*.zip -x*.pdb -ed -ep1 -agDDMMYYYYHHMM  novaambarppc- "D:\Projeler\Huseyin\Nova Plastik\AmbarPPC"
cls
@echo bitti

@echo del backup.log

SET FAIL="Dosyalar Yedeklendi"

FOR /F "tokens=1,2,3 delims=/ " %%I IN ('DATE /T') DO SET date1=%%I%%J%%K
FOR /F "tokens=1,2 delims=: " %%I IN ('TIME /T') DO SET time1=%%I:%%J

ECHO %date1% %time1%  %FAIL% >>backup.log& GOTO :EOF

exit




