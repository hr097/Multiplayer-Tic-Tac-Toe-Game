For Installation of .NET CORE 6.0 in Linux :

Run the following command in Terminal(You can open Terminal by pressing : Alt + T )

1) Install .NET 6.0 SDK or Desktop Runtime FOR Linux

<em>NOTE : Both below command must be run in order to install  .NET 6.0 SDK</em>

command ( 1 ): 
sudo snap install dotnet-sdk --classic --channel=6.0
command ( 2 ):
sudo snap alias dotnet-sdk.dotnet dotnet

2) Install .NET 6.0 runtime 

<em>NOTE : Both below command must be run in order to Install .NET 6.0 runtime 
</em>

command ( 1 ): 
sudo snap install dotnet-runtime-60 --classic
command ( 2 ):
sudo snap alias dotnet-runtime-60.dotnet dotnet


<em>After this installatio just run below the command to complete the process :- </em>

1)export DOTNET_ROOT=/snap/dotnet-sdk/current

then after if you get TLS/SSL Certificate errors WHILE INSTALLATION THEN ONLY..

Error may looks like  that : [

Processing post-creation actions...
Running 'dotnet restore' on /home/myhome/test/test.csproj...
  Restoring packages for /home/myhome/test/test.csproj...
/snap/dotnet-sdk/27/sdk/2.2.103/NuGet.targets(114,5): error : Unable to load the service index for source https://api.nuget.org/v3/index.json. [/home/myhome/test/test.csproj]
/snap/dotnet-sdk/27/sdk/2.2.103/NuGet.targets(114,5): error :   The SSL connection could not be established, see inner exception. [/home/myhome/test/test.csproj]
/snap/dotnet-sdk/27/sdk/2.2.103/NuGet.targets(114,5): error :   The remote certificate is invalid according to the validation procedure. [/home/myhome/test/test.csproj]


]


 Run below command to resolves the issue :

1)export SSL_CERT_FILE=[path-to-certificate-file]
2)export SSL_CERT_DIR=/dev/null

