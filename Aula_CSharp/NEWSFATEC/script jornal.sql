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
				('Campanha irregular faz Palmeiras largar no Brasileirão com pior desempenho desde 2017',
				'Verdão somou apenas seis pontos em 15 disputados até agora no torneio nacional',
				'Esporte','09/05/2022','1',
				'O Palmeiras desperdiçou no último domingo uma oportunidade de confirmar a recuperação no Campeonato Brasileiro e engatar um embalo no torneio. O empate com o Fluminense, no Allianz Parque, frustrou os planos alviverdes e fez o time somar a menor quantidade de pontos nas cinco primeiras rodadas na competição nacional desde 2017.
					Nas últimas dez participações no Brasileirão, o Verdão teve um desempenho inferior ao atual apenas duas vezes (2012 e 2017). Em 2015, os palmeirenses também somaram seis pontos, com uma vitória, três empates e uma derrota.')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('Landim diz que ficou chateado com a saída de Jorge Jesus do Flamengo: "Atrapalhou todo o trabalho"',
				  'Em entrevista ao jornalista Mauro Cezar Pereira, o presidente rubro-negro diz que o treinador não cumpriu sua palavra ao deixar o clube logo depois de renovar contrato, em 2020',
				  'Esporte','09/05/2022','3',
				  'Landim acredita que a atitude de Jorge Jesus atrapalhou todo o planejamento do clube, que precisou voltar ao mercado e na ocasião fez a escolha por Doménec Torrent. Sobre a visita de Jesus ao Brasil, o presidente disse que viu com naturalidade.
					+ Everton Ribeiro mantém confiança em sucesso de Paulo Sousa no Flamengo: "Nos mostra o caminho"
					- Com a maneira que ele saiu, obviamente que sim. Ele tinha se comprometido, não só comigo, mas com todo o grupo (jogadores e comissão técnica) a permanecer aqui até ao menos o final da temporada de 2020. Ao renovar o contrato e depois sair repentinamente, atrapalhou todo o trabalho de preparação para a temporada pós-paralisação pela Covid e a eventual adaptação de um novo técnico que contrataríamos para o lugar dele, se soubéssemos que não iria ficar. ')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('‘Pantanal’: Tibério flagrará Muda com Levi',
				'Peão vai infernizar o juízo dela, que agora também trabalha na fazenda de Zé Leôncio',
				'Novela','10/05/2022','2',
				'Agora que Muda (Bella Campos) se tornou residente fixa do Pantanal e está trabalhando na fazenda de José Leôncio (Marcos Palmeira), ela terá que lidar com os constantes assédios de Levi (Leaondro Lima) que, por sua vez, sabe que a moça é interesse amoroso de Tibério (Guito).
				Enquanto Muda se vira com os afazeres domésticos, será pega de surpresa por Levi. O peão irá a apanhá-la pelas costas e, apesar das tentativas dela de afastá-lo, começará a beijar o cangote dela.
				“Nunca vi uma menina mais bonita (...) e fica ainda mais bonita brava desse jeito”, diz o peão.')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('Saiba o que assistir para entender melhor "Doutor Estranho no Multiverso da Loucura"',
				'No podcast Cena Aberta, Mikannn dá dica para quem deseja assistir ao filme da Marvel no cinema. E mais: a apresentadora, junto com Max Valarezo e PH Santos, debatem se a DC está querendo imitar a MCU',
				'Cinema','03/05/2022','3',
				'Só se fala dele! Antes mesmo de estrear nos cinemas, no dia 5/5, o filme "Doutor Estranho no Multiverso da Loucura" já estava entre os assuntos mais comentados. E não é para menos! Primeiro, porque o lançamento de um filme da Marvel sempre faz muito barulho, depois, porque o longa vem carregado de muitas expectativas, como, por exemplo, de ser um o filme bastante assustador.
					Sem nenhum spoiler, o episódio do podcast Cena Aberta compara a trajetória da Marvel com a da DC e discute: será que a DC quer imitar a sua concorrente nos cinemas? Mas antes de entrar nesse debate, a Mikannn dá uma dica de ouro para quem deseja assistir ao filme do mago na telona.
					"O que acho que ficou mais complexo é que, além e abordar o multiverso, esse é o primeiro filme do universo cinematográfico da Marvel que realmente leva em conta as séries."')


insert into Noticias(titulo ,subtitulo ,assunto,datapublicacao,codautor,texto) values
				('De Pantanal para o Rio de Janeiro: relembre em 1 minuto o romance de Juma e Jove',
				'Primeiro beijo do casal foi em um banho de rio!',
				'Novela','02/05/2022','2',
				'A semana em Pantanal foi marcada, entre tantas coisas, pelo romance de Juma (Alanis Guillen) e Jove (Jesuíta Barbosa). Os dois finalmente se beijaram, e que beijo! Tivemos banhos de rio para lá de sensuais, Juma quase matando José Leôncio (Marcos Palmeira), fuga dos dois para o Rio de Janeiro, mais um banho sensual, agora no chuveiro da mansão dos Novaes, e o trio Madeleine (Karine Teles), Mariana (Selma Egrei) e Irma (Camila Morgado) conhecendo a nossa oncinha.')

select * from Noticias 









