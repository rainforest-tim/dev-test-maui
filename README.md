GeoDraw will be a Pictionary style game that aims to get people out and about. One player will be assigned a random object to draw for the other player to guess. To draw, they will walk around, plotting their geolocated co-ordinates on a canvas.

The resulting dot to dot drawing should be displayed to the player. When they press the Send Drawing button, it will be sent to the guessing player via API, and their job will be to type what they think the other person was supposed to be drawing.

This repo contains a skeleton .NET MAUI application for Android. 

We would like you to:

- Do a code review on the MockObjectSelectionService. You can write your comments as code comments above the line they refer to
- Fix the loading of the random object so it appropriately handles the asynchronous call
- Implement a multilingual IObjectSelectionService that supports English and one other language of your choice
- Add the functionality of plotting geo co-ordinates on and displaying the canvas 
- Implement the API connection so that when the user presses "Send Drawing", the resulting image is sent to our imagined API as Base64, which we have provided an example request for below. You can generate a new `gameId` for each call
- After submitting their drawing display a "waiting" image

Out of scope:
You do not need to implement the backend of the API or the guessing player's functionality. There is no need to use any Map features.

Please do not spend more than 2-3 hours on your solution - it is up to you how you spread your time across the tasks.

To submit your solution, do not submit any PRs, instead invite us to view your own private repository.

```
curl --request POST \
  --url https://geodrawpictionary.io/api/draw \
  --header 'authorization: Basic dGVzdDp0ZXN0' \
  --header 'content-type: application/json' \
  --data '{
  "gameId": "16105718-8e7b-4a5d-a3b2-a011a75ae1e0",
  "image": "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQEAkACQAAD..."
}'
```