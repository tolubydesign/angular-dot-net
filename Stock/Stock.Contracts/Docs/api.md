# Stocks API

- [Stock API](#buber-stock-api)
  - [Create Stock](#create-stock)
    - [Create Stock Request](#create-stock-request)
    - [Create Stock Response](#create-stock-response)
  - [Get Stock](#get-stock)
    - [Get Stock Request](#get-stock-request)
    - [Get stock Response](#get-stock-response)
  - [Update Stock](#update-stock)
    - [Update Stock Request](#update-stock-request)
    - [Update Stock Response](#update-stock-response)
  - [Delete Stock](#delete-stock)
    - [Delete Stock Request](#delete-stock-request)
    - [Delete Stock Response](#delete-stock-response)

## Create Stock

### Create Stock Request

```js
POST /stocks;
```

```json
{
  "id": 1,
  "stock": "Nuveen Select Tax Free Income Portfolio II",
  "industry": "n/a",
  "sector": "n/a",
  "currency_code": "PHP"
}
// {
//     "name": "Vegan Sunshine",
//     "description": "Vegan everything! Join us for a healthy breakfast..",
//     "startDateTime": "2022-04-08T08:00:00",
//     "endDateTime": "2022-04-08T11:00:00",
//     "savory": [
//         "Oatmeal",
//         "Avocado Toast",
//         "Omelette",
//         "Salad"
//     ],
//     "Sweet": [
//         "Cookie"
//     ]
// }
```

### Create Stock Response

```js
201 Created
```

```yml
Location: {{host}}/Stocks/{{id}}
```

```json
{
    "id": 1,
    "stock":"Nuveen Select Tax Free Income Portfolio II",
    "industry":"n/a",
    "sector":"n/a",
    "currency_code":"PHP"
}
// {
//   "id": "00000000-0000-0000-0000-000000000000",
//   "name": "Vegan Sunshine",
//   "description": "Vegan everything! Join us for a healthy breakfast..",
//   "startDateTime": "2022-04-08T08:00:00",
//   "endDateTime": "2022-04-08T11:00:00",
//   "lastModifiedDateTime": "2022-04-06T12:00:00",
//   "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
//   "Sweet": ["Cookie"]
// }
```
---

## Get Stock

### Get Stock Request

```js
GET /stocks/{{id}}
```

### Get Stock Response

```js
200 Ok
```

```json
{
    "id": 1,
    "stock":"Nuveen Select Tax Free Income Portfolio II",
    "industry":"n/a",
    "sector":"n/a",
    "currency_code":"PHP"
}
// {
//   "id": "00000000-0000-0000-0000-000000000000",
//   "name": "Vegan Sunshine",
//   "description": "Vegan everything! Join us for a healthy breakfast..",
//   "startDateTime": "2022-04-08T08:00:00",
//   "endDateTime": "2022-04-08T11:00:00",
//   "lastModifiedDateTime": "2022-04-06T12:00:00",
//   "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
//   "Sweet": ["Cookie"]
// }
```

## Update Stock

### Update Stock Request

```js
PUT /stocks/{{id}}
```

```json
{
    "stock":"Nuveen Select Tax Free Income Portfolio II",
    "industry":"n/a",
    "sector":"n/a",
    "currency_code":"PHP"
}
// {
//   "name": "Vegan Sunshine",
//   "description": "Vegan everything! Join us for a healthy breakfast..",
//   "startDateTime": "2022-04-08T08:00:00",
//   "endDateTime": "2022-04-08T11:00:00",
//   "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
//   "Sweet": ["Cookie"]
// }
```

### Update Stock Response (Upsort)

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Breakfasts/{{id}}
```

## Delete Stock

### Delete Stock Request

```js
DELETE /stock/{{id}}
```

### Delete Breakfast Response

```js
204 No Content
```
