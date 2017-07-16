using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using BinaryWeatherApp.Repositories;
using BinaryWeatherApp.Controllers;
using FakeItEasy;
using BinaryWeatherApp.Models;
using System.Web.Mvc;

namespace BinaryWeatherApp.Tests
{
	//[TestFixture]
	//class TownsControllerTests
	//{
	//	private ITownsRepository _towns = A.Fake<ITownsRepository>();
	//	[SetUp]
	//	public void Setup ()
	//	{

	//		_towns.Create(new Town { TownId = 1, TownName = "Kharkov" });
			
	//	}

	//	[TearDown]
	//	public void Teardown ()
	//	{
	//		_towns.DeleteAll();
	//	}

	//	[Test]
	//	public void Create_When_Empty_City_Then_ModelNotValid ()
	//	{
	//		//Arrange
	//		_towns.DeleteAll();
	//		var _controller = new TownsController(_towns);

	//		//Act
	//		_controller.Create(new Town() { TownId = 1, TownName = "" });

	//		//Assert
	//		Assert.That(_towns.GetAll().Count == 0);
	//	}

	//	[Test]
	//	public void Edit_When_Valid_Data_Then_RedirectToAction()
	//	{
	//		//Arrange
	//		var _controller = new TownsController(_towns);

	//		//Act
	//		var res = _controller.Edit(new Town() { TownId = 1, TownName = "Kharkov" });

	//		//Assert
	//		Assert.IsInstanceOf<RedirectToRouteResult>(res);
	//	}

	//	[Test]
	//	public void Delete_Id_Is_Null_No_Changes ()
	//	{
	//		//Arrange 
	//		var _towns2 = _towns;
	//		var _controller = new TownsController(_towns);

	//		//Act
	//		_controller.Delete(0);

	//		//Assert
	//		Assert.AreEqual(_towns, _towns2);
	//	}
		
	//}
}
