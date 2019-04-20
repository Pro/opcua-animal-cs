SET DIR=%~dp0

pushd .
cd %DIR%
PublishModel.bat %DIR%animalModel animal %DIR%Published
popd
