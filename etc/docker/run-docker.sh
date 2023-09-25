#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p c4c2a05a-e4d0-484c-8273-cb4808b3877f -t
    fi
    cd ../
fi

docker-compose up -d
