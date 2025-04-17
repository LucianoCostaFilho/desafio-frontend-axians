### Passos para executar o projeto:
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git

2. cd SeuProjeto.Blazor
dotnet run


# 🧾 Desafio Axians - Sistema de Avisos

Este projeto é uma aplicação Blazor responsiva desenvolvida para o desafio técnico da **Axians**, com foco na criação e gerenciamento de *avisos com taxas por localidade*. A interface foi construída respeitando o design fornecido (via Figma), com atenção especial a detalhes visuais, experiência do usuário e responsividade mobile.

---

## 📌 Visão geral

A aplicação permite:
- Criar avisos com múltiplas opções.
- Definir o tipo de taxa e se ela será contada ou não.
- Adicionar taxas específicas por localidade (NUTS II, NUTS III, Concelho).
- Controlar visualmente o progresso de preenchimento e publicação.
- Navegar entre os avisos com um sistema de sidebar dinâmico.
- Realizar todas as interações com uma UI totalmente responsiva (desktop, tablet e mobile).

---

## 🧱 Estrutura e Desenvolvimento

O projeto foi construído com foco em componentes reutilizáveis e organizados, como:

- `Sidebar`: controla as etapas dos avisos com ícones visuais de progresso.
- `FormActions`: contém as ações principais (guardar, validar, publicar) com adaptação para telas menores.
- `TaxForm`: manipula a definição da taxa e a flag de contagem.
- `TaxTable`: permite visualizar, adicionar e remover taxas de forma paginada e intuitiva.

### ⚙️ Responsividade

Todos os componentes foram cuidadosamente ajustados com `flex-wrap`, `gap`, `media queries` e `Bootstrap classes` para garantir boa experiência desde monitores grandes até celulares pequenos.

---

## 🚀 Como rodar o projeto localmente

### Pré-requisitos:
- .NET SDK 9.0
- Visual Studio 2022+ ou Visual Studio Code
- (Opcional) Git instalado para clonar o repositório

🧪 Fluxo de trabalho com Git
Durante o desenvolvimento, utilizo normalmente a estratégia GitFlow, com as seguintes branches:

dev → ambiente de desenvolvimento

hml → ambiente de homologação/testes

main → produção

🛠️ Observação importante:
Devido ao prazo curto e ao fato de ser um projeto individual para desafio técnico, optei por fazer o deploy diretamente na main, priorizando agilidade na entrega.