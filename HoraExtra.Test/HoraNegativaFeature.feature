#language: pt-br


Funcionalidade: Update Hora Mensal funcionario caso ele se atrase

Cenário: Quantidade de horas negativas 8
		Dado que estou consumindo o metodo AtualizaHorasColaborador
		E preencho o campo quantidade com 8
		Quando executo a aplicacao
		Entao  o retorno  '152'
