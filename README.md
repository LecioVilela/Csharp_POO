## Comandos utilizados no CLI:
Neste caso vamos usar --name nomear um projeto e --output para indicar que o projeto possa ficar na mesma pasta.
O comando a baixo lista vários recursos que podem ser utilizados também.
```
dotnet new --help
```
## Criando o arquivo de solução (sln):
```
dotnet new sln --name NomeDoProjeto
```
## Criando um projeto do tipo console:
```
dotnet new console --name NomeDoProjeto --output NomeDoProjeto
```
## Criando um projeto ASP NET CORE - Web Api:
```
dotnet new webapi --name NomeDoProjeto --output NomeDoProjeto
```
## Indicando o arquivo csproj ao sln:
```
dotnet sln add ./NomeDoProjeto/NomeDoProjeto.csproj
```
## Setando vários projetos StartUp no visual studio code:
launch.json
```
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch Project1",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceRoot}/project1/bin/Debug/netcoreapp2.0/project1.dll",
            "args": [],
            "cwd": "${workspaceRoot}/project1",
            "stopAtEntry": false,
            "console": "externalTerminal"
        },
        {
            "name": ".NET Core Launch Project2",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceRoot}/project2/bin/Debug/netcoreapp2.0/project2.dll",
            "args": [],
            "cwd": "${workspaceRoot}/project2",
            "stopAtEntry": false,
            "console": "externalTerminal"
        }
    ]
}
``` 
tasks.json
```
{
    "version": "0.1.0",
    "command": "dotnet",
    "isShellCommand": true,
    "args": [],
    "tasks": [
        {
            "taskName": "build",
            "args": [
                "${workspaceRoot}/project1/project1.csproj"
            ],
            "isBuildCommand": true,
            "problemMatcher": "$msCompile"
        },
        {
            "taskName": "build",
            "args": [
                "${workspaceRoot}/project2/project2.csproj"
            ],
            "isBuildCommand": true,
            "problemMatcher": "$msCompile"
        }
    ]
}
```