'use strict';
let accounts = [
    { 'client_name': 'Igor', 'account_number': 11234543, 'balance': 203004099.2 },
    { 'client_name': 'Vladimir', 'account_number': 43546731, 'balance': 5204100071.23 },
    { 'client_name': 'Sergei', 'account_number': 23456311, 'balance': 1353600.0 }
];

// Create function that returns the name and balance of cash on an account in a list
function getNameAndBalance(accountList) {
    return accountList.map(function(account) {
        return { 'client_name': account.client_name, 'balance': account.balance }
    });
}
// The output should be: "Igor", "203004099.2"
console.log(getNameAndBalance(accounts));
// Create function that transfers an amount of cash from one account to another
// it should have four parameters:
//  - the accounts
//  - from account_number
//  - to account_number
//  - amount of cash to transfer
//
// Log "404 - account not found" if any of the account numbers don't exist to the console.

function transferAmount(accountList, senderNumber, recieverNumber, amount) {
    try {
        let sender = accountList.find(ac => ac.account_number === senderNumber);
        let reciever = accountList.find(ac => ac.account_number === recieverNumber);

        sender.balance -= amount;
        reciever.balance += amount;
    } catch (e) {
        console.log('404 - account cannot be found. We syphoned your money though lolci... :)')
    }
}

transferAmount(accounts, 43546731, 23456311, 500.0);
console.log(getNameAndBalance(accounts));

transferAmount(accounts, 43546731, 10000000, 1500.6);
console.log(getNameAndBalance(accounts));

// transferAmount(accounts, 43546731, 23456311, 500.0);
//After printing the "accounts" it should look like:
// var accounts = [
//	{ 'client_name': 'Igor', 'account_number': 11234543, 'balance': 203004099.2 },
//	{ 'client_name': 'Vladimir', 'account_number': 43546731, 'balance': 5204099571.23 },
//	{ 'client_name': 'Sergei', 'account_number': 23456311, 'balance': 1354100.0 }
//]
/*
module.exports = {
    getNameAndBalance: getNameAndBalance,
    transferAmount: transferAmount,
    accounts: accounts
};
*/
