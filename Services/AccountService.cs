using BusinessObjects.Models;
using Repositories;

namespace Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;

    public AccountService()
    {
        _accountRepository = new AccountRepository();
    }

    public AccountMember GetAccountById(string accountId)
    {
        return _accountRepository.GetAccountById(accountId);
    }
}