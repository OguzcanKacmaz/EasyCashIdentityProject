using EasyCash.BusinessLayer.Abstract;
using EasyCash.DataAccessLayer.Abstract;
using EasyCash.EntityLayer.Concrete;

namespace EasyCash.BusinessLayer.Concrete;

public class CustomerAccountProcessManager : ICustomerAccountProcessService
{
    private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

    public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
    {
        _customerAccountProcessDal = customerAccountProcessDal;
    }
    public async Task TDeleteAsync(CustomerAccountProcess entity)
    {
        await _customerAccountProcessDal.DeleteAsync(entity);
    }

    public async Task<IEnumerable<CustomerAccountProcess>> TGetAllAsync()
    {
        return await _customerAccountProcessDal.GetAllAsync();
    }

    public async Task<CustomerAccountProcess> TGetByIdAsync(int id)
    {
        return await _customerAccountProcessDal.GetByIdAsync(id);
    }

    public async Task TInsertAsync(CustomerAccountProcess entity)
    {
        await _customerAccountProcessDal.InsertAsync(entity);
    }

    public async Task TUpdateAsync(CustomerAccountProcess entity)
    {
        await _customerAccountProcessDal.UpdateAsync(entity);
    }
}
