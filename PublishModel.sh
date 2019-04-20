#!/bin/bash

#****************************************************************************************************************
#** --
#** This script demonstrates how to use the model compiler to generate source code from a variety
#** of XML files that adhere to the 'Nodeset2.xml' format. Please refer to the UA Specifications Part 6
#** for more information.
#** --
#****************************************************************************************************************

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
export MODELCOMPILER=$DIR/model_compiler/Bin/Debug/Opc.Ua.ModelCompiler.exe
export DOCUGENERATOR=$DIR/model_compiler/Bin/Debug/Opc.Ua.DocuGenerator.exe

if [ "$#" -ne 3 ]; then
    echo "Usage: SOURCE_MODEL.xml TARGET_MODEL_FILE OUTPUT_DIR"
    exit 3
fi

export SOURCE=$1
export TARGET=$2
export OUTPUT=$3

echo Building Model ${TARGET}
mkdir -p "${OUTPUT}/${TARGET}"

pushd $(pwd)
cd $DIR/model_compiler
echo ${MODELCOMPILER} -console -d2 "$(realpath ${SOURCE}.xml)" -cg "$(realpath ${SOURCE}.csv)" -o2 "$(realpath ${OUTPUT}/${TARGET}/)"
mono ${MODELCOMPILER} -console -d2 "$(realpath ${SOURCE}.xml)" -cg "$(realpath ${SOURCE}.csv)" -o2 "$(realpath ${OUTPUT}/${TARGET}/)"
popd
if [ $? -ne 0 ]; then
	echo "Failed ${TARGET}"
	exit 3
fi

#echo ${DOCUGENERATOR} -m "../${SOURCE}.xml" -c "../${SOURCE}.csv" -wo "${OUTPUT}/${TARGET}_Docu.docx"
#${DOCUGENERATOR} -m "../${SOURCE}.xml" -c "../${SOURCE}.csv" -wo "${OUTPUT}/${TARGET}_Docu.docx"
#if [ $? -ne 0 ]; then
#	echo "Failed ${TARGET}"
#	exit 3
#fi

echo Copying Model files to $(realpath ${OUTPUT}/${TARGET})
cp "$(realpath ${SOURCE}.xml)" "${OUTPUT}/${TARGET}/"
cp "$(realpath ${SOURCE}.csv)" "${OUTPUT}/${TARGET}/"
rm -f "${OUTPUT}/${TARGET}/*NodeSet.xml"
