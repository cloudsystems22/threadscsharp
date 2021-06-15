# threadscsharp

## Threads
>Thread é uma forma de um processo dividir a si mesmo em duas ou mais tarefas, podendo executar elas concorrentemente. O suporte a threads é oferecido pelos Sistemas Operacionais, ou por bibliotecas de algumas linguagens de programação

> A idéa proncipal é que possamos utilizar processo paralelos sem que a aplicação principal precise parar para executar outra tarefa.

### Função de saque em thread
> Nosso método irá descontar R$ 100,00 de um total de R$ 1000,00 e vamos simular um tempo de atraso de 100 à 1000 milisegundos

> Depois iremos adicionar o método Lock que irá organizar os processamentos de nossas threads, evitando que elas acessem nossa memória de forma concorrente.