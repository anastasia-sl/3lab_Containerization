FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build

WORKDIR /app

COPY lab4.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o outf

FROM mcr.microsoft.com/dotnet/runtime:6.0-alpine
WORKDIR /app
COPY --from=build /app/outf .

ENTRYPOINT [ "dotnet", "outf/lab4.dll" ]
