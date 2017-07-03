module Expense

type Currency = 
    {
        Name : string
        ratio: decimal
    }

type Expense = 
    {
        Id : int
        Amount : decimal
        Currency : string
    }