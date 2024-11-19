const serverAddress = "http://localhost:3000";

fetch(serverAddress + "/test", {method: "GET"})
.then((response) => response.json())
.then((json) => {
document.querySelector("#serverStatus").innerText = json.message;
})
.catch((err) =>{
    document.querySelector("#serverStatus").innerText = err.message;
})

function sendCommand()
{
    const command = document.querySelector("#inputCommand").value;
    const request = {command: command}

fetch(serverAddress + "/command", {
method: "POST",
headers: {"Content-Type": "application/json"},
body: JSON.stringify(request),

})
.then((response) => response.json())
.then((json) => {
document.querySelector("#Paragraph").innerText = json.message;
})
}