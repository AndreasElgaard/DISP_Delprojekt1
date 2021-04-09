# Microservices with Docker and Kubernetes 

This is a frontend, backend and database solution using microservices and docker containers. 

This project was implemented to get familiar with docker containers and how to deploy them to a kubernetes cluster. 

The project API is implemented using an ASP.NET.CORE API and razor pages for the frontend part. The database is a Microsoft SQL Database. These three was implemented to work independently. 

The project consisted of three deployment models:  

1. First the the database, API and the frontend project was tested seperately (API was tested with Postman). 

2. Then the database, API and frontend project was containerized in docker containers, and deployed locally using docker compose. 

3. Then all three containers was deployed to a kubernetes clusted where .yaml scrips was created for the deployments and the services. 
