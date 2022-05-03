# MS-TEST

### Projeto destinado a execução de testes utilizando C#, .NET e MSTest

### 👨‍💻 Autores: Álvaro Alvim, Arilson, João Carlos, Luis Gustavo

![CI](https://github.com/alvarolopes2021/ms-test/actions/workflows/dotnet.yml/badge.svg)

______

### 💻 Techs
 * [.NET 6](https://dotnet.microsoft.com/en-us/)
 * [Git](https://git-scm.com/)
 * [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/)

---

### ▶ Executando o projeto


###  Passo a Passo para criar um Projeto de teste C# por linha de comando

* Criando a solução:

		dotnet new sln -n nome-do-projeto

* Criando o projeto da classe:

    	dotnet new classlib -n NomeDaClasse

* Adicionando a referência do projeto na solução:

    	dotnet sln nome-do-projeto.sln add NomeDaClasse/NomeDaClasse.csproj

* Criando o projeto de teste da classe:

  	  dotnet new mstest -n NomeDaClasse.Tests

* Adicionando o projeto de teste na solução: 

  	  dotnet sln nome-do-projeto.sln add NomeDaClasse.Tests/NomeDaClasse.Tests.csproj

* Referenciando o projeto NomeDaClasse a ele:

		dotnet add NomeDaClasse.Tests/NomeDaClasse.Tests.csproj reference NomeDaClasse/NomeDaClasse.csproj


* Executando os testes

		dotnet test

 > Com os comandos acima eles criam a classe a ser testada e classe de teste que vai ser utilizada,
Também com este passo a passo ele irá criar os arquivos .csproj que salvam as configurações de 
projeto e referências dos arquivos usados no programa no formato MSBuild, que pode ser compilado
em programa executável usando MSBuild


### Abrindo o projeto pelo Visual Studio 2022

 * Clone o repositório 
 
		git clone https://github.com/alvarolopes2021/ms-test.git 

	ou

		git clone git@github.com:alvarolopes2021/ms-test.git	 

 * Abra a solução em seu Visual Studio 2022 
	 > O Visual Studio de versões anteriores não suporta o .NET na versão 6 (versão utilizada no projeto)
	 
	 >A solução encontra-se no diretório **TestProject1**
	 
 * Com a solução aberta, caso o VS 2022 não instale as dependências, realize as instalações
 

 > Com tudo pronto, basta clicar com o botão direito no projeto de testes e acionar a execução dos testes por meio da função "Executar Testes" ou "Run Tests"
