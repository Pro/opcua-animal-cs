# opcua-animal-cs
OPC UA Companion Specification for Animals - A Tutorial

## How to initialize

First you need to clone and initialize this git repository:

```bash
git clone https://github.com/Pro/opcua-animal-cs
cd opcua-animal-cs
git submodule update --init --recursive
```

### Windows

On Windows you need to have at least the [Visual Studio Community edition](https://visualstudio.microsoft.com/vs/community/), which is free.

Open Visual Studio and then open the .sln Project in the `model_compiler` subfolder.

Building this in Debug mode should create the executables in `model_compiler/Bin/Debug`.

Otherwise you can also use the Visual Studio Command Line Prompt:

```bash
cd model_compiler
nuget.exe install -OutputDirectory packages ModelCompiler/packages.config
msbuild "ModelCompiler Solution.sln" /p:TargetFrameworkVersion="v4.5"
```

### Linux

On linux you need to install the mono package and build the model compiler using msbuild.

Just execute the `init_compiler.sh` script, this will prepare everything for you.

## How to build the NodeSet

Make sure that you first build the model compiler executable as described in previous section.

Then you can use `build_model.sh` to compile the NodeSet2.xml from the Model.xml file.
If you are on windows, use `build_model.bat` correspondingly.

## 