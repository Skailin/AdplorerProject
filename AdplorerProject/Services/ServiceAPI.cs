using AdplorerProject.AdplorerAPIServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdplorerProject.Services
{
    public class ServiceAPI : IServiceAPI
    {
        public CustomerDto[] GetCustomersByQueryWS()
        {
            CustomerWSSoapClient client = new CustomerWSSoapClient();

            AuthHeader soapReqHeader = new AuthHeader { UserName = "test", Password = "start" };
            CustomerQueryDto soapReqBody = new CustomerQueryDto();


            CustomerQueryItemDto[] query = new CustomerQueryItemDto[] { new CustomerQueryItemDto {
                QueryOperator = QueryOperator.Equals,
                QueryProperty = CustomerQueryProperty.IdAccountingClient,
                Value = "1223"}};

            soapReqBody.QueryItemList = query;

            GetCustomersResponse response;

            try
            {
                response = client.GetCustomersByQueryWS(soapReqHeader, soapReqBody);
            }
            catch (Exception)
            {
                throw;
            }

                       
            CustomerDto[] customerData = response.CustomerList;

            return customerData;
        }
    }
}