# File Analysis Servise

## Description
This Server imitates virus scanning of a file and calculates SHA1 of this file.
The server gets a URL of a file that you want to scan. 
Program execution steps:
- Client sends a URL
- The server validates a URL
- The server checks if file size less than 200 MB
- File is downloaded from URL
- The server calculates SHA1 of file
- The server try to find the scan result of this file in memory cache
- If it finds result in memory, the server returns this result and SHA1 to client
- If it cannot find result in memory, the server sends request to [virus-scanning-backend](https://github.com/ValeraPo/VirusScanning)
- The server saves result in memory cache
- The server returns this result and SHA1 to client

## Stack
The server is implemented on C#, .Net 6.0.
The server sends request to virus scanning backend by RestSharp.
The server downloads file from URL by WebRequest.

## Requirements
You need to have Microsoft VisualStudio 2022 or other IDE for C# to launch this Server. 
You should launch this server together with [virus-scanning-backend](https://github.com/ValeraPo/VirusScanning).
This servers use ports 7216 and 7030. Please check that these ports are free.
