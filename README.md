Aqui está o **README.md** revisado, organizado e atualizado **incluindo as instruções corretas após remover `bin/` e `obj/`** e deixando ele pronto para o seu repositório GitHub.

Se quiser, posso também já commitar ele direto no padrão do GitHub.

---

# 🧩 Desafios em C# – Console Application

Aplicação de console criada para resolver três desafios práticos envolvendo:
**cálculo de comissão de vendas**, **movimentação de estoque** e **cálculo de juros por atraso**.

Todo o código foi desenvolvido em **C# (.NET)**, utilizando leitura de dados via JSON externo para manter a estrutura organizada.

---

## Funcionalidades

### **1️⃣ Comissão de Vendas**

* Lê o arquivo `vendas.json`
* Calcula comissão por venda:

  * **≥ R$ 500** → 5%
  * **≥ R$ 100** → 1%
  * **< R$ 100** → sem comissão
* Soma o total por vendedor
* Exibe o relatório final

---

### **2️⃣ Movimentação de Estoque**

* Lê o arquivo `estoque.json`
* Solicita:

  * Código do produto
  * Descrição da movimentação
  * Quantidade (positiva = entrada / negativa = saída)
* Gera um ID aleatório para a movimentação
* Atualiza o estoque e mostra o novo valor final

---

### **3️⃣ Cálculo de Juros por Atraso**

* Solicita:

  * Valor original
  * Data de vencimento
* Calcula atraso baseado na data atual
* Aplica multa:

  * **2,5% ao dia**
* Exibe:

  * Dias em atraso
  * Multa total
  * Valor final atualizado

---

## Arquivos Necessários

Esses arquivos **devem estar na raiz do projeto**:

### vendas.json

```json
{
  "vendas": [
    { "vendedor": "João Silva", "valor": 1200.50 }
  ]
}
```

### estoque.json

```json
{
  "estoque": [
    { "codigoProduto": 101, "descricaoProduto": "Caneta Azul", "estoque": 150 }
  ]
}
```

---

# Como Executar o Projeto

Após clonar o repositório:

```bash
git clone https://github.com/Quelmy/Desafio-Comissao-de-Vendas.git
cd Desafio-Comissao-de-Vendas
```

### **1. Restaure o projeto**

```bash
dotnet restore
```

### **2. Execute**

```bash
dotnet run
```

O menu aparecerá assim:

```
===== MENU DE DESAFIOS =====
1 - Comissão de Vendas
2 - Movimentação de Estoque
3 - Cálculo de Juros
0 - Sair
```

---

# Estrutura do Projeto

```
/Desafio-Comissao-de-Vendas
│
├── Program.cs
├── vendas.json
├── estoque.json
├── README.md
└── .gitignore
```

---

#  Tecnologias Utilizadas

* **C# / .NET**
* **System.Text.Json**
* Console Application

---

# 👤 Autor

Projeto desenvolvido por **Riquelmy Ferreira** como desafio prático de programação em C#.

---
