<style>
  @import url('https://fonts.googleapis.com/css2?family=Lexend:wght@100;300;400;500;600;700;800;900&family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap');
</style>
## personalização
### gerenciar abas da página do perfil
Em Minha conta, ao clicar no menu suspenso do perfil de administrador do host, você obtém 4 guias como Imagem do perfil, Alterar senha, Informações pessoais e Dois fatores

As guias na página de gerenciamento de perfil podem ser gerenciadas por meio do ManageProfileTabsService, que é exposto pelo pacote @volo/abp.ng.account/public/config. Você pode adicionar, remover ou editar uma guia usando este serviço.

![Página de perfil de ⁇](./images/my-account.png "")
