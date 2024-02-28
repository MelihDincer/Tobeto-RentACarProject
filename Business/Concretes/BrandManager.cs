﻿using AutoMapper;
using Business.Abstracts;
using Business.Requests.Brands;
using Business.Responses.Brands;
using Core.Exceptions.Types;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;
    public BrandManager(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<IDataResult<CreateBrandResponse>> AddAsync(CreateBrandRequest request)
    {
        await CheckIfBrandNameNotExists(request.Name.TrimStart());
        Brand brand = _mapper.Map<Brand>(request);
        brand.Id = Guid.NewGuid();
        await _brandRepository.Add(brand);

        CreateBrandResponse response = _mapper.Map<CreateBrandResponse>(brand);
        return new SuccessDataResult<CreateBrandResponse>(response, "Added Successfully");
    }

    public async Task<IResult> DeleteAsync(DeleteBrandRequest deleteBrandRequest)
    {
        Brand brand = _mapper.Map<Brand>(deleteBrandRequest);
        await _brandRepository.Delete(brand);
        return new SuccessResult("Silindi");
    }

    public async Task<IDataResult<List<GetAllBrandResponse>>> GetAllAsync()
    {
        List<Brand> brands = await _brandRepository.GetAll();
        List<GetAllBrandResponse> responses = _mapper.Map<List<GetAllBrandResponse>>(brands);
        return new SuccessDataResult<List<GetAllBrandResponse>>(responses, "Listed Successfully");
    }

    public async Task<List<GetAllBrandResponse>> GetAllBrandName(string name)
    {
        List<Brand> brands = await _brandRepository.GetAll(x => x.Name == name);
        List<GetAllBrandResponse> responses = _mapper.Map<List<GetAllBrandResponse>>(brands);
        return responses;
    }

    private async Task CheckIfBrandNameNotExists(string brandName)
    {
        var isExists = await _brandRepository.Get(brand => brand.Name == brandName);
        if (isExists is not null)
            throw new BusinessException("Brand name already exists");           
    }
}