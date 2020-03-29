# GraphQL-test-in-.net-core-3.1
- https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core
- https://github.com/mmacneil/ASPNetCoreGraphQL
- https://www.codemag.com/Article/1909061/Intro-to-GraphQL-for-.NET-Developers-Schema-Resolver-and-Query-Language
- https://www.red-gate.com/simple-talk/dotnet/net-development/getting-started-with-graphql-in-asp-net/
- https://code-maze.com/graphql-aspnetcore-basics/

### Currently I got the setup of startup.cs behaving and the below basic query running

by running IIS Express the endpoint to run queries is: https://localhost:44320/ui/playground

```
query{
   carbrands
  {
    name 
    securityRate
  }
}
```

expected:
```
{
  "data": {
    "carbrands": [
      {
        "name": "Ford",
        "securityRate": 4
      },
      {
        "name": "Fiat",
        "securityRate": 3
      }
    ]
  }
}
```

### work in progress. Next step is to make nested queries work