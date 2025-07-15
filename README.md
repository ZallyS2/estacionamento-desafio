# 🚗 Sistema de Estacionamento em .NET

Projeto desenvolvido como parte da trilha de Fundamentos .NET da [DIO](https://www.dio.me/), com aprimoramentos implementados além da proposta inicial.

---

## 📚 Descrição

Este projeto simula um sistema de gerenciamento de estacionamento, permitindo:

- ✅ Cadastrar veículos com placas únicas
- ✅ Remover veículos e calcular o valor a ser pago
- ✅ Listar todos os veículos estacionados
- ✅ Interagir por meio de um menu estilizado em terminal

---

## 🛠️ Funcionalidades

A classe `Estacionamento` foi construída com os seguintes membros:

### 🔢 Variáveis:

- `precoInicial` (_decimal_): Preço base ao estacionar.
- `precoPorHora` (_decimal_): Valor cobrado por hora adicional.
- `veiculos` (_List<string>_): Lista com as placas dos veículos estacionados.

### ⚙️ Métodos:

- `AdicionarVeiculo()`: Solicita a placa do usuário e adiciona à lista, impedindo duplicatas.
- `RemoverVeiculo()`: Solicita a placa e o tempo de permanência, calcula o valor e remove da lista.
- `ListarVeiculos()`: Exibe todos os veículos no estacionamento ou uma mensagem apropriada.

---

## 🧠 Melhorias Aplicadas

- ✅ **Validação de placas duplicadas**: Garante que o mesmo veículo não seja cadastrado duas vezes.
- ✅ **Menu interativo estilizado com bordas**: Interface mais clara e organizada no terminal.
- ✅ **Mensagens de feedback ao usuário**: Informações claras em cada etapa da interação.

---

## 💜 Desafio feito por Zallih

<img align="right" alt="zallih" width="150" src="https://github.com/zallih/Images/blob/main/zally.png?raw=true">
  <a href="https://www.instagram.com/zzappiello.o/"><img src="https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white" /></a>
    <a href="mailto:lailazappiello90@gmail.com"><img src="https://img.shields.io/badge/Gmail-333333?style=for-the-badge&logo=gmail&logoColor=red" /></a>
    <a href="https://wa.me/5511981642627"><img src="https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white" /></a>
    <a href="https://www.linkedin.com/in/laila-zappiello/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a> 

<br><br><br><br>
<br><br><br><br>
<p align="center">
  🌌 <strong>"May the Force be with you."</strong> – Star Wars
</p>
<p align="center">
<img src="https://github.com/zallih/Images/blob/main/Jedi%20grogu%F0%9F%92%9A.jpeg?raw=true" width="250px" />
</p>
