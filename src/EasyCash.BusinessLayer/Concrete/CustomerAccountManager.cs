using EasyCash.BusinessLayer.Abstract;
using EasyCash.DataAccessLayer.Abstract;
using EasyCash.EntityLayer.Concrete;

namespace EasyCash.BusinessLayer.Concrete;

public class CustomerAccountManager : ICustomerAccountService
{
    private readonly ICustomerAccountDal _customerAccountDal;

    public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
    {
        _customerAccountDal = customerAccountDal;
    }
    public async Task TDeleteAsync(CustomerAccount entity)
    {
        await _customerAccountDal.DeleteAsync(entity);
    }

    public async Task<IEnumerable<CustomerAccount>> TGetAllAsync()
    {
       return await _customerAccountDal.GetAllAsync();
    }

    public async Task<CustomerAccount> TGetByIdAsync(int id)
    {
        return await _customerAccountDal.GetByIdAsync(id);
    }

    public async Task TInsertAsync(CustomerAccount entity)
    {
        await _customerAccountDal.InsertAsync(entity);
    }

    public async Task TUpdateAsync(CustomerAccount entity)
    {
        await _customerAccountDal.UpdateAsync(entity);
    }
}
