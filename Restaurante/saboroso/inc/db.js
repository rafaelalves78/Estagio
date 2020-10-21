
const mysql = require('mysql2');


// create the connection to database
const connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    database: 'restaurante',
    password: '123456789',
    multipleStatements: true
  });

  module.exports = connection;