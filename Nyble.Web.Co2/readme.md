### **Task**

Create and endpoint that calculates CO2 emissions for travel between two airports. The endpoint should take in two IATA codes and return the origin and destination airport objects + the co2 emissions. The endpoint should optionally take in a flight class - if no flight class specified then fallback on the default class (see the ITravelClassService)

The airport data is in the Data/airports.json file.

**The CO2 formula is as per below:**  
1. Calculate distance between airports (use haversine formula - either nuget package or manual implementation - both accepted) 
2. If both origin and destination are GB, use domestic emissions for the travel class if available
3. If origin is Europe and destination is GB or origin is GB destination is Europe, use short haul emissions for the travel class if available
4. If origin or destination is GB, use long haul emissions for the travel class if available
5. Otherwise use international emissions
6. Total CO2 = emissions for travel class & origin-distance haul * 2 * distance in KM

**Bonus points for:**
1. Following all REST guidelines
2. Using dependency injection
3. Plugging in swagger (do not forget proper action annotations)
4. Proper handling of exceptions
5. Clean and easy to understand code. The logic needs to be easy to follow. It's better if easy to follow without any comments, but comments are accepted
6. Unit tests (one unit test is enough - any library is accepted)

**Not important for this exercise:**
1. Logging
2. Authentication
3. Number of decimal points (i.e. do not worry about rounding)