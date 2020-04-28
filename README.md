# Dime.Maps

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/Maps%20-%20MAIN%20-%20CI?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=95&branchName=master) [![Dime.Maps package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimenicsbe/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/0236d6de-7ac3-4a7d-8270-48e9c1d66c8e/Badge)](https://dev.azure.com/dimenicsbe/Utilities/_packaging?_a=package&feed=a7b896fd-9cd8-4291-afe1-f223483d87f0&package=0236d6de-7ac3-4a7d-8270-48e9c1d66c8e&preferRelease=true) [![Dime.Maps package in Dime.Scheduler feed in Azure Artifacts](https://feeds.dev.azure.com/dimenicsbe/_apis/public/Packaging/Feeds/a7b896fd-9cd8-4291-afe1-f223483d87f0/Packages/0236d6de-7ac3-4a7d-8270-48e9c1d66c8e/Badge)](https://dev.azure.com/dimenicsbe/Utilities/_packaging?_a=package&feed=a7b896fd-9cd8-4291-afe1-f223483d87f0&package=0236d6de-7ac3-4a7d-8270-48e9c1d66c8e&preferRelease=true)

## Introduction

This is a project that supports the map functionalities in Dime.Scheduler. Most notably, the geocoding service is essential to the performance of the map as it eliminates the need for ad-hoc geocoding.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

The Dime.Maps project holds the contracts whereas Dime.Maps.Ptv is an implementation of the geocoding service using PTV XLocate.

## Installation

Use the package manager NuGet to install Dime.Maps and Dime.Maps.Ptv:

```cli
dotnet add package Dime.Maps
dotnet add package Dime.Maps.Ptv
```

## Usage

``` csharp
using Dime.Maps;

PtvGeocoder api = new PtvGeocoder(_url, _user, _token);
GeoCoordinate? address =  await api.GeocodeAsync("Schaliënhoevedreef", "20T", "2800", "Mechelen", "", "BE");
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)