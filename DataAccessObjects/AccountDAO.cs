using BusinessObjects.Models;

namespace DataAccessObjects;

public class AccountDAO
{
    public static AccountMember GetAccountById(string accountID)
    {
        return new AccountMember();
    }
}