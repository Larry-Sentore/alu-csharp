#!/usr/bin/env bash
dotnet new console -o 2-new_project --force
dotnet build 2-new_project
cd 2-new_project
dotnet run
