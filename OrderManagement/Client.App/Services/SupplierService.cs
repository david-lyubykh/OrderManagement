using Client.App.Services.IService;
using Models;
using Models.SupplierDtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.App.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly HttpClient _client;
        private readonly IStateService _stateService;

        public SupplierService(HttpClient client, IStateService stateService)
        {
            _stateService = stateService;
            _client = client;
        }

        public async Task<IEnumerable<SupplierDto>> GetSuppliers()
        {
            var response = await _client.GetAsync($"api/Supplier/GetSuppliers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var suppliers = JsonConvert.DeserializeObject<IEnumerable<SupplierDto>>(content);
                var states = _stateService.GetStates();
                foreach (var supplier in suppliers)
                {
                    supplier.State = states.FirstOrDefault(s => s.Id == supplier.StateId);
                }
                return suppliers;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorResult>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<UpdateSupplierDto> GetSupplier(int supplierId)
        {
            var response = await _client.GetAsync(
                $"api/Supplier/GetSupplier?supplierId={supplierId}"
            );

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UpdateSupplierDto>(content);
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorResult>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<SupplierDto> CreateSupplier(CreateSupplierDto createSupplierDto)
        {
            var content = JsonConvert.SerializeObject(createSupplierDto);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/supplier/create", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SupplierDto>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorResult>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<SupplierDto> UpdateSupplier(UpdateSupplierDto updateSupplierDto)
        {
            var content = JsonConvert.SerializeObject(updateSupplierDto);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/supplier/update", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SupplierDto>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorResult>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<bool> DeleteSupplier(int supplierId)
        {
            var response = await _client.PostAsync(
                $"api/supplier/Delete?supplierId={supplierId}",
                null
            );

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorResult>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }
    }
}
