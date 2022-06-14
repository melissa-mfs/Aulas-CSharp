create database jornal
go
use jornal
go
Create table autores(
	codautor  int identity(1,1) primary key,
	autor  varchar(50) not null,
	bairro varchar(30) not null,
	cidade varchar(50) not null,
	usuario varchar(10) not null,	
	senha varchar(10) not null 
)
go
insert into autores 
     (autor,bairro,cidade,usuario,senha)
     values  ('Ana Maria','Fenix','SBC','ana','123')
insert into autores 
     (autor,bairro,cidade,usuario,senha)
     values  ('Eva Lidia','Gerty','SCS','eva','123')
insert into autores 
     (autor,bairro,cidade,usuario,senha)
     values  ('Rui Silva','Jorda','SBC','rui','123')



select * from autores

go
Create table Noticias(
	codnoticia  int identity(1,1) primary key,
	titulo  varchar(300) not null,
	subtitulo varchar(300) not null,
	assunto varchar(50) not null,
	texto text not null,	
	datapublicacao datetime not null,
	codautor  int not null
)

go

insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('Campanha irregular faz Palmeiras largar no Brasileir�o com pior desempenho desde 2017',
				'Verd�o somou apenas seis pontos em 15 disputados at� agora no torneio nacional',
				'Esporte','09/05/2022','1',
				'O Palmeiras desperdi�ou no �ltimo domingo uma oportunidade de confirmar a recupera��o no Campeonato Brasileiro e engatar um embalo no torneio. O empate com o Fluminense, no Allianz Parque, frustrou os planos alviverdes e fez o time somar a menor quantidade de pontos nas cinco primeiras rodadas na competi��o nacional desde 2017.
					Nas �ltimas dez participa��es no Brasileir�o, o Verd�o teve um desempenho inferior ao atual apenas duas vezes (2012 e 2017). Em 2015, os palmeirenses tamb�m somaram seis pontos, com uma vit�ria, tr�s empates e uma derrota.')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('Landim diz que ficou chateado com a sa�da de Jorge Jesus do Flamengo: "Atrapalhou todo o trabalho"',
				  'Em entrevista ao jornalista Mauro Cezar Pereira, o presidente rubro-negro diz que o treinador n�o cumpriu sua palavra ao deixar o clube logo depois de renovar contrato, em 2020',
				  'Esporte','09/05/2022','3',
				  'Landim acredita que a atitude de Jorge Jesus atrapalhou todo o planejamento do clube, que precisou voltar ao mercado e na ocasi�o fez a escolha por Dom�nec Torrent. Sobre a visita de Jesus ao Brasil, o presidente disse que viu com naturalidade.
					+ Everton Ribeiro mant�m confian�a em sucesso de Paulo Sousa no Flamengo: "Nos mostra o caminho"
					- Com a maneira que ele saiu, obviamente que sim. Ele tinha se comprometido, n�o s� comigo, mas com todo o grupo (jogadores e comiss�o t�cnica) a permanecer aqui at� ao menos o final da temporada de 2020. Ao renovar o contrato e depois sair repentinamente, atrapalhou todo o trabalho de prepara��o para a temporada p�s-paralisa��o pela Covid e a eventual adapta��o de um novo t�cnico que contratar�amos para o lugar dele, se soub�ssemos que n�o iria ficar. ')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('�Pantanal�: Tib�rio flagrar� Muda com Levi',
				'Pe�o vai infernizar o ju�zo dela, que agora tamb�m trabalha na fazenda de Z� Le�ncio',
				'Novela','10/05/2022','2',
				'Agora que Muda (Bella Campos) se tornou residente fixa do Pantanal e est� trabalhando na fazenda de Jos� Le�ncio (Marcos Palmeira), ela ter� que lidar com os constantes ass�dios de Levi (Leaondro Lima) que, por sua vez, sabe que a mo�a � interesse amoroso de Tib�rio (Guito).
				Enquanto Muda se vira com os afazeres dom�sticos, ser� pega de surpresa por Levi. O pe�o ir� a apanh�-la pelas costas e, apesar das tentativas dela de afast�-lo, come�ar� a beijar o cangote dela.
				�Nunca vi uma menina mais bonita (...) e fica ainda mais bonita brava desse jeito�, diz o pe�o.')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('Saiba o que assistir para entender melhor "Doutor Estranho no Multiverso da Loucura"',
				'No podcast Cena Aberta, Mikannn d� dica para quem deseja assistir ao filme da Marvel no cinema. E mais: a apresentadora, junto com Max Valarezo e PH Santos, debatem se a DC est� querendo imitar a MCU',
				'Cinema','03/05/2022','3',
				'S� se fala dele! Antes mesmo de estrear nos cinemas, no dia 5/5, o filme "Doutor Estranho no Multiverso da Loucura" j� estava entre os assuntos mais comentados. E n�o � para menos! Primeiro, porque o lan�amento de um filme da Marvel sempre faz muito barulho, depois, porque o longa vem carregado de muitas expectativas, como, por exemplo, de ser um o filme bastante assustador.
					Sem nenhum spoiler, o epis�dio do podcast Cena Aberta compara a trajet�ria da Marvel com a da DC e discute: ser� que a DC quer imitar a sua concorrente nos cinemas? Mas antes de entrar nesse debate, a Mikannn d� uma dica de ouro para quem deseja assistir ao filme do mago na telona.
					"O que acho que ficou mais complexo � que, al�m e abordar o multiverso, esse � o primeiro filme do universo cinematogr�fico da Marvel que realmente leva em conta as s�ries."')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('De Pantanal para o Rio de Janeiro: relembre em 1 minuto o romance de Juma e Jove',
				'Primeiro beijo do casal foi em um banho de rio!',
				'Novela','02/05/2022','2',
				'A semana em Pantanal foi marcada, entre tantas coisas, pelo romance de Juma (Alanis Guillen) e Jove (Jesu�ta Barbosa). Os dois finalmente se beijaram, e que beijo! Tivemos banhos de rio para l� de sensuais, Juma quase matando Jos� Le�ncio (Marcos Palmeira), fuga dos dois para o Rio de Janeiro, mais um banho sensual, agora no chuveiro da mans�o dos Novaes, e o trio Madeleine (Karine Teles), Mariana (Selma Egrei) e Irma (Camila Morgado) conhecendo a nossa oncinha.')

select * from Noticias 









