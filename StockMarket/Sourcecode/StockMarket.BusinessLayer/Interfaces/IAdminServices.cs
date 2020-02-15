﻿
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.BusinessLayer
{
   public interface IAdminServices
    {
        bool AddCompany(Company company);
        bool DeleteCompany(int Id);
        List<Company> ViewCompany(Company company);
        Company EditCompany(int Id);
        IPODetail UpdateIPODetail(int Id);
        Company GetCompanyById(int Id);
        bool ImportData(object file);//Upload the Excel file of Stock Exchange. 
        IPODetail GetIPOById(int Id);
    }
}
