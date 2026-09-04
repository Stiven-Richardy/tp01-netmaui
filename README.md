# 📱 Projeto: Protótipo de Login com .NET MAUI (C# & XAML)

Este projeto acadêmico foi desenvolvido no âmbito da unidade curricular de **Programação de Dispositivos Móveis (CBTPRDM)**, lecionada pelo professor Me. Wellington Tuler Moraes, no Instituto Federal de Educação, Ciência e Tecnologia de São Paulo (IFSP) — Campus Cubatão. O objetivo central é implementar o primeiro aplicativo (TP01) utilizando o framework multiplataforma .NET MAUI, focando na construção de interfaces responsivas e na lógica de code-behind. 

A aplicação materializa os conceitos de *Pages*, *Layouts* (especificamente o uso otimizado do `Grid` e `VerticalStackLayout`) e *Views*, abandonando o aninhamento excessivo de layouts para garantir máxima performance de renderização na thread de UI nativa.

## 🎯 Objetivos

- **Engenharia de Interface (XAML):** Construção de um formulário de login responsivo utilizando `Grid` para alinhamento em tempo constante e `VerticalStackLayout` para agrupamento de botões de ação.
- **Manipulação de Estado (C# Code-Behind):** Validação estrita de credenciais (`admin` e `senha@dmin`) respondendo a eventos de clique (`Clicked`).
- **Experiência do Usuário (UX):** Controle de foco de UI (`.Focus()`) para acionamento nativo de teclado virtual e mascaramento seguro de senhas (`IsPassword="True"`).
- **Integração Nativa:** Utilização do `DisplayAlert` da abstração MAUI para invocar caixas de diálogo modais nativas do sistema operacional subjacente (Android/Windows).

## 🛠️ Ferramentas Utilizadas

- C# 10+ / .NET 6.0+
- XAML (eXtensible Application Markup Language)
- .NET MAUI (Multi-platform App UI)
- Visual Studio 2022 (Workload: .NET Multi-platform App UI development)
- Android Emulator (Hyper-V / HAXM)
- Git & GitHub

## 🗂️ Estrutura do Projeto

```text
📁 TP01/
├── 📁 Platforms/ (Android, iOS, MacCatalyst, Windows)
├── 📁 Resources/ (AppIcon, Fonts, Images, Splash)
├── 📄 App.xaml
├── 📄 App.xaml.cs
├── 📄 AppShell.xaml
├── 📄 AppShell.xaml.cs
├── 📄 MainPage.xaml (Interface e Layout do Formulário)
├── 📄 MainPage.xaml.cs (Lógica de Validação e Eventos)
├── 📄 MauiProgram.cs (Inicialização e Injeção de Dependência)
├── 📄 TP01.csproj
└── 📄 README.md
```

## 🚀 Como Executar

1. **Configuração do Ambiente (Visual Studio):**
   - Clone este repositório para a sua máquina local.
   - Certifique-se de que o **Visual Studio 2022** (v17.3 ou superior) está instalado com o workload **Desenvolvimento de interface do usuário de aplicativo multiplataforma do .NET (.NET MAUI)**.
   - Abra a solução do projeto (`TP01.sln`) ou a pasta raiz na sua IDE.

2. **Iniciando a Aplicação (Android Emulator):**
   - Na barra de ferramentas superior do Visual Studio, localize o menu *dropdown* de *Target* (Destino de Depuração).
   - Selecione **Android Emulators** e escolha o dispositivo configurado (ex: `pixel_3a - api_30`). Caso não tenha um emulador configurado, utilize o *Gerenciador de Dispositivos Android* no menu *Ferramentas* para criar um.
   - Pressione `F5` ou clique em **Iniciar Depuração**. O Visual Studio fará a compilação JIT e o *deploy* da aplicação no emulador.

## 👨‍🏫 Autores

- **Stiven Richardy Silva Rodrigues** Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão  
  [@Stiven-Richardy](https://github.com/Stiven-Richardy)

- **Guilherme Mendes de Sousa** Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão  
  [@Guilh3rme-M3ndes](https://github.com/Guilh3rme-M3ndes)

## 📚 Referências

- Documentação Oficial do .NET MAUI: https://learn.microsoft.com/pt-br/dotnet/maui/
- CBTPRDM (Programação de Dispositivos Móveis) - Material Didático (Aulas 01 a 03)
