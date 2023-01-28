# Treinando-Reflection

O que é Reflection?

Reflection é uma funcionalidade do C# que permite que você descubra e manipule informações sobre tipos em tempo de execução. Isso inclui informações sobre propriedades, métodos, construtores, atributos, entre outras coisas. Com reflection, você pode descobrir informações sobre tipos que você não conhece no momento da compilação, ou até mesmo mudar o comportamento de um tipo já existente.

Etapas do programa

O programa possui duas funções principais: ListPropertiesAndMethods(object obj) e CreateInstance(Type type).

A função ListPropertiesAndMethods(object obj) recebe como parâmetro um objeto genérico e usa reflexão para listar as propriedades e métodos desse objeto. Ela usa o método GetType() para obter o tipo do objeto e, em seguida, usa os métodos GetProperties() e GetMethods() para obter as propriedades e métodos, respectivamente.

A função CreateInstance(Type type) recebe como parâmetro o tipo de um objeto e usa reflexão para criar uma instância desse objeto. Ela usa o método Activator.CreateInstance(Type) para criar a instância e retorna o objeto criado.

O método Main usa as funções acima para criar uma instância de um objeto MyClass e listar as propriedades e métodos dele. Ele também cria uma instância de outro objeto MyOtherClass usando a função CreateInstance.

A reflexão é uma funcionalidade poderosa, mas deve ser usada com cuidado, pois ela pode afetar o desempenho do aplicativo e a segurança.
