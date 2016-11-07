location
http://nevan.net/2014/09/core-location-manager-changes-in-ios-8/


Info.plist
NSLocationWhenInUseUsageDescription
NSLocationAlwaysUsageDescription

[self.locationManager requestWhenInUseAuthorization]
[self.locationManager requestAlwaysAuthorization]

authorize check code


CLLocationManagerDelegate
CLLocationManager
GeoCoder

한번만 호출 manager.requestLocation()
didChangeAuthorizationStatus
func locationManager(_ manager: CLLocationManager, didFailWithError error: Error) {



