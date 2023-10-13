# Módulo cms kit pro
Este ⁇  estende-se[open-source MS Kit module](https://docs.abp.io/en/abp/latest/Modules/Cms-Kit/Index "")e adiciona ⁇  adicionais de MS (Content Management System) à sua ⁇ .

As seguintes características são ⁇  pelo ⁇  de código aberto MS Kit:

- Sistema de registro para ⁇  postagens de blog de publicação com suporte de blog múltiplo.
- Sistema de marcação para marcar qualquer tipo de recurso, como um post do blog.
- Sistema de comentários para ⁇  comentários ⁇  a qualquer tipo de recurso, como o post do blog ou uma página de revisão do produto.
- Sistema de reação para ⁇  ⁇  (smiles) a qualquer tipo de recurso, como um post de blog ou um comentário.
- Sistema de classificação para ⁇  ⁇  de classificação a qualquer tipo de recurso.
- Sistema de menu para gerenciar menus ⁇  dinamicamente
- Sistema de recursos ⁇  para ⁇  estilos e scripts ⁇  dinamicamente.
- Sistema de widget dinâmico para ⁇  widgets dinâmicos para posts de página e blog.

E as seguintes características são ⁇  pela versão pro do MS Kit:

- Sistema informativo para ⁇  que os usuários assinem boletins informativos.
- Contate o sistema de formulário para ⁇  que os usuários ⁇ vam mensagens para você.
- URL sistema de encaminhamento para ⁇  URLs que redirecionam para outras páginas ou sites externos.
- Sistema Poll para ⁇  urnas ⁇ idas para usuários

Clique em um recurso para ⁇  e aprender como ⁇ -lo. Ver[a página da ⁇  do ⁇](https://commercial.abp.io/modules/Volo.CmsKit.Pro "")para uma visão geral dos recursos do ⁇ .
## ⁇  ⁇
Se você ⁇  ⁇  o kit MS à sua ⁇  existente, você pode usar o comando BP LI add-module:

     abp add-module Volo.CmsKit.Pro

Abra a classe GlobalFeatureConfigurator no Domain.Shared projeto e ⁇  o seguinte código para o método Configure para habilitar todos os recursos abertos e comerciais no ⁇  MS Kit.

      GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =&gt;
                        {
                        cmsKit.EnableAll();});
                        GlobalFeatureManager.Instance.Modules.CmsKitPro(cmsKitPro =&gt;
                        {
                            cmsKitPro.EnableAll();
                        });

Alternativamente, você pode habilitar recursos individualmente, como cmsKit.Comments.Enable();

Se você estiver usando Entity Framework Core, não se ⁇  de ⁇  uma nova ⁇  e ⁇  seu banco de dados.
