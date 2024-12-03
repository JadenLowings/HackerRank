class Account {
    constructor(balance) {
        this.balance = balance;
    }

    debit(amount) {
        this.balance -= amount;
    }

    credit(amount) {
        this.balance += amount;
    }

    getBalance() {
        return this.balance;
    }
}