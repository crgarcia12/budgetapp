# budgetapp

# Frontend:
Created with `npm init uifabric`

Add a component

`npx generate-react-cli component ExpensesList`
## Start:
npm start

# Backend

## Entity Framework
from the project root:

```
dotnet ef migrations add InitialCreate --project BudgetApp
dotnet ef database update --project BudgetApp
```