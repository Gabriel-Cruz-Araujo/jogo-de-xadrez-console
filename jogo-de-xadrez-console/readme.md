# Console Chess Game

Um jogo de xadrez desenvolvido em C# no **Visual Studio** que roda no console. Este projeto implementa todas as regras do xadrez, incluindo jogadas especiais como roque, promoção de peões e captura *en passant*, além de verificar situações de xeque e xeque-mate.

## ✨ Funcionalidades

- Suporte completo às regras oficiais do xadrez.
- Jogadas especiais:
  - **Roque** (pequeno e grande).
  - **Promoção de peão** (com escolha da peça para promoção).
  - **Captura en passant**.
- Detecção de **xeque** e **xeque-mate**.
- Interface simplificada no console para acompanhar as partidas.

## 🚀 Tecnologias utilizadas

- **C#**
- Ambiente de desenvolvimento: **Visual Studio**

## 📂 Estrutura do projeto

```
📆ConsoleChessGame
 ├ 🗂tabuleiro
 ┃ ├ 📋Cor.cs               # Difinindo a cor das peças.
 ┃ ├ 📋Peca.cs              # Definição da lógica das peças.
 ┃ ├ 📋Posicao.cs           # Definição da Lógica das posições.	
 ┃ ├ 📋Tabuleiro.cs         # Imprimindo a matriz do tabuleiro (8x8).
 ┃ └ 📋TabuleiroExceptio.cs # Exceções personalizadas para o Tabuleiro.
 ├ 🗂xadrez
 ┃ ├ 📋Bispo.cs             # Lógica do Bispo com as jogadas especiais
 ┃ ├ 📋Cavalo.cs            # Lógica do Cavalo.
 ┃ ├ 📋Dama.cs              # Lógica da Dama. 
 ┃ ├ 📋PartidaDeXadrez.cs   # Lógica da partida de xadrez.
 ┃ ├ 📋PosicaoXadrez.cs     # Lógica das posioes no tabuleiro de xadrez.
 ┃ ├ 📋Rei.cs               # Lógica do Rei com as jogadas especias                               
 ┃ └ 📋Torre.cs			    # Lógica da Torre.
 ├ Program.cs				# Ponto de entrada do programa.
 ├ Tela.cs					# Lógica do que será exibido no console.
 └ 📋README.md           
```

## 🕹️ Como executar no Visual Studio

1. **Pré-requisitos**:  
   Certifique-se de ter o **Visual Studio** instalado com o **.NET Desktop Development** configurado.  
   Você pode baixar o Visual Studio [aqui](https://visualstudio.microsoft.com/).

2. Clone o repositório:
   ```bash
   git clone https://github.com/Gabriel-Cruz-Araujo/jogo-de-xadrez-console.git
   ```

3. Abra o projeto no Visual Studio:  
   - Clique em **File > Open > Project/Solution** e selecione o arquivo `.sln` do projeto.

4. Compile e execute:  
   - Pressione **F5** para compilar e executar o jogo diretamente no console do Visual Studio.

5. Siga as instruções exibidas no console para iniciar uma partida de xadrez.

## 🎯 Próximos passos (Ideias de melhorias)

- Adicionar suporte a partidas contra uma **IA básica**.
- Implementar salvamento e carregamento de partidas.
- Melhorar a interface no console, exibindo o tabuleiro de forma mais visual.
- Criar uma interface gráfica com **WinForms** ou **WPF**.

## 📜 Licença

Este projeto está licenciado sob a licença [MIT](LICENSE).

## 🖋️ Autor

Desenvolvido por **[Seu Nome]**.  
Conecte-se comigo no [LinkedIn](https://www.linkedin.com/in/gabriel-cruz-711273292) ou entre em contato pelo email: gabrielcaraujo.tech@gmail.com.
