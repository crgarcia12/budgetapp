import React, { useState } from 'react';
import { TextField } from '@fluentui/react/lib/TextField';
import { PrimaryButton } from '@fluentui/react/lib/Button';

class Guid {
  static newGuid() {
    return 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
      var r = Math.random() * 16 | 0,
        v = c == 'x' ? r : (r & 0x3 | 0x8);
      return v.toString(16);
    });
  }
}

interface Expense { 
  id: string
  shop: string;
  description: String;
  amount: number;
};

const initState:Expense = { 
  id: "",
  shop: "",
  description: "",
  amount: 0
}; 

const ExpensesList: React.FC = () => {
  const [expenseState, onChangeText] = React.useState(initState);

  return (
      <div>
        <TextField label="Shop" value={expenseState.shop} onChange={(event, value) => {
          if(value != undefined) {          
            onChangeText({
              id: expenseState.id,
              shop : value,
              description: expenseState.description,
              amount: expenseState.amount
            });
          }
        }}/>
        <PrimaryButton text="Save" onClick={() => addExpenseAsync(expenseState)}/>
      </div>
  );
}

function addExpenseAsync (newExpense: Expense) {
  newExpense.id = Guid.newGuid();
  alert(JSON.stringify(newExpense));
  const url = 'https://localhost:5001/api/Expense'
  const requestOptions = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(newExpense)
  }

  fetch(url, requestOptions).then((res) => alert(res));
}



export default ExpensesList;
