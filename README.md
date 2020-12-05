# mars-moon-visibility
Advanced Software Testing exercise which calculates the visibility of both Mars-moons.


You are on the software development team for the first human mission to Mars. As is well known, a day on Mars does not have 24 hours. Therefore, it has been decided in the project to divide a Mars day into 25 Mars-hours, each further subdivided into 100 Mars-minutes. A Mars-timestamp therefore consists of two integers, e.g. 17:89,which stands for 17 Mars-hours and 89 Mars-minutes.  
Mars has two moons: Deimos and Phobos. Every day, each of them rises and sets at certain points in time. Both points in time are expressed as Mars-timestamps, together forming a Mars-interval. Deimos, for instance, could rise at 4:97 and set at 12:02. That day, Phobos could rise at 24:44 and set at 7:50 the next day. This example of [24:44, 7:50] shows that the first Mars-timestamp in a Marsinterval need not be smaller than the second Mars-timestamp. If the second one is smaller, it is about a point in time the next Mars-day.

For a certain experiment on Mars, you need both Mars-moons to be visible at the same time for as long as possible. It is therefore necessary to have a software function Moon that takes two Marsintervals (one for Deimos, one for Phobos) as input and counts the number of Mars-minutes they overlap. It may be assumed that a moon rises and sets exactly in the middle of a Mars-minute. It may also be assumed that if a certain interval is valid for a Mars-day, it was also valid for the previous Mars-day and will be valid for the following one.  
For instance, D[13:91, 23:05] P[22:05; 24:45] (D = Deimos, P = Phobos) leads to the result 100, because there are 100 Mars minutes from 22:05 to 23:05. Another example: D[24:53, 7:12], P[5:12, 8:45] leads to the result 200, because the intervals overlap for the 200 minutes from 5:12 to 7:12.

There is one extra counting rule - the Twilight Rule:  
If the two intervals have only one point in common (example D[12:32, 17:06] P[17:06, 19:78])  
another example D[22:11, 0:36] P[7:00, 22:11]) then the result is not zero minutes, but one minute.