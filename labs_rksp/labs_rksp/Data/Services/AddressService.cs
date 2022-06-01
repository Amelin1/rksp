using labs_rksp.Data.DTOs;
using labs_rksp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace labs_rksp.Data.Services;

public class AddressService
{
    private EducationContext _context;
            public AddressService(EducationContext context)
            {
                _context = context;
            }
    
            public async Task<Address?> AddAddress(AddressDTO address)
            {
                Address naAddress = new Address()
                {
                    City = address.City,
                    Street = address.Street,
                    HomeNumber = address.HomeNumber,
                };
    
                var result = _context.Addresses.Add(naAddress);
                await _context.SaveChangesAsync();
                return await Task.FromResult(result.Entity);
            }
    
            public async Task<Address?> GetAddress(int id)
            {
                var result = _context.Addresses.FirstOrDefault(address => address.Id == id);
                return await Task.FromResult(result);
            }
    
            public async Task<List<Address>> GetAddresses()
            {
                var result = await _context.Addresses.ToListAsync();
                return await Task.FromResult(result);
            }
    
            public async Task<Address?> UpdateAddress(int id, Address newAddress)
            {
                var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == id);
                if (address != null)
                {
                    address.Id = newAddress.Id;
                    address.City = newAddress.City;
                    address.Street = newAddress.Street;
                    address.HomeNumber = newAddress.HomeNumber;
                    _context.Addresses.Update(address);
                    _context.Entry(address).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return address;
                }
    
                return null;
            }
    
            public async Task<bool> DeleteAddresses(int id)
            {
                var address = await _context.Addresses.FirstOrDefaultAsync(s => s.Id == id);
                if (address != null)
                {
                    _context.Addresses.Remove(address);
                    await _context.SaveChangesAsync();
                    return true;
                }
    
                return false;
    
            }
        }
