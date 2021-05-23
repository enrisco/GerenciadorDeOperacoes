# GerenciadorDeOperacoes
Solução para teste de programação da Havan ProWay.

///////////////////////////////////////////////

Para a compilação deste programa via Visual Studio, 
basta abrir o arquivo .sln em 
\GerenciadorDeOperacoes\projGerenciadorDeOperacoes.

Para executá-lo, necessita-se ter um sistema windows. 
Seguindo o requisito à cima, basta ir em 
\GerenciadorDeOperacoes\v1.0.0 e executar Gerenciador
de Operações.exe. 

O programa constiste em um gerenciador das operações de 
uma casa de câmbio, cujo necessita de um banco de dados
para cadastro de cliente. Neste caso, foi usado a 
linguagem C# utilizando o framework Windows.Forms para
compilar o app para desktop baseado em Windows. Também 
foi usado Linq to XML para o banco de dados.   

Logo quando se abre, mostra-se a tela de cadastro de 
cliente. Se o usuário tentar cadastrar um cliente
antes de cadastrar algum câmbio, o sistema impedirá,
assim como se estiver faltando alguma informação no 
formulário. Sabendo disso, o usuário deve ir até o menu
lateral e navegar até "Adicionar Moeda".

Abrindo a tela de cadastro de câmbio, o usuário deverá
cadastrar o nome da moeda e seu equivalente ao real, que
será usado como base, e assim, clicar em "Salvar".
Após cadastrar todas as moedas necessárias, o usuário deverá
navegar novamente até "Cadastrar Cliente", agora podendo 
cadastrar com base nas moedas cadastradas anteriormente.

Nesta ala, temos os campos prioritários para o cadastro
do cliente, o usuário poderá escolher manualmente a data
do cadastro se preferir. Após os dados serem preenchidos,
o cálculo da conversão e da taxa são feitos automaticamente,
mostrando no rodapé do programa, podendo assim, clicar em 
"Salvar".

Após cadastrar todos os clientes, o usuário poderá navegar até
"Ver Relátorios", podendo ver todos os dados salvos e a soma das
operações e das taxas cobradas.


