using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloudlyEF.Models;
using AutoMapper;
using CloudlyEF.Dto;
using CloudlyEF.App_Start;
using System.Data.Entity;

namespace CloudlyEF.Controllers.api
{
    public class CustomersController : ApiController
    {
		private ApplicationDbContext _context;

		private readonly IMapper _mapper;

		

		public CustomersController(IMapper mapper)
        {
			_context = new ApplicationDbContext();
			_mapper = mapper;
		}


		//GET api/customers

		public IHttpActionResult GetCustomers()
		{
			var customerDtos = _mapper.Map<IEnumerable<CustomerDto>>(_context.Customers.Include(c => c.MembershipType).ToList());
			
			return Ok(customerDtos);
		}

		//GET api/customers/1

		public IHttpActionResult GetCustomers(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);
			

			return Ok(_mapper.Map<CustomerDto>(customer));
		}

		//POST /api/customers
		[HttpPost]
		public IHttpActionResult CreateCustomer(CustomerDto customerDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var customer = _mapper.Map<CustomerDto, Customers>(customerDto); 
			
			_context.Customers.Add(customer);
			_context.SaveChanges();

			customerDto.Id = customer.Id;
			return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
		}

		//PUT /api/customers/1
		[HttpPut]
		public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				return NotFound();

			_mapper.Map(customerDto, customerInDb);
			
			_context.SaveChanges();

			return Ok();
		}

		//DELETE /api/customers/1

		[HttpDelete]
		public IHttpActionResult DeleteCustomer(int id)
		{

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				return NotFound();

			_context.Customers.Remove(customerInDb);
			_context.SaveChanges();

			return Ok();
		}

	}
}
