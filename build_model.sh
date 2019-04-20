#!/usr/bin/env bash

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
pushd $(pwd)
cd $DIR
./PublishModel.sh $DIR/animalModel animal $DIR/Published
popd
