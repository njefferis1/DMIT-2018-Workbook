<Query Kind="Expression">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Lookup the category names, in alphabetical order
from row in Categories
orderby row.CategoryName // descending // uncomment for reverse alphabetical order
select row.CategoryName