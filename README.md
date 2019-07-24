# opcua-animal-cs
OPC UA Companion Specification for Animals - A Tutorial

The full tutorial for this repository can be found here:
https://opcua.rocks/custom-information-models/

A sample OPC UA Server using this CS can be found here:
https://github.com/Pro/opcua-animal-server

## How to initialize

First you need to clone and initialize this git repository:

```bash
git clone https://github.com/Pro/opcua-animal-cs
cd opcua-animal-cs
git submodule update --init --recursive
```

## Build the model

There are three possibilities to build your model:

1. Linux: Docker Container
2. Linux: Command line
3. Windows: Command line

The recommended and easiest way is the first one using docker.

### Linux: Docker Container

To build this `Model.xml` file using docker, you can use my prepared docker container.
It is based on the official UA-ModelCompiler source code.
There's currently an open pull-request (https://github.com/OPCFoundation/UA-ModelCompiler/pull/36) to add the necessary docker files to the official repository. In the meantime you can use my docker container:
[sailavid/ua-modelcompiler](https://hub.docker.com/r/sailavid/ua-modelcompiler).
You can also build the container on your own using the Dockerfile from the base repository: (https://github.com/Pro/UA-ModelCompiler/tree/feature/docker)

1. Make sure you have docker installed
2. `cd opcua-animal-cs`
3. Then run the model compiler:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/animalModel animal /model/src/Published
	```
4. This will create the resulting files in the `Published` folder inside the root of the repository.


### Linux: Command Line

On linux you need to install the mono package and build the model compiler using msbuild.

1. execute the `init_compiler.sh` script, this will prepare everything for you.
2. Run `build_model.sh` which will call the model compiler binary from previous step

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

Then you can use `build_model.bat` to compile the NodeSet2.xml from the Model.xml file.
