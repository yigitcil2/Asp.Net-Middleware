📚 ASP.NET Core Middleware - Overview
This project demonstrates the use of middleware in ASP.NET Core, which enables the configuration of a request-processing pipeline for handling HTTP requests and responses.

🧱 What is Middleware?
Middleware are software components that sit between the client and server, intercepting and processing requests and responses. Each request flows through a series of middleware, with each component performing a specific task such as logging, authentication, or routing.

Think of middleware as relay runners—each does its part and passes the baton to the next.

🚀 Middleware Pipeline Flow
Request Received: A client (e.g., browser) sends an HTTP request.

Logging: Middleware logs request details like URL, timestamp, and user info.

Authentication: Verifies if the user is logged in.

Authorization: Checks if the user has the right permissions.

Routing & Application Logic: The request is mapped to the proper controller and action.

Response Sent: A response is generated and sent back to the client.

This pipeline provides both flexibility and security, allowing developers to fully control how requests are handled.

🧰 Built-in Middleware Components Used
Middleware	Description
UseExceptionHandler	Handles errors gracefully, showing a user-friendly error page in production.
UseDeveloperExceptionPage	Displays detailed error info during development for debugging purposes.
UseAuthentication()	Verifies the identity of the user before allowing access to protected routes.
UseAuthorization()	Enforces access policies after authentication is completed.
UseRouting()	Maps incoming HTTP requests to the correct endpoints (controllers/actions).
UseHttpLogging()	Logs HTTP request/response information for debugging and monitoring.

✍️ Custom Middleware
The project also includes an example of a custom middleware that logs each incoming request’s path and timestamp. This shows how you can create middleware tailored to your own application’s needs.

✅ Benefits of Middleware
Enhanced security via authentication and authorization.

Improved debugging through structured logging and error handling.

