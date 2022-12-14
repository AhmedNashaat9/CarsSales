using AutoMapper;
using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.Mapping;
using CarSales.Application.Services;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using CarSales.Infrastructure.Repository;
using CarSalesUnitTest.FakeRepositories;
using CarSalesUnitTest.Mapping;
using Moq;
using SalesCore.Application.IRepository;

namespace CarSalesUnitTest;
public class UnitTest1
{

    public UnitTest1()
    {
    
    }
    [Fact]
    public void Car_Createcar_Test_TrueSenario()
    {
        
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper =new Mapper(_mapconf);
        CarFakeRepository _fakeCarRepo = new CarFakeRepository();
        
        BaseService _carservice = new BaseService(_fakeCarRepo, _mapper);
        var _carIM = new CarIM()
        {
            color="Red",
            Name="mg5",
            price=100,
            Type="MG"
        };
        var CreateCar = _carservice.Create(_carIM);

        Assert.Equal("ok", CreateCar);
    }
    [Fact]
    public void Car_GetAllcars_Test_TrueSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        CarFakeRepository _fakeCarRepo = new CarFakeRepository();

        BaseService _carservice = new BaseService(_fakeCarRepo, _mapper);
        
        var CarGetAll = _carservice.GetAll();

        Assert.True(CarGetAll.Count>1);
    }
    
    [Fact]
    public void Car_getCarById_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        CarFakeRepository _fakeCarRepo = new CarFakeRepository();

        BaseService _carservice = new BaseService(_fakeCarRepo, _mapper);

        var CarGetById = _carservice.GetById(1);

        Assert.True(CarGetById!=null);
    }
    [Fact]
    public void Car_getCarById_method_test_NullSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        CarFakeRepository _fakeCarRepo = new CarFakeRepository();

        BaseService _carservice = new BaseService(_fakeCarRepo, _mapper);

        var CarGetById = _carservice.GetById(9);

        Assert.True(CarGetById == null);
    }
    [Fact]
    public void Car_DeleteCar_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        CarFakeRepository _fakeCarRepo = new CarFakeRepository();

        BaseService _carservice = new BaseService(_fakeCarRepo, _mapper);

        var DeleteCar = _carservice.Delete(2);

        Assert.Equal("deleted",DeleteCar);
    }
    [Fact]
    public void Car_getColor_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        var CarServices = new Mock<ICarRepository>();
        CarServices.Setup(x => x.GetColor(It.IsAny<int>())).Returns("blue");
        CarService _carService = new CarService(CarServices.Object, _mapper);

        var CarGetAll = _carService.GetColor(3);

        Assert.Equal("blue", CarGetAll);

    }
    [Fact]
    public void Car_getByType_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        var CarServices = new Mock<ICarRepository>();
        var _car=new List<Car>()
        {
            new Car(){
            Color="Black",
            Type="mercedes",
            Name="AMG",
            Price=220,
            Id=2,
            },
            new Car(){
            Color="White",
            Type="BMW",
            Name="AMG",
            Price=220,
            Id=2,
            }
        };
        CarServices.Setup(x => x.GetByType(It.IsAny<string>())).Returns(_car);
        CarService _carService = new CarService(CarServices.Object, _mapper);

        var CarGetAll = _carService.GetByType("Mercedes");

        Assert.True(CarGetAll.Count==2);

    }

    [Fact]
    public void Car_CreatePlate_Test_TrueSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        PlateFakeRepository _fakePlateRepo = new PlateFakeRepository();

        PlateService _carservice = new PlateService(_fakePlateRepo, _mapper);
        var _carIM = new PlateIM()
        {
            
            CarId = 7,
            FrontPlate = "44ddf",
            RearPlate = "44ddf",
        };
        var CreatePlate = _carservice.Create(_carIM);

        Assert.Equal("ok", CreatePlate);
    }
    [Fact]
    public void Car_CreatePlate_Test_RearPlateandFrontPlateMustBeEqualSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        PlateFakeRepository _fakePlateRepo = new PlateFakeRepository();

        PlateService _carservice = new PlateService(_fakePlateRepo, _mapper);
        var _plateIM = new PlateIM()
        {

            CarId = 7,
            FrontPlate = "44ddf",
            RearPlate = "44dds",
        };
        var CreatePlate = _carservice.Create(_plateIM);

        Assert.False(CreatePlate=="ok");
    }
    [Fact]
    public void Car_DeletePlate_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        PlateFakeRepository _fakePlateRepo = new PlateFakeRepository();


        PlateService _carservice = new PlateService(_fakePlateRepo, _mapper);

        var DeletePlate = _carservice.Delete(2);

        Assert.Equal("deleted", DeletePlate);
    }
    [Fact]
    public void Car_GetAllPlates_Test_TrueSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        PlateFakeRepository _fakePlateRepo = new PlateFakeRepository();
        PlateService _carservice = new PlateService(_fakePlateRepo, _mapper);

        var PlateGetAll = _carservice.GetAll();

        Assert.True(PlateGetAll.Count > 1);
    }

    [Fact]
    public void Car_getPlateById_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        PlateFakeRepository _fakePlateRepo = new PlateFakeRepository();
        PlateService _carservice = new PlateService(_fakePlateRepo, _mapper);

        var PlateGetById = _carservice.GetById(1);

        Assert.True(PlateGetById != null);
    }
    [Fact]
    public void Car_CreateInsuranceContract_Test_TrueSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        InsuranceFakeRepository _fakeInsuranceRepo = new InsuranceFakeRepository();

        InsuranceService _InsuranceService = new InsuranceService(_fakeInsuranceRepo,_mapper);
        var _InsuranceIM = new InsuranceIM()
        {
            CarId = 4,
                    InsuranceAmount = 390,
                    InsuranceName = "dddf",
            
        };
        var CreateInsurance = _InsuranceService.Create(_InsuranceIM);

        Assert.Equal("ok", CreateInsurance);
    }
    [Fact]
    public void Car_DeleteInsuranceContract_method_test()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        InsuranceFakeRepository _fakeInsuranceRepo = new InsuranceFakeRepository();
        InsuranceService _InsuranceService = new InsuranceService(_fakeInsuranceRepo, _mapper);
        var DeleteInsurance = _InsuranceService.Delete(2);
        Assert.Equal("deleted", DeleteInsurance);
        

    }
    [Fact]
    public void Car_GetAllInsuranceContracts_Test_TrueSenario()
    {

        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        InsuranceFakeRepository _fakeInsuranceRepo = new InsuranceFakeRepository();

        InsuranceService _InsuranceService = new InsuranceService(_fakeInsuranceRepo, _mapper);

        var InsuranceGetAll = _InsuranceService.GetAll();

        Assert.True(InsuranceGetAll.Count > 1);
    }

    [Fact]
    public void Car_getInsuranceContractByCarId_method_test_TrueSenario()
    {
        MapperConfiguration _mapconf = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });
        IMapper _mapper = new Mapper(_mapconf);
        InsuranceFakeRepository _fakeInsuranceRepo = new InsuranceFakeRepository();

        InsuranceService _InsuranceService = new InsuranceService(_fakeInsuranceRepo, _mapper);

        var InsuranceByCarId = _InsuranceService.GetByCarId(1);

        Assert.True(InsuranceByCarId != null);
    }

}