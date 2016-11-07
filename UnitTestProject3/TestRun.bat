@pushd %~dp0

@cd ..\packages\SpecRun.Runner.*\tools

set profile=Default
SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\Debug" /log:specrun.log

:end

@popd
pause