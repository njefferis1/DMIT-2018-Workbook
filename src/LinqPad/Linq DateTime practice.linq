<Query Kind="Statements" />

DateTime.DaysInMonth(2020, 2).Dump("Days in Feb, 2020");
DateTime today = DateTime.Today;
var fiveDayslater = today.AddDays(5);
fiveDayslater.Dump();
var delay = new TimeSpan(48, 15, 22);
delay.Dump();
today.Add(delay).Dump();
today.ToString("MMM dd yyyy").Dump();