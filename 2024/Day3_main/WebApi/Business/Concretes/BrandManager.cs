using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)  //Command-Create
    {
        //business rules

        //mapping -->automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate=DateTime.Now;

        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createdBrandResponce = new CreatedBrandResponse();
        createdBrandResponce.Name = brand.Name;
        createdBrandResponce.Id = 4;
        createdBrandResponce.CreatedDate=brand.CreatedDate;

        

        return createdBrandResponce;
    }

    public List<GetAllBrandResponse> GetAll() //Query-Read
    {
       List<Brand> brands = _brandDal.GetAll();

        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

        foreach (Brand brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.CreatedDate=brand.CreatedDate;

            getAllBrandResponses.Add(getAllBrandResponse);
        
        }
        return getAllBrandResponses;

    }
}
