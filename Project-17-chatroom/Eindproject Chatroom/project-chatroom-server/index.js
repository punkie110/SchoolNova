const express = require("express");
const cors = require('cors');

const server = express();
server.use(express.json());
server.use(cors());

const messages = [
  {
    username: "Admin",
    message: "Welkom bij de chatroom.",
  },
];

server.get("/messages", (_, response) => {
  response.status(200);
  response.type("json");

  console.log(`${getTime()} Berichten aangevraagd`);

  response.send(JSON.stringify(messages));
});

server.post("/send", (request, response) => {
  const newMessage = {
    username: request.body.username,
    message: request.body.message,
  };

  messages.push(newMessage);

  console.log(`${getTime()} Bericht ontvangen - ${newMessage.username}: ${newMessage.message}`);

  response.status(200);
  response.send();
});

server.listen(3000, () => {
  console.log('Server gestart op: http://localhost:3000');
});

function getTime() {
  const time = new Date();
  return `[${time.getHours().toString().padStart(2, "0")}:${time.getMinutes().toString().padStart(2, "0")}:${time.getSeconds().toString().padStart(2, "0")}]`;
}