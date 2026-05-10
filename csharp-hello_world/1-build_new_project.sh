#!/usr/bin/env bash
mkdir -p 1-new_project
dotnet new console -o 1-new_project
cd 1-new_project
dotnet build 1-new_project
