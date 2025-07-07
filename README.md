# 📘 Explicativo da Classe `Calculadora` em C#

## 📂 Namespace e Estrutura

- **Namespace:** `OperadoresAritmeticos.Models`
- **Classe:** `Calculadora`
- **Objetivo:** Implementar operações matemáticas básicas e funções trigonométricas.

---

## 🔢 Operações Aritméticas Básicas

### ➕ `Somar(int x, int y)`
- Realiza a soma de dois inteiros.
- Exibe o resultado no formato: `x + y = resultado`.

### ➖ `Subtrair(int x, int y)`
- Realiza a subtração de dois inteiros.
- Exibe o resultado no formato: `x - y = resultado`.

### ✖️ `Multplicar(int x, int y)`
- Realiza a multiplicação de dois inteiros.
- Exibe o resultado no formato: `x X y = resultado`.

### ➗ `Dividir(int x, int y)`
- Realiza a divisão inteira de dois números.
- Exibe o resultado no formato: `x / y = resultado`.
- ⚠️ Não trata divisão por zero — pode lançar exceção se `y == 0`.

---

## 🧮 Operações Matemáticas Avançadas

### 🧠 `Potencia(int x, int y)`
- Calcula `x` elevado à potência `y` usando `Math.Pow`.
- Exibe o resultado no formato: `x^y = resultado`.

### 🧮 `RaizQuadrada(double x)`
- Calcula a raiz quadrada de `x` usando `Math.Sqrt`.
- Exibe o resultado no formato: `Raiz Quadrada de x = resultado`.

---

## 📐 Funções Trigonométricas

> Todas as funções convertem o ângulo de graus para radianos antes do cálculo.

### 🔺 `Seno(double angulo)`
- Calcula o seno do ângulo.
- Usa `Math.Sin` e arredonda para 4 casas decimais.

### 🔻 `Coseno(double angulo)`
- Calcula o cosseno do ângulo.
- Usa `Math.Cos` e arredonda para 4 casas decimais.

### 🔸 `Tangente(double angulo)`
- Calcula a tangente do ângulo.
- Usa `Math.Tan` e arredonda para 4 casas decimais.

---

## ✅ Considerações Finais

- A classe é voltada para exibição direta no console (`Console.WriteLine`).
- Não retorna valores — ideal para aprendizado ou demonstrações simples.
- Pode ser expandida com tratamento de erros, retorno de valores e testes unitários.

---

# 📘 Explicativo do Projeto em C# — Calculadora Aritmética e Trigonométrica

## 📁 Estrutura Geral

- **Namespace:** `OperadoresAritmeticos.Models`
- **Classe Principal:** `Calculadora`
- **Arquivo de Execução:** `Program.cs` (console application)
- **Objetivo:** Demonstrar o uso de operações matemáticas básicas, funções trigonométricas e manipulação de variáveis.

---

## 🧮 Parte 1 — Classe `Calculadora`

### 🔹 Localização
```csharp
namespace OperadoresAritmeticos.Models
```

### 🔹 Métodos Implementados

#### ➕ Operações Aritméticas
- `Somar(int x, int y)`
- `Subtrair(int x, int y)`
- `Multplicar(int x, int y)`
- `Dividir(int x, int y)`

#### 🧠 Operações Matemáticas
- `Potencia(int x, int y)`
- `RaizQuadrada(double x)`

#### 📐 Funções Trigonométricas
- `Seno(double angulo)`
- `Coseno(double angulo)`
- `Tangente(double angulo)`

### 🔹 Observações
- Todos os métodos imprimem diretamente no console.
- Não há retorno de valores.
- Não há tratamento de exceções (ex: divisão por zero).

---

## ▶️ Parte 2 — Programa de Execução (`Program.cs`)

### 🔹 Instanciação da Calculadora
```csharp
Calculadora calc = new Calculadora();
```

### 🔹 Chamadas de Métodos

#### ✅ Operações Aritméticas
```csharp
calc.Somar(10, 30);         // 10 + 30 = 40
calc.Subtrair(10, 50);      // 10 - 50 = -40
calc.Multplicar(15, 45);    // 15 * 45 = 675
calc.Dividir(2, 2);         // 2 / 2 = 1
```

#### ✅ Potenciação
```csharp
calc.Potencia(3, 3);        // 3^3 = 27
```

#### ✅ Funções Trigonométricas
```csharp
calc.Seno(30);              // Seno de 30° ≈ 0.5
calc.Coseno(30);            // Coseno de 30° ≈ 0.866
calc.Tangente(30);          // Tangente de 30° ≈ 0.577
```

#### ✅ Raiz Quadrada
```csharp
calc.RaizQuadrada(9);       // √9 = 3
```

---

## 🔄 Parte 3 — Incremento e Decremento de Variáveis

### 🔹 Incremento
```csharp
int numeroIncremento = 10;
numeroIncremento++;         // Incrementa para 11
```

### 🔹 Decremento
```csharp
int numeroDecremento = 10;
numeroDecremento--;         // Decrementa para 9
```

### 🔹 Saída no Console
- Mostra o valor antes e depois do incremento/decremento.
- Demonstra o uso de operadores `++` e `--`.

---

## 📝 Considerações Finais

- O projeto é ideal para iniciantes em C# que desejam aprender:
  - Criação de classes e métodos
  - Uso de bibliotecas matemáticas (`System.Math`)
  - Manipulação de variáveis
  - Impressão no console
- Pode ser expandido com:
  - Retorno de valores ao invés de `Console.WriteLine`
  - Interface gráfica (ex: WinForms ou WPF)
  - Validações e tratamento de exceções

---
