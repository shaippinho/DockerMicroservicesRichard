<h1 align="center">DockerMicroservices</h1> 
<h4 align="center"> 🚧 Projeto em construção... 🚧</h4>

<br>
<p>Projeto foi construído para aprendizagem na construção de microsserviços com Docker e na configuração do Docker Compose, está utilizando .NET 8.
Também inseri bibliotecas como Refit para consumo de API e Dapper(ORM).</p>
<br>

<p> 👉 No que se baseia:
<br>
Crud simples no cadastro de produto, API de cadastro de produto pode ser consumida por outra API chamada de APIRefit.</p>
<br>

<p>👉 Serviços configurados no docker compose:
<br>
<br>
1-sqlserver: Microsoft SQL Server, é um sistema gerenciador de Banco de dados relacional, <b>aqui será criado nosso banco para persistência de dados.</b>
<br>
volumes: Cria um volume na pasta ./DockerMicroservices\volumes para que o que foi salvado no BD não se perca.
<br> 
  
2-mssqltools: O Utilitário sqlcmd permite inserir instruções Transact-SQL, procedimentos do sistema e arquivos de script no prompt de comando, no modo SQLCMD.
<b>Será responsável por criar nosso banco de dados (Estoque) quando os containers são criados</b>.
</p>

3- apirefit: API com Refit configurado para consumir a API cadastroproduto.
<br>

4- cadastroproduto: API que irá persistir o e obter dados salvos no banco de dados.
<br>
<br>
<p>👉 Status 💻
<br>
Serviços subiram corretamente, trabalhando na correção do método de ObterProdutos.</p>
<br>

<p>🛠 Tecnologias utilizadas
<br>
As seguintes ferramentas foram usadas na construção do projeto:
<br>
.NET 8
<br>
Refit
<br>
Swagger
<br>
Docker
<br>
Dapper
<br>
</p>

<br>
<p>👉 Baixe o código
Clone este repositório
<br>
$ git clone [https://github.com/richardvepogg/DockerMicroservices.git]
</p>
<br>

<p>🛠 Pré-Requisitos:
<br>
1-Instalar Docker Desktop: ao instalar marque a caixa "Install required Windows components for WSL2".
<br>  
2-Acesse a solução com Visual Studio.</p>
<br>

<p>💻 Passos criação dos containers
<br>  
1-Executar Docker Desktop.
<br>  
2-No depurador (Visual Studio) selecione o docker compose e execute.</p>
<br>  

<p>O servidor (CadastroProduto) inciará na porta:5010 - acesse http://localhost:5010/swagger
<br>  
O servidor (APIRefit) inciará na porta:5000 - acesse http://localhost:5000/swagger</p>
