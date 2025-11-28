Aqui está um **README.md** completo, organizado e profissional para o seu desafio:

---

# Desafios em C# – Console App

Aplicação criada para resolver três desafios propostos: **Comissão de Vendas**, **Movimentação de Estoque** e **Cálculo de Juros por Atraso**.
Todo o projeto foi estruturado em um único arquivo `Program.cs` (para propósito de desafio), com leitura de arquivos JSON externos.

---

## 📌 **Funcionalidades**

### **1️⃣ Comissão de Vendas**

- Lê um arquivo `vendas.json`
- Calcula comissão por vendedor:

  - Vendas ≥ 500 → **5%**
  - Vendas ≥ 100 → **1%**
  - Abaixo disso → **0%**

- Exibe a comissão total por vendedor.

### **2️⃣ Movimentação de Estoque**

- Lê um arquivo `estoque.json`
- Permite procurar produto pelo código
- Registra movimentação:

  - Entrada (quantidade positiva)
  - Saída (quantidade negativa)

- Atualiza o estoque e mostra o novo valor final
- Gera um ID aleatório para a movimentação

### **3️⃣ Cálculo de Juros**

- Recebe:

  - Valor
  - Data de vencimento

- Se houver atraso:

  - Calcula dias de atraso
  - Aplica multa:
    **2,5% ao dia** (`valor * 0.025 * dias`)

- Exibe:

  - Dias atrasados
  - Multa total
  - Valor final

---

## **Arquivos Necessários**

Certifique-se de que os arquivos JSON estejam na mesma pasta que o executável ou o projeto:

### **vendas.json**

```json
{
  "vendas": [
    { "vendedor": "Maria", "valor": 600 },
    { "vendedor": "João", "valor": 200 },
    { "vendedor": "Pedro", "valor": 50 }
  ]
}
```

### **estoque.json**

```json
{
  "estoque": [
    { "codigoProduto": 1, "descricaoProduto": "Teclado", "estoque": 20 },
    { "codigoProduto": 2, "descricaoProduto": "Mouse", "estoque": 35 }
  ]
}
```

---

## ▶️ **Como Executar o Projeto**

1. Entre no diretório do projeto:

```bash
cd /caminho/para/seu/projeto
```

2. Execute:

```bash
dotnet run
```

3. O menu será exibido no terminal:

```
===== MENU DE DESAFIOS =====
1 - Comissão de Vendas
2 - Movimentação de Estoque
3 - Cálculo de Juros
0 - Sair
```

---

## **Estrutura Interna**

O projeto contém:

- Classes de modelo (Venda, Produto, Movimentação…)
- Leitura e desserialização de JSON
- Menu interativo
- Três desafios independentes
- Controle do fluxo com loops e `switch`

Tudo em um único arquivo para atender aos requisitos do desafio.

---

## **Tecnologias Utilizadas**

- **C# 9 / .NET 9**
- **System.Text.Json** para leitura JSON
- Aplicação **Console**

---

## 🧠 **Autor**

Desenvolvido por **Riquelmy Ferreira** como solução para um desafio prático.
