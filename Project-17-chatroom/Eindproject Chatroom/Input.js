
const serverAddress = "http://localhost:3000";

getMessages();

setInterval(getMessages, 1000);

function getMessages() {
    fetch(serverAddress + "/messages", { method: "GET" })
        .then((response) => response.json())
        .then((json) => {
            const OutputChat = document.querySelector("#BerichtenContainer");
            OutputChat.innerHTML = "";
            json.forEach((item) => {
                const berichtElement = document.createElement("div");
                berichtElement.classList = "bg-primary px-2 py-1 my-3 w-auto rounded";
                berichtElement.innerHTML = `<span class="username">${item.username}</span><br /><span class="message">${item.message}</span>`;
                OutputChat.appendChild(berichtElement);
            });
        })
        .catch((err) => {
            OutputChat.innerText = err.message;
        })
}

function sendCommand() {
    bericht = { username: document.querySelector("#Name").value, message: document.querySelector("#Message").value };
    fetch(serverAddress + "/send", { method: "POST", headers: { "content-type": "application/json" }, body: JSON.stringify(bericht) })
        .then(() => {
            getMessages();
        });
}