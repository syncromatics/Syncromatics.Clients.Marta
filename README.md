# Metropolitan Atlanta Rapid Transit Authority (MARTA) Api Client 
[![Build Status](https://travis-ci.org/syncromatics/Syncromatics.Clients.Marta.svg?branch=master)](https://travis-ci.org/syncromatics/Syncromatics.Clients.Marta)

A .NET library to interact with the [MARTA API](http://www.itsmarta.com/app-developer-resources.aspx)

## Example usage

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
```
dotnet build
```

## Testing
```
dotnet test
```
