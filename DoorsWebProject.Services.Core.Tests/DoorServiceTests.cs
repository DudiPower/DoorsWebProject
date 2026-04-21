namespace DoorsWebProject.Services.Core.Tests
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using MockQueryable;
	using Moq;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Text;
	using System.Threading.Tasks;
	using static DoorsWebProject.Data.Models.Door;


	[TestFixture]
	public class DoorServiceTests
	{
		private Mock<IDoorRepository> doorRepositoryMock;
		private IDoorService doorService;


		[SetUp]
		public void Setup()
		{
			doorRepositoryMock = new Mock<IDoorRepository>(MockBehavior.Strict);
			doorService = new DoorService(doorRepositoryMock.Object);
		}

		[Test]
		public void PassAlways()
		{
			Assert.Pass();
		}

		[Test]
		public async Task GetAllDoorsShouldReturnEmptyCollection()
		{
			List<Door> emptyDoorList = new List<Door>();
			IQueryable<Door> emptyDoorQuerable = emptyDoorList
				.BuildMock();

			this.doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(emptyDoorQuerable);

			    IEnumerable<DoorViewModel> emptyDoorViewModelColl = 
				await this.doorService.GetAllDoorsAsync();

			Assert.IsNotNull(emptyDoorViewModelColl);
			Assert.AreEqual(emptyDoorList.Count(), emptyDoorViewModelColl.Count());
		}

		[Test]

		public async Task GetAllDoorsShouldReturnSameCollectionSizeWhenNonEmpty()
		{
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model1",
					ImageUrl = "ImageUrl1",
					Type = "Type1",
					Description = "Description1",
					Price = 100,
					Height = 200,
					Width = 80,
					Thickness = 5,
					IsDeleted = false,
					ApplicationUserId = null,
				},

				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model2",
					ImageUrl = "ImageUrl2",
					Type = "Type2",
					Description = "Description2",
					Price = 200,
					Height = 210,
					Width = 90,
					Thickness = 6,
					IsDeleted = false,
					ApplicationUserId = null,
				}
			};

			IQueryable<Door> doorQuerable = doorList
				.BuildMock();

			this.doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorQuerable);

			IEnumerable<DoorViewModel> doorViewModelColl =
			await this.doorService.GetAllDoorsAsync();

			Assert.IsNotNull(doorViewModelColl);
			Assert.AreEqual(doorList.Count(), doorViewModelColl.Count());
		}

		[Test]

		public async Task GetAllDoorsShouldReturnSameCollectionInDoorViewModel()
		{
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model1",
					ImageUrl = "ImageUrl1",
					Type = "Type1",
					Description = "Description1",
					Price = 100,
					Height = 200,
					Width = 80,
					Thickness = 5,
					IsDeleted = false,
					ApplicationUserId = null,
				},

				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model2",
					ImageUrl = "ImageUrl2",
					Type = "Type2",
					Description = "Description2",
					Price = 200,
					Height = 210,
					Width = 90,
					Thickness = 6,
					IsDeleted = false,
					ApplicationUserId = null,
				}
			};

			IQueryable<Door> doorQuerable = doorList
				.BuildMock();

			this.doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorQuerable);

			IEnumerable<DoorViewModel> doorViewModelColl =
			await this.doorService.GetAllDoorsAsync();

			Assert.IsNotNull(doorViewModelColl);
			Assert.AreEqual(doorList.Count(), doorViewModelColl.Count());


		}

		[Test]
		public async Task HardDeleteDoorAsyncShouldReturnFalse()
		{

			doorRepositoryMock
			    .Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
			    .ReturnsAsync((Door?)null);

            var nullResult = await doorService.HardDeleteDoorAsync(Guid.NewGuid().ToString());

			Assert.False(nullResult);

		}

		[Test]
		public async Task HardDeleteDoorAsyncShouldReturnTrue()
		{

			Door door = new Door()
			{
				DoorId = Guid.NewGuid(),
				Model = "Model24",

			};


			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync(door);

			doorRepositoryMock
				.Setup(dr => dr.HardDeleteAsync(It.IsAny<Door>()))
				.ReturnsAsync(true);

			var trueResult = await doorService.HardDeleteDoorAsync(door.DoorId.ToString());

			Assert.True(trueResult);
		}

		[Test]

		public async Task SoftDeleteDoorAsyncShouldReturnFalse()
		{
			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync((Door?)null);

			var nullResult = await doorService.SoftDeleteDoorAsync(Guid.NewGuid().ToString());

			Assert.False(nullResult);
		}

		[Test]
		public async Task SoftDeleteDoorAsyncShouldReturnTrue()
		{
			Door door = new Door()
			{
				DoorId = Guid.NewGuid(),
				Model = "Model24",

			};


			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync(door);

			doorRepositoryMock
				.Setup(dr => dr.SoftDeleteAsync(It.IsAny<Door>()))
				.ReturnsAsync(true);

			var trueResult = await doorService.SoftDeleteDoorAsync(door.DoorId.ToString());

			Assert.True(trueResult);
		}

		[Test]
		public async Task FindDoorByStringIdShouldReturnFalse()
		{
			var result = await doorService.FindDoorByStringId("dadwwqdd");

			Assert.Null(result);
		}

		[Test]
		public async Task FindDoorByStringIdShouldReturnNull()
		{
			var result = await doorService.FindDoorByStringId(null);

			Assert.Null(result);
		}


		[Test]
		public async Task FindDoorByStringIdShouldReturnWhiteSpace()
		{
			var result = await doorService.FindDoorByStringId("  ");

			Assert.Null(result);
		}

		[Test]
		public async Task FindDoorByStringIdShouldReturnDoor()
		{
			Door door1 = new Door()
			{
				DoorId = Guid.NewGuid(),
				Model = "Model25",

			};

			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync(door1);

			Assert.IsNotNull(door1);

		}

		[Test]
		public async Task GetDoorDeleteDetailsByIdShouldReturnNull()
		{
			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync((Door?)null);

			var result = await doorService.GetDoorDeleteDetailsById(Guid.NewGuid().ToString());

			Assert.Null(result);
		}

		[Test]
		public async Task GetDoorDeleteDetailsByIdShouldReturnSameInformationInViewModel()
		{
			Door doorForViewModel = new Door()
			{
				DoorId = Guid.NewGuid(),
				Model = "Model26",
				Price = 300,
			};


			doorRepositoryMock
				.Setup(dr => dr.GetByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync(doorForViewModel);

			var result = await doorService.GetDoorDeleteDetailsById(doorForViewModel.DoorId.ToString());

			Assert.IsNotNull(result);
			Assert.AreEqual(doorForViewModel.DoorId.ToString(), result.Id.ToString());
			Assert.AreEqual(doorForViewModel.Model, result.Model);
			Assert.AreEqual(doorForViewModel.Price, result.Price);
		}

		[Test]
		public async Task GetDoorDetailsByIdAsyncShouldReturnNull()
		{
			List<Door> doorList = new List<Door>();


			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorDetailsViewModel? result = await doorService.GetDoorDetailsByIdAsync(null);

			Assert.Null(result);
		}

		[Test]
		public async Task GetDoorDetailsByIdAsyncShouldReturnCorrectData()
		{
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()

				},
				new Door()
				{
					DoorId = Guid.NewGuid(),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}

			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorDetailsViewModel? result = await doorService.GetDoorDetailsByIdAsync(doorFirst.DoorId.ToString());

			Assert.IsNotNull(result);
			Assert.AreEqual(doorFirst.DoorId.ToString(), result.Id.ToString());
			Assert.AreEqual(doorFirst.Model, result.Model);
			Assert.AreEqual(doorFirst.ImageUrl, result.ImageUrl);
			Assert.AreEqual(doorFirst.Description, result.Description);
			Assert.AreEqual(doorFirst.Thickness, result.Thickness);
			Assert.AreEqual(doorFirst.Height, result.Height);
			Assert.AreEqual(doorFirst.Width, result.Width);

			Assert.IsNotNull(result.DoorColors);
			Assert.AreEqual(doorFirst.DoorColors.Count(), result.DoorColors.Count());
		}

		[Test]
		public async Task GetDoorDetailsByIdAsyncShouldReturnCorrectDataAndColors()
		{
			Color color = new Color()
			{
				ColorId = Guid.Parse("8fe605ec-f3b8-4bc1-a46d-439e02c5cb15"),
				NameColor = "Color1",
				HexCode = "#FFFFFF",
				TextureUrl = "TextureUrl1",
			};

			List<DoorColor> doorColors = new List<DoorColor>()
			{
				new DoorColor()
				{
					ColorId = Guid.Parse("8fe605ec-f3b8-4bc1-a46d-439e02c5cb15"),
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Color = color,
				}
			};

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = doorColors
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorDetailsViewModel? result = await doorService.GetDoorDetailsByIdAsync(doorFirst.DoorId.ToString());

			Assert.IsNotNull(result);

			Assert.AreEqual(doorFirst.DoorId.ToString(), result.Id.ToString());
			Assert.AreEqual(doorFirst.Model, result.Model);
			Assert.AreEqual(doorFirst.ImageUrl, result.ImageUrl);
			Assert.AreEqual(doorFirst.Description, result.Description);
			Assert.AreEqual(doorFirst.Thickness, result.Thickness);
			Assert.AreEqual(doorFirst.Height, result.Height);
			Assert.AreEqual(doorFirst.Width, result.Width);

			Assert.IsNotNull(result.DoorColors);
			Assert.AreEqual(doorFirst.DoorColors.Count(), result.DoorColors.Count());

			var firstDoorColor = result.DoorColors.First();

			Assert.AreEqual(color.ColorId.ToString(), firstDoorColor.Id.ToString());
			Assert.AreEqual(color.NameColor, firstDoorColor.NameColor);
			Assert.AreEqual(color.HexCode, firstDoorColor.HexCode);
			Assert.AreEqual(color.TextureUrl, firstDoorColor.TextureUrl);
		}

		[Test]
		public async Task GetEditableDoorByIdAsyncShouldReturnNull()
		{
			List<Door> doorList = new List<Door>();


			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorFormInputModel? result = await doorService.GetEditableDoorByIdAsync(null);

			Assert.IsNull(result);

		}

		[Test]
		public async Task GetEditableDoorByIdAsyncShouldReturnNullWithInvalidDoorId()
		{

			string invalidDoorId = "18d4b2f0-8f90-4df0-b3f7-ddf2a4ba5334";
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};


			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorFormInputModel? result = await doorService.GetEditableDoorByIdAsync(invalidDoorId);

			Assert.IsNull(result);
		}

		[Test]
		public async Task GetEditableDoorByIdAsyncShouldReturnViewModelWithValidData()
		{
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			DoorFormInputModel? result = await doorService.GetEditableDoorByIdAsync(doorFirst.DoorId.ToString());

			Assert.IsNotNull(result);
			Assert.AreEqual(doorFirst.Model, result.Model);
			Assert.AreEqual(doorFirst.ImageUrl, result.ImageUrl);
			Assert.AreEqual(doorFirst.Description, result.Description);
			Assert.AreEqual(doorFirst.Thickness, result.Thickness);
			Assert.AreEqual(doorFirst.Height, result.Height);
			Assert.AreEqual(doorFirst.Width, result.Width);
		}

		[Test]
		public async Task EditDoorAsyncShouldReturnFalseWithNullableDooor()
		{
			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(r => r.SingleOrDefaultAsync(It.IsAny<Expression<Func<Door, bool>>>()))
				.ReturnsAsync((Door?)null);

			bool result = await doorService.EditDoorAsync(null);

			Assert.IsFalse(result);
		}

		[Test]
		public async Task EditDoorAsyncShouldReturnFalseWithInvalidDoorId()
		{

			DoorFormInputModel invalidDoor = new DoorFormInputModel()
			{
				Id = "18d4b2f0-8f90-4df0-b3f7-ddf2a4ba5334",
				Model = "Model256",
				ImageUrl = "ImageUrl12",
				Type = "Profiled",
				Description = "Description1",
				Price = 100,
				Thickness = 5m,
				Height = 200,
				Width = 80
			};

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(r => r.SingleOrDefaultAsync(It.IsAny<Expression<Func<Door, bool>>>()))
				.ReturnsAsync((Door?)null);

			bool result = await doorService.EditDoorAsync(invalidDoor);

			Assert.IsFalse(result);
		}

		[Test]
		public async Task EditDoorAsyncShouldReturnTrueWithValidDoorId()
		{
			DoorFormInputModel doorFormInputModel = new DoorFormInputModel()
			{
				Id = "97b964a4-eee5-4a53-b299-a7f365bcadf3",
				Model = "Model256",
				ImageUrl = "ImageUrl12",
				Type = "Profiled",
				Description = "Description1",
				Price = 100,
				Thickness = 5m,
				Width = 80,
				Height = 200
			};



			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(r => r.SingleOrDefaultAsync(It.IsAny<Expression<Func<Door, bool>>>()))
				.ReturnsAsync(doorFirst);

			doorRepositoryMock
				.Setup(dr => dr.UpdateAsync(It.IsAny<Door>()))
				.ReturnsAsync(true);

			bool result = await doorService.EditDoorAsync(doorFormInputModel);

			Assert.IsTrue(result);
		}

		[Test]
		public async Task SearchingDoorsAsyncReturnNullWithNullableDoorName()
		{
			string searchingDoorName = null;

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);

			
			var result = await doorService.SearchingDoorsAsync(searchingDoorName);

			Assert.IsEmpty(result);
		}

		[Test]
		public async Task SearchingDoorsAsyncReturnNullWithEmptyDoorName()
		{
			string searchingDoorName = " ";

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model255",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door doorFirst = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);


			var result = await doorService.SearchingDoorsAsync(searchingDoorName);

			Assert.IsEmpty(result);
		}

		[Test]
		public async Task SearchingDoorsAsyncReturnSearchingDoorsWithValidDoorName()
		{
			string searchingDoorName = "Model256";

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model256",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);


			var result = await doorService.SearchingDoorsAsync(searchingDoorName);

			Assert.AreEqual(doorList.Count(),result.Count());
		}

		[Test]
		public async Task SearchingDoorsAsyncReturnSearchingDoors()
		{
			string searchingDoorName = "Model256";

			List<Door> doorList = new List<Door>()
			{
				new Door()
				{
					DoorId = Guid.Parse("97b964a4-eee5-4a53-b299-a7f365bcadf3"),
					Model = "Model256",
					ImageUrl = "ImageUrl12",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Height = 200,
					Width = 80,
					DoorColors = new List<DoorColor>()
				},
				new Door()
				{
					DoorId = Guid.Parse("aff37e59-a1ee-4b94-9540-5d223e4a9326"),
					Model = "Model256",
					ImageUrl = "ImageUrl1",
					Type = "Profiled",
					Description = "Description1",
					Price = 100,
					Thickness = 5m,
					Width = 80,
					Height = 200,
					DoorColors = new List<DoorColor>()
				}
			};

			Door falseDoor = doorList.First();

			IQueryable<Door> doorsQuerable = doorList
				.BuildMock();

			doorRepositoryMock
				.Setup(dr => dr.GetAllAttached())
				.Returns(doorsQuerable);


			var result = await doorService.SearchingDoorsAsync(searchingDoorName);
			 
			DoorViewModel realDoor = result.First();


			Assert.AreEqual(doorList.Count(), result.Count());

			Assert.AreEqual(falseDoor.DoorId.ToString(), realDoor.Id.ToString());
			Assert.AreEqual(falseDoor.Model, realDoor.Model);
			Assert.AreEqual(falseDoor.ImageUrl, realDoor.ImageUrl);
			Assert.AreEqual(falseDoor.Price, realDoor.Price);
		}
	}
}
