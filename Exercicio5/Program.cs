﻿/*
Imagine que você está criando um sistema de galeria online. 
Nessa galeria, os usuários podem navegar por diferentes tipos de mídias — como imagens e vídeos. 
Cada tipo de mídia deve ser exibido com uma descrição adequada, contendo informações específicas, como a resolução da imagem ou a duração do vídeo.

Sua missão é:

Criar a classe base Midia com a propriedade Nome e o método virtual ExibirDetalhes().
Criar as classes Imagem (com Resolucao) e Video (com Duracao), sobrescrevendo o método ExibirDetalhes().
Criar uma lista com diferentes mídias e exibir os detalhes de cada uma chamando ExibirDetalhes().
Exemplo de entrada:

List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}
Exemplo de saída:

Imagem: paisagem.jpg - Resolução: 1920x1080  
Vídeo: filme.mp4 - Duração: 120 minutos
*/
using Exercicio5;

List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}
