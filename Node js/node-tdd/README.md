# node-tdd
Exemplo de desenvolvimento de API em Node.js usando TDD

## Instalar dependências
```
npm install
```

## Criar container para o banco MongoDB com Docker
Execute o arquivo para gerar o container:

```
./runDocker.sh
```

## Executando os testes
Para executar os testes unitários, use o comando:
```
mpm run test:unit
```

Para executar os testes de integração, use o comando:
```
mpm run test:integration
```

