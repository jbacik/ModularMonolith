# ModularMonolith
A modular monolith example done in .Net

## Projects
_ModMonBooks.Web_ - The host application (main entry point) that will configure and maintain all the modules
_ModMonBooks.Books.Api_ - The Books module backend

TODO
_ModMonBooks.Books.UI_ - The Books module frontend
_ModMonBooks.Users.Api_ - The Users module backend
_ModMonBooks.Users.UI_ - The Users module frontend

_ModMonBooks.Web_ - As a shell

## Things this has
- [FastEndpoints](https://github.com/FastEndpoints/FastEndpoints) - A library that nudges you towards the REPR pattern and keeps 1 endpoint to a single file.


## Things I did a little differently
- I added an Integration test project to verify my endpoints without running the `.http` file or pinging the application through Postman
