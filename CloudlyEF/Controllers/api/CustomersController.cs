using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloudlyEF.Models;

namespace CloudlyEF.Controllers.api
{
    public class CustomersController : ApiController
    {
		private ApplicationDbContext _context;

        public CustomersController()
        {
			_context = new ApplicationDbContext();

		}


		//GET api/customers

		public IEnumerable<Customers> GetCustomers()
		{
			return _context.Customers.ToList();
		}

		//GET api/customers/1

		public Customers GetCustomers(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);
			return customer;
		}

		//POST /api/customers
		[HttpPost]
		public Customers CreateCustomer(Customers customer)
		{
			if (!ModelState.IsValid)
				throw new HttpResponseException(HttpStatusCode.BadRequest);

			_context.Customers.Add(customer);
			_context.SaveChanges();

			return customer;
		}

		//PUT /api/customers/1
		[HttpPut]
		public void UpdateCustomer(int id, Customers customer)
		{
			if (!ModelState.IsValid)
				throw new HttpResponseException(HttpStatusCode.BadRequest);

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);
		
			customerInDb.Name = customer.Name;
			customerInDb.Birthdate = customer.Birthdate;
			customerInDb.MembershipTypeId = customer.MembershipTypeId;
			customerInDb.IsSubscribedNewsLetter = customer.IsSubscribedNewsLetter;
			
			_context.SaveChanges();
		}

		//DELETE /api/customers/1

		[HttpDelete]
		public void DeleteCustomer(int id)
		{

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);
		
			_context.Customers.Remove(customerInDb);
			_context.SaveChanges();
		}

	}
}
