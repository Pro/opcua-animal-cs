#!/usr/bin/env bash

sudo apt install mono-devel mono-complete

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"

pushd $(pwd)

cd $DIR/model_compiler
wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mono nuget.exe install -OutputDirectory packages ModelCompiler/packages.config
msbuild "ModelCompiler Solution.sln" /p:TargetFrameworkVersion="v4.5"

popd