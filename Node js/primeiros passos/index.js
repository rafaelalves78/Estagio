const express = require('express');
const boodyParser = require('body-parser')

const userRoute = require('./routes/userRoute')

const app = express();
const port = 3000;

app.use(boodyParser.urlencoded({extended: false}))


userRoute(app)

app.get('/', (req, res) => res.send('Ola mundo pelo express'))

app.listen(port, () => console.log('Api rodando na porta 3000'))
