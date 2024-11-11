function alterarStatus(id){
    let game = document.getElementById(`game-${id}`);
    let imagem = game.querySelector('.dashboard__item__img');
    let botao = game.querySelector('.dashboard__item__button');
    let nome = game.querySelector('.dashboard__item__name');
    
    if (imagem.classList.contains('dashboard__item__img--rented')){
        if(confirm(`Você deseja devolver o ${nome}?`))
        imagem.classList.remove('dashboard__item__img--rented');
        botao.classList.remove('dashboard__item__button--return');
        botao.textContent = 'Disponível';
    } else {
        if(confirm(`Você deseja alugar o ${nome}?`))
        imagem.classList.add('dashboard__item__img--rented');
        botao.textContent = 'Devolver';
        botao.classList.add('dashboard__item__button--return');
    }
}