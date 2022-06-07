## Desafio KeyWorks

### Instruções: 

#### Visual Studio
##### - Ao baixar o projeto, abra o arquivo com a extensão .sln
##### - Automaticamente ele abrirá o Visual Studio (caso tenha instalado)
##### - Clique no botão de "executar" no centro do painel de ferramentas ou pressione a tecla F5. 

#### Vs Code
##### - Abra a pasta do projeto com o VS Code 
##### - Abra o terminal de comando 
##### - Certifique-se de está dentro da pasta TarefaWorks.API e digite: dotnet watch run ou dotnet run e pressione enter para executar o projeto. 

### Lembrete:
##### - Certifique-se de trocar a connectionString no arquivo appsettings.json pela connectionString com as informações do seu banco local.

##### - Com a connectionString modificada, execute as migrações para criar as tabelas no banco e inserir os dados necessários.
##### - Abra o terminal de comando e digite Add-Migration InitialCreate caso utilize o Visual Studio ou digite dotnet ef migrations add InitialCreate caso utilize o VS Code.
##### - Em seguida digite Update-Database para o Visual Studio ou Update-Database para o VS Code. 



