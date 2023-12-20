<style>
  @import url('https://fonts.googleapis.com/css2?family=Lexend:wght@100;300;400;500;600;700;800;900&family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap');
</style>
Identity Server Deployment
==========================

IdentityServer configuration may be different based on deployment configurations. Basically, you need update identityserver client related data and update your hosting preferences based on your deployment environment.

### Update Cors Origins

Cors origins configuration for **gateways, microservices** swagger authorization and **React** must be updated for deployment. This can be found under **App** configuration in appsettings.json

```json
   "CorsOrigins": "https://*.MyProjectName.com,http://localhost:4200,https://localhost:8080",
```

### Update Redirect Allowed Urls

This configuration must be done if React used as back-office web application. It is found under App configuration in appsettings.json

```json
"RedirectAllowedUrls": "http://localhost:4200,https://localhost:8080"
```
