from modelos.restaurante import Restaurante
from modelos.cardapio.bebida import Bebida
from modelos.cardapio.prato import Prato
from modelos.cardapio.sobremesa import Sobremesa

restaurante_praca = Restaurante('praça', 'Gourmet')
bebida_suco = Bebida ('Suco de Melancia', 5.0, 'Grande')
bebida_suco.desconto()
prato_pao = Prato ('Paozinho', 2.0, 'O melhor')
prato_pao.desconto()
sobremesa = Sobremesa ('Torta Suíça', 10.0, 'Torta')
sobremesa.desconto()
restaurante_praca.adicionar_item(bebida_suco)
restaurante_praca.adicionar_item(prato_pao)
restaurante_praca.adicionar_item(sobremesa)

def main():
    restaurante_praca.exibir_cardapio

if __name__ == '__main__':
    main()