# Self Hosting SignalR
Demo of hosting SignalR & receiving SignalR messages using Console Applications

## Getting started
Start both projects, see [How to: Set multiple startup projects](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-set-multiple-startup-projects?view=vs-2019), and wait for both of them to be started:

### Wait for startup of server and client

When the client is ready the console looks like this:

> Client started  
Client connected. Press any key to send a message

When the server is ready the console looks like this:

> Server started  
Server running on http://localhost:9080  
Press any key to send a message to connected clients  
Client connected: d2b4a2fe-0033-4179-9a99-d00b2ac36d21  

### Send messages to other clients and from server

Press a key in the client console to send a message to the server and observe the message being picked up:

> Server started  
Server running on http://localhost:9080  
Press any key to send a message to connected clients  
Client connected: d2b4a2fe-0033-4179-9a99-d00b2ac36d21  
**Server send: Guest - Hello World**

Press a key in the server console to send a message to all connected clients and observe the message being picked up:

> Client started  
Client connected. Press any key to send a message  
dHello World  
Message send. Press any key to exit  
**Hello from server**
