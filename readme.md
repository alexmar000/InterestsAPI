Lägga in nya länkar för en specifik person och ett specifikt intresse:
POST: https://localhost:44300/api/interests/updatewebsite/{interestPK}
{
    "Title": "Fakesida",
    "Url": "www.hittepa.se"
}

Koppla en person till ett nytt intresse:
POST: https://localhost:44300/api/interests/{userId?}
{
    "Name": "Ridning"
}

Hämta alla länkar som är kopplade till en specifik person:
GET: https://localhost:44300/api/websites/{userId}

Hämta alla intressen som är kopplade till en specifik person:
GET: https://localhost:44300/api/interests/{userId} 

Hämta alla personer i systemet:
GET: https://localhost:44300/api/users

