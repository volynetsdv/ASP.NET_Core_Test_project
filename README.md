# Manufacturer API

The main goal of the task is to build an application that request data from external service, filter it with LINQ and return data to the client.

Data in the application will be information about vehicle manufacturers. To get the information you will need to use external APIs:
1. Get all manufacturers: https://vpic.nhtsa.dot.gov/api/vehicles/getallmanufacturers?format=json.
2. Get detailed information about manufactory
https://vpic.nhtsa.dot.gov/api/vehicles/getmanufacturerdetails/{id}?format=json, where id: number

Task:
1. Make request to external service to get all  manufacturers and find country with largest count of manufacturers. Take first manufacturer for this country.
2. `/api/manufacturer/info` method should return detailed information about manufacturer from topic 1.

> Requirement:
> 1. Use dependency injection
> 2. Do not hardcode url to external service. Use app.settings file or environment variables to configure url. 
