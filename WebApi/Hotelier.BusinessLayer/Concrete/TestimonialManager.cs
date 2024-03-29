﻿using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testimonialDal;
		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}
		public void TDelete(Testimonial item)
		{
			_testimonialDal.Delete(item);
		}

		public Testimonial TGetByID(int id)
		{
			return _testimonialDal.GetByID(id);
		}

		public List<Testimonial> TGetList()
		{
			return _testimonialDal.GetList();
		}

		public void TInsert(Testimonial item)
		{
			_testimonialDal.Insert(item);
		}

		public void TUpdate(Testimonial item)
		{
			_testimonialDal.Update(item);
		}
	}
}
