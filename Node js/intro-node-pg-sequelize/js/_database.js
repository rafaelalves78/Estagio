const pg = require('pg')

const client = new pg.Client({
  user: 'postgres',
  host: 'localhost',
  database: 'postgres',
  password: '123456789',
  port: 5432,
})

module.exports = client
