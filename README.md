# Syncromatics.Clients.Marta

This is a .NET library to interact with the MARTA API for getting transit arrival information in Atlanta.

## Quickstart

A .NET library to interact with the [MARTA API](http://www.itsmarta.com/app-developer-resources.aspx)

### Retrieving rail arrivals

```c#
MartaApiClient client = new MartaApiClient(new ClientSettings("http://developer.itsmarta.com", "fake-api-key"));
IList<TrainArrival> arrivals = await client.GetRealTimeTrainArrivalsAsync();
string myStation = "SANDY SPRINGS STATION";
var stationArrivals = arrivals.Where(arrival => myStation.Equals(arrival.Station, StringComparison.InvariantCultureIgnoreCase));
string nextArrival = stationArrivals.FirstOrDefault()?.WaitingTime ?? "unknown";
Console.WriteLine($"{myStation} {nextArrival}"); //SANDY SPRINGS STATION 9 min
```

## Building

[![Travis](https://img.shields.io/travis/syncromatics/Syncromatics.Clients.Marta.svg)](https://travis-ci.org/syncromatics/Syncromatics.Clients.Marta)
[![NuGet](https://img.shields.io/nuget/v/Syncromatics.Clients.Marta.Api.svg)](https://www.nuget.org/packages/Syncromatics.Clients.Marta.Api/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Syncromatics.Clients.Marta.Api.svg)](https://www.nuget.org/packages/Syncromatics.Clients.Marta.Api/)

This library is built using [.NET Core](https://www.microsoft.com/net/download). To build:

```
dotnet build
```

To run the tests:

```
dotnet test
```

## Code of Conduct

We are committed to fostering an open and welcoming environment. Please read our [code of conduct](CODE_OF_CONDUCT.md) before participating in or contributing to this project.

## Contributing

We welcome contributions and collaboration on this project. Please read our [contributor's guide](CONTRIBUTING.md) to understand how best to work with us.

## License and Authors

[![GMV Syncromatics Engineering logo](https://secure.gravatar.com/avatar/645145afc5c0bc24ba24c3d86228ad39?size=16) GMV Syncromatics Engineering](https://github.com/syncromatics)

[![license](https://img.shields.io/github/license/syncromatics/Syncromatics.Clients.Marta.svg)](https://github.com/syncromatics/Syncromatics.Clients.Marta/blob/master/LICENSE)
[![GitHub contributors](https://img.shields.io/github/contributors/syncromatics/Syncromatics.Clients.Marta.svg)](https://github.com/syncromatics/Syncromatics.Clients.Marta/graphs/contributors)

This software is made available by GMV Syncromatics Engineering under the MIT license.
