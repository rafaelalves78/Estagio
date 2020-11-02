const user = {
    name: "Rafael",
    transaction: [],
    balance: 0
};

//adicionar transaçao
function createTransaction (transaction){
   //adicionando um novo item no array de transaçao
    user.transaction.push(transaction)

    if (transaction.type === 'credit'){
        user.balance += transaction.value
    }
    else{
        user.balance -= transaction.value
    }
}
function getHigherTransactionByType(type){
  let higherTransaction
  let higherValue= 0

  for(let transaction of user.transaction){
      if(transaction.type === type && transaction.value > higherValue){
       higherValue = transaction.value
       higherTransaction = transaction
      }
    }
  return higherTransaction
}

function getAverageTransactionValue(){
    let sum = 0
    for(let transaction of user.transaction){
        sum+= transaction.value
    }
    return sum / user.transaction.length
}

function getTransactionsCount(){
    let count ={
        credit: 0,
        debit: 0
    }
    for(let transaction of user.transaction){
        if(transaction.type === 'credit')
            count.credit++
        else count.debit++
    }
    return count
}

createTransaction({ type: 'credit', value: 50 })
createTransaction({ type: 'credit', value: 120 })
createTransaction({ type: 'debit', value: 80 })
createTransaction({ type: 'debit', value: 30 })

console.log(user.balance)
console.log(getHigherTransactionByType('credit')) // { type: 'credit', value: 120 }
console.log(getHigherTransactionByType('debit')) // { type: 'debit', value: 80 }

console.log(getAverageTransactionValue()) // 70

console.log(getTransactionsCount()) // { credit: 2, debit: 2 }
