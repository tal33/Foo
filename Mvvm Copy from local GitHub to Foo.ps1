Write-Host "Win 8.1"
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.CrossCore.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\win81
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.CrossCore.WindowsCommon.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\win81
copy-item ..\MvvmCross\bin\Release\Mvx\Portable\Cirrious.MvvmCross.Localization.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\win81

copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.MvvmCross.dll packages\MvvmCross.HotTuna.MvvmCrossLibraries.3.5.0-beta2\lib\win81
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.MvvmCross.WindowsCommon.dll packages\MvvmCross.HotTuna.MvvmCrossLibraries.3.5.0-beta2\lib\win81

Write-Host "Win Phone 8.1"
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.CrossCore.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\wpa81
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.CrossCore.WindowsCommon.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\wpa81
copy-item ..\MvvmCross\bin\Release\Mvx\Portable\Cirrious.MvvmCross.Localization.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\wpa81

copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.MvvmCross.dll packages\MvvmCross.HotTuna.MvvmCrossLibraries.3.5.0-beta2\lib\wpa81
copy-item ..\MvvmCross\bin\Release\Mvx\WindowsCommon\Cirrious.MvvmCross.WindowsCommon.dll packages\MvvmCross.HotTuna.MvvmCrossLibraries.3.5.0-beta2\lib\wpa81

Write-Host "Core"
copy-item ..\MvvmCross\bin\Release\Mvx\Portable\Cirrious.CrossCore.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\portable-win+net45+wp8+win8+wpa81
copy-item ..\MvvmCross\bin\Release\Mvx\Portable\Cirrious.MvvmCross.Localization.dll packages\MvvmCross.HotTuna.CrossCore.3.5.0-beta2\lib\portable-win+net45+wp8+win8+wpa81
copy-item ..\MvvmCross\bin\Release\Mvx\Portable\Cirrious.MvvmCross.dll packages\MvvmCross.HotTuna.MvvmCrossLibraries.3.5.0-beta2\lib\portable-win+net45+wp8+win8+wpa81

Write-Host "Done"

Start-Sleep -s 10

