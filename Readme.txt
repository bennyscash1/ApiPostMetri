In order to rin the api test
Navigate to tests.runsettings and make sure it on qa
The solution run on Xunit + http client so make sure you install it via Nuget.

The original question include the next steps:

Use the resource ‘https://pokeapi.co/api/v2/type’ and verify that the Pokémon type API is
returning a response with type JSON and that there are exactly 20 different Pokémon
types.
2. Find out the ID of the "Fire type" and validate that:
a. The Pokémon "charmander" is in the JSON of the Fire Pokémon list.
b. The Pokémon "bulbasaur" is not in the JSON of the Fire Pokémon list.
3. Identify the five heaviest Pokémon of the Fire type and ensure they have the expected
weights:
● 'charizard-gmax': 'weight': 10000,
● 'cinderace-gmax': 'weight': 10000,
● 'coalossal-gmax': 'weight': 10000,
● 'centiskorch-gmax': 'weight': 10000,
● 'groudon-primal': 'weight': 9997
...


but the api diffrent data (attachd next)
So in my test ApiHttpClientGetTest i've check if the text "fighting"
is in the resoult and some other text not in


{
    "count": 20,
    "next": null,
    "previous": null,
    "results": [
        {
            "name": "normal",
            "url": "https://pokeapi.co/api/v2/type/1/"
        },
        {
            "name": "fighting",
            "url": "https://pokeapi.co/api/v2/type/2/"
        },
        {
            "name": "flying",
            "url": "https://pokeapi.co/api/v2/type/3/"
        },
        {
            "name": "poison",
            "url": "https://pokeapi.co/api/v2/type/4/"
        },
        {
            "name": "ground",
            "url": "https://pokeapi.co/api/v2/type/5/"
        },
        {
            "name": "rock",
            "url": "https://pokeapi.co/api/v2/type/6/"
        },
        {
            "name": "bug",
            "url": "https://pokeapi.co/api/v2/type/7/"
        },
        {
            "name": "ghost",
            "url": "https://pokeapi.co/api/v2/type/8/"
        },
        {
            "name": "steel",
            "url": "https://pokeapi.co/api/v2/type/9/"
        },
        {
            "name": "fire",
            "url": "https://pokeapi.co/api/v2/type/10/"
        },
        {
            "name": "water",
            "url": "https://pokeapi.co/api/v2/type/11/"
        },
        {
            "name": "grass",
            "url": "https://pokeapi.co/api/v2/type/12/"
        },
        {
            "name": "electric",
            "url": "https://pokeapi.co/api/v2/type/13/"
        },
        {
            "name": "psychic",
            "url": "https://pokeapi.co/api/v2/type/14/"
        },
        {
            "name": "ice",
            "url": "https://pokeapi.co/api/v2/type/15/"
        },
        {
            "name": "dragon",
            "url": "https://pokeapi.co/api/v2/type/16/"
        },
        {
            "name": "dark",
            "url": "https://pokeapi.co/api/v2/type/17/"
        },
        {
            "name": "fairy",
            "url": "https://pokeapi.co/api/v2/type/18/"
        },
        {
            "name": "unknown",
            "url": "https://pokeapi.co/api/v2/type/10001/"
        },
        {
            "name": "shadow",
            "url": "https://pokeapi.co/api/v2/type/10002/"
        }
    ]
}
