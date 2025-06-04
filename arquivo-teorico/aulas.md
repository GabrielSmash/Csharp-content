# Curso de C#
> Uma linguagem de programão (regras sintáticas)  
> .NET (2002): uma plataforma de desenvolvimento para se criar diversos tipos de aplicações, podendo usar várias linguagens de programação

<div align = center>
    <img src=implementações.png alt="implementações" width="500">
</div>

**Instalação do Visual Studio Community**  
- [Link de Instalação](https://visualstudio.microsoft.com/pt-br/vs/community/)  
- Selecione as Cargas de Trabalho  
    - ASP.NET e Desenvolvimento Web  
    - Desenvolvimento para Azure  
    - Desenvolvimento de .NET Multi-Plataform App UI  
    - Desenvolvimento para desktop com .NET  
    - Desenvolvimento com a Plataforma universal do Windows  
- Pacote de Idiomas  
- Portugues(Brasil)  
- Baixar tudo, depois instalar  
- Instalar  

**Estrutura Básica de um programa C#**
- Estrutura de arquivos
    - Arquivo .sln
    - Arquivo .csproj
    - Classe principal .cs
    - Subpastas obj e bin
- Program.cs
    - Cláusulas using: referências a outros namespaces
    - Namespace
    - Classe
    - Método
    - static void Main(string[] args)
## Introdução a C# e .NET
**Tipos básicos em C#**

>C# é uma linguagem estaticamente tipada  
>Tipos valor pré-definidos em C#  
>Tipos referência pré-definidos em C#  
>Variável não atribuída  
>Overflow  
>Padrão para float: sufixo "f"  
>Padrão para char: aspas simples  
>Padrão para string: aspas duplas  
>Padrão para bool: true, false  
>Opção: inferência de tipos com palavra "var" (dentro de métodos)  

**C# built-in data types (tipos valor)**  
| C# Type | .NET Framework Type | Signed | Bytes | Possible Values                                            |
|--------|----------------------|--------|-------|------------------------------------------------------------|
| sbyte  | System.SByte         | Yes    | 1     | -128 to 127                                                |
| short  | System.Int16         | Yes    | 2     | -32,768 to 32,767                                          |
| int    | System.Int32         | Yes    | 4     | -2³¹ to 2³¹ - 1                                            |
| long   | System.Int64         | Yes    | 8     | -2⁶³ to 2⁶³ - 1                                            |
| byte   | System.Byte          | No     | 1     | 0 to 255                                                   |
| ushort | System.UInt16        | No     | 2     | 0 to 65,535                                                |
| uint   | System.UInt32        | No     | 4     | 0 to 2³² - 1                                               |
| ulong  | System.UInt64        | No     | 8     | 0 to 2⁶⁴ - 1                                               |
| float  | System.Single        | Yes    | 4     | ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸ with ~7 significant figures    |
| double | System.Double        | Yes    | 8     | ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸ with ~15-16 significant figs |
| decimal| System.Decimal       | Yes    | 12    | ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸ with 28-29 significant figs    |
| char   | System.Char          | N/A    | 2     | Any Unicode character                                      |
| bool   | System.Boolean       | N/A    | 1/2   | true or false                                              |

**C# built-in data types (tipos referência)**  
| Tipo C# | Tipo .NET | Descrição |
|---------|-----------|--------------------------------------------|
| string | System.String | Uma cadeia de caracteres Unicode IMUTAVEL (segurança, simplicidade, thread, safe) |
| object | System.Object | Um objeto genérico (toda classe em C# é subclasse de object) GetType, Equals, GetHashCode, ToString |

## Logica usando C#

**Restrições para nomes de variaveis**  
- Não pode começar com dígito: use uma letra ou _    
- Não usar acentos ou til  
- Não pode ter espaço em branco  
- Sugestão: use nomes que tenham um significado 

| Errado | Correto |
|----------|-----------|
| int 5minutos; | int _5minutos; |
| int salário; | int salario; |
| int salario do empregado; | salarioDoFuncionario; |

**Convenções**
- Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)  
- Pascal Case: LastName (namespaces, classe, properties e métodos)  
- Padrão _lastName (atributos "internos" da classe)  

```
namespace Curso
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;
        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
    }
}
```
**Operadores de atribuição**
| *Operador* | *Exemplo* | *Significado* |
|------------|-----------|---------------|
| =          | a = 10;   | a RECEBE 10;  |
| +=         | a += 2;   | a RECEBE +2;  |
| -=         | a -= 2;   | a RECEBE -2;  |
| *=         | a *= 2;   | a RECEBE a * 2 |
| /=         | a /= 2;   | a RECEBE a / 2 |
| %=         | a %= 3;   | a RECEBE a % 3 |

**Operadores Aritméticos**
| *Operador* | *Significado* |
|------------|---------------|
| + | adição |
| - | subtração |
| * | multiplicação |
| / | divisão |
| % | resto da divisão |

*1)* * / % tem precedencia maior que + -  
*2)* Exemplos:  
- 3 + 4 * 2 -> Resultado: 11  
- (3 + 4) * 2 -> Resultado: 14  

*3)* Pode-se usar parateses a vontade  
*4)* Exemplo com mod:  
- 17 % 3 -> Resultado: 2 (resto da divisão)

**Entrada de dados**
> Console.ReadLine();  
- Le da entrada padrão até a quebra de linha.
- Retorna os dados lidos na forma de string.
- Ler um texto até a quebra de linha e armazenar em uma variável.
- Ler três palavras, uma em cada linha, armazenando cada uma em uma variável.
- Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável.







