# Implantação do Servidor de Identidade
IdentityServer configuração podem ser diferentes com base em ⁇  de ⁇ . ⁇ , você precisa ⁇  dados relacionados ao cliente do servidor de identidade e ⁇  suas ⁇  de hospedagem com base em seu ambiente de ⁇ .
### Atualizar origens do Cors
Corps origina configuração para gateways, ⁇  de adaga de microservices e React deve ser ⁇  para ⁇ . Isso pode ser encontrado em App configuração em appsettings.son

       "CorsOrigins": "https://*.MyProjectName.com,http://localhost:4200,https://localhost:44307,https://localhost:44325,https://localhost:44353,https://localhost:44367,https://localhost:44388,https://localhost:44381,https://localhost:44361",

### Atualizar URLs permitidos para redirecionamento
Esta configuração deve ser feita se React usado como aplicativo web de back-office. Ele é encontrado sob App configuração em appsettings.son

    "RedirectAllowedUrls": "http://localhost:4200,https://localhost:44307"

