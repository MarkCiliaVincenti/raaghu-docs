<style>
  @import url('https://fonts.googleapis.com/css2?family=Lexend:wght@100;300;400;500;600;700;800;900&family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap');
</style>
# Módulo de gerenciamento de idiomas
Este módulo implementa o sistema de gerenciamento de linguagem de uma aplicação;

- Gerenciar línguas no sistema.
- Traduzir textos no UI.
- Ativar/desativar idiomas.
- Selecione o idioma padrão na IU.

Consulte a [página de descrição do módulo](https://commercial.abp.io/modules/Volo.LanguageManagement "") para obter uma visão geral dos recursos do módulo.

## Interface de usuário
### itens de menu
O módulo de gerenciamento de idiomas adiciona os seguintes itens ao menu "Principal", no item de menu "Administração":

- **Idiomas**: Página de gerenciamento de idiomas.
- **Texto de Idioma**: Página de gerenciamento de texto de idioma.

LanguageManagementMenuNames classe tem as constantes para os nomes dos itens do menu.
### páginas
Idiomas

A página de idiomas é usada para gerenciar línguas no sistema.

![Nova língua](./images/language.png "")

Você pode criar um novo idioma ou editar um idioma existente nesta página:

![Criar nova língua](./images/language-new.png "") ![Edit Language](./images/language-edit.png "")

- As línguas **habilitadas** podem ser selecionados adas como a linguagem do sistema.**

### textos de línguas
A página de textos linguísticos é usada para gerenciar textos em diferentes línguas.

![Textos de língua](./images/langauge-text.png "")

Você pode traduzir um texto para um idioma ou editar a tradução já existente nesta página.

![editar a tradução já existente nesta página](./images/language-text-edit.png "")
