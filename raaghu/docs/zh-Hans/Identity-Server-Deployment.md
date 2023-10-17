Identity Server Deployment
==========================

IdentityServer configuration may be different based on deployment configurations. Basically, you need update identityserver client related data and update your hosting preferences based on your deployment environment.

### Update Cors Origins

Cors origins configuration for **gateways, microservices** swagger authorization and **React** must be updated for deployment. This can be found under **App** configuration in appsettings.json

```json
   "CorsOrigins": "https://*.MyProjectName.com,http://localhost:4200,https://localhost:44307,https://localhost:44325,https://localhost:44353,https://localhost:44367,https://localhost:44388,https://localhost:44381,https://localhost:44361",
```

### Update Redirect Allowed Urls

This configuration must be done if React used as back-office web application. It is found under App configuration in appsettings.json

```json
"RedirectAllowedUrls": "http://localhost:4200,https://localhost:44307"
```
