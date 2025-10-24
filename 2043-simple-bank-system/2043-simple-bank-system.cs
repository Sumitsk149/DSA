public class Bank {

    long[] bankBalance;

    public Bank(long[] balance) 
    {
        bankBalance = balance;
    }
    
    public bool Transfer(int account1, int account2, long money) 
    {
        if(account1 > bankBalance.Length || account2 > bankBalance.Length || money > bankBalance[account1 - 1])
        {
            return false;
        }
        else
        {
            bankBalance[account1 - 1] = bankBalance[account1 - 1] - money;
            bankBalance[account2 - 1] = bankBalance[account2 - 1] + money;
            return true;
        }
        
    }
    
    public bool Deposit(int account, long money) 
    {
        if(account > bankBalance.Length)
        {
            return false;
        }
        else
        {
            bankBalance[account - 1] = bankBalance[account - 1] + money;
            return true;
        }
    }
    
    public bool Withdraw(int account, long money) 
    {
        if(account > bankBalance.Length || money > bankBalance[account - 1])
        {
            return false;
        }
        else
        {
            bankBalance[account - 1] = bankBalance[account - 1] - money;
            return true;
        }
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */