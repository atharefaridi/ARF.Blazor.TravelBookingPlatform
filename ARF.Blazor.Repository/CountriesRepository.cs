﻿using ARF.Blazor.Models;
using ARF.Blazor.Repository.Interfaces;
using ARF.Blazor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARF.Blazor.Repository
{
    internal class CountriesRepository : iCountriesRepository
    {
        public List<Country> GetAllCountries()
        {
            DAL.Countries countries = new DAL.Countries();
            return countries.GetAllCountries();
        }

        public void Add(Country country)
        {
            DAL.Countries countries = new DAL.Countries();
             countries.Add(country);
        }

        public Country GetByID(string id)
        {
            DAL.Countries countries = new DAL.Countries();
            return countries.GetByID(id);
        }

        public void Update(Country country)
        {
            DAL.Countries countries = new DAL.Countries();
            countries.Update(country.id,country);
        }

     
    }
}
