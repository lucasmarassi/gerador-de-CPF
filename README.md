# Gerador de CPF em C#

Este é um projeto em C# que gera CPFs válidos usando o cálculo dos dígitos verificadores.

O programa percorre números de 000000000 até 999999999, calcula os dois dígitos verificadores do CPF e imprime o resultado formatado no console.

O funcionamento é baseado na regra oficial do CPF:
- O primeiro dígito é calculado a partir dos 9 primeiros números com pesos de 10 a 2.
- O segundo dígito é calculado usando os 9 números + o primeiro dígito, com pesos de 11 a 2.
- Em ambos os casos, usa-se o módulo 11 para definir o dígito.

No final, o CPF é formatado no padrão `000.000.000-00` e exibido no console.

Este projeto tem fins educacionais, ajudando a entender loops, operações matemáticas e manipulação de strings em C#.
