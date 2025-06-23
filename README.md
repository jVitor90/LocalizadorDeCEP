
## Localizador de CEP

Este projeto permite consultar informações de endereços a partir de um CEP, utilizando a API ViaCEP. A aplicação possui uma interface simples, onde o usuário insere um CEP e recebe informações sobre o endereço correspondente. Foi criado no Windows Forms desenvolvida em C# durante o curso Técnico em Desenvolvimento de Sistemas, em Pindamonhangaba.



## Funcionalidades

A aplicação realiza a busca de informações de endereço a partir de um CEP válido, utilizando a API ViaCEP para obter os dados em formato JSON. Os dados retornados são exibidos em um campo na interface, sendo estes CEP, logradouro, complemento, unidade, bairro, localidade, UF, estado, região e DDD. A aplicação valida o CEP inserido, exibindo mensagens de erro caso o CEP seja inválido(menos de 8 dígitosou não encontrado). 



## Estrutura do Código

A interface da aplicação é composta por um formulário Windows Forms contendo um MaskedTextBox (TxtbCEP) para entrada do CEP, um Button (BtnBuscar) para iniciar a consulta, um GroupBox (GrbResultado) para organizar os resultados e 10 Labels para exibir as informações (CEP, logradouro, complemento, unidade, bairro, localidade, UF, estado, região e DDD). O código utiliza a classe WebClient para realizar a requisição HTTP à API ViaCEP e a biblioteca Newtonsoft.Json para desserializar o JSON retornado em um objeto da classe Endereco. A classe Endereco contém propriedades mapeadas para os campos retornados pela API, utilizando atributos JsonProperty para corresponder aos nomes dos campos no JSON.


![LocalizadorDeCEP](LocalizadorDeCEP/imagem/imagem.png)

