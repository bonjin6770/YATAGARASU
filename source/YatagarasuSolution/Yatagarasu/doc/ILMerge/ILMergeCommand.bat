rem change directory to current
pushd %0\..
cls

rem http://roman.st/Article/ILMerge-and-GeneratedInternalTypeHelper?lang=en
rem ����̂�����ILMerge���g���Ȃ�

rem �t�@�C���폜�i�O��̎��s���ʂ����ׂăN���A����j

if exist "exe\Yatagarasu.exe" ( del "exe\Yatagarasu.exe" )
if exist "exe\" ( rmdir "exe\" )

mkdir exe

ILMerge.exe /wildcards /out:merged-Yatagarasu.exe yatagarasu.exe *.dll

if exist merged-Yatagarasu.exe ( copy merged-Yatagarasu.exe exe\Yatagarasu.exe )
if exist merged-Yatagarasu.exe ( del .\merged-Yatagarasu.exe )


pause
exit
