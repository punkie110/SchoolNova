const express = require("express");
const cors = require('cors');

const server = express();
server.use(express.json());
server.use(cors());

const secretMessage = "Geheim bericht";

server.get("/test", (_, response) => {
  console.log("GET Request op /test eindpunt");
  response.status(200);

  const message = "Opdracht 4 Server Online";

  response.send(JSON.stringify({message}));
  console.log(`Response: ${JSON.stringify({message})}`);
});

server.post("/command", (request, response) => {
  console.log("POST Request op /command eindpunt: " + JSON.stringify(request.body));

  response.status(200);
  response.type("json");

  let message;

  switch (request.body.command.toLowerCase()) {
    case "ping":
      message = "pong";
      break;

    case "time":
      const time = new Date();
      message = time.getHours() + ":" + time.getMinutes();
      break;

    case "secret":
      message = secretMessage;
      break;

    default:
      message = "Commando niet herkend";
      break;
  }

  response.send(JSON.stringify({ message }));
  console.log(`Response: ${JSON.stringify({ message })}`);
});

server.listen(3000, () => {
  console.log("Server gestart op: http://localhost:3000");
});
