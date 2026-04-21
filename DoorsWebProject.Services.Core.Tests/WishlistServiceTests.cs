namespace DoorsWebProject.Services.Core.Tests
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using DoorsWebProject.Web.ViewModels.Wishlist;
	using MockQueryable;
	using Moq;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[TestFixture]
	public class WishlistServiceTests
	{
		private Mock<IWishlistRepository> wishlistRepositoryMock;
		private IWishlistService wishlistService;


		[SetUp]
		public void Setup()
		{
			wishlistRepositoryMock = new Mock<IWishlistRepository>(MockBehavior.Strict);
			wishlistService = new WishlistService(wishlistRepositoryMock.Object);
		}

		[Test]
		public void PassAlways()
		{
			Assert.Pass();
		}

		[Test]
		public async Task GetWishlistDoorsAsyncShouldReturnEmptyCollectionWithNullUserId()
		{
			List<ApplicationUserDoor> applicationUserDoors = new List<ApplicationUserDoor>()
			{
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user1",
					DoorId = Guid.Parse("7496d032-185d-43d8-bb7d-ff0ca4f40f0a"),
					IsDeleted = false
				},
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user2",
					DoorId = Guid.Parse("b52778d8-e5e3-4901-a8f1-b5b0ae73f9b5"),
					IsDeleted = false
				}
			};

			IQueryable<ApplicationUserDoor> applicUserDoorsQuerable = 
				applicationUserDoors.BuildMock();

			wishlistRepositoryMock
				.Setup(wr => wr.GetAllAttached())
				.Returns(applicUserDoorsQuerable);

			IEnumerable<WishlistViewModel> result = await wishlistService.GetWishlistDoorsAsync(null);

			Assert.IsEmpty(result);

		}

		[Test]
		public async Task GetWishlistDoorsAsyncShouldReturnEmptyCollectionWithEmptyUserId()
		{
			string emptyUserId = string.Empty;

			List<ApplicationUserDoor> applicationUserDoors = new List<ApplicationUserDoor>()
			{
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user1",
					DoorId = Guid.Parse("7496d032-185d-43d8-bb7d-ff0ca4f40f0a"),
					IsDeleted = false
				},
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user2",
					DoorId = Guid.Parse("b52778d8-e5e3-4901-a8f1-b5b0ae73f9b5"),
					IsDeleted = false
				}
			};

			IQueryable<ApplicationUserDoor> applicUserDoorsQuerable =
				applicationUserDoors.BuildMock();

			wishlistRepositoryMock
				.Setup(wr => wr.GetAllAttached())
				.Returns(applicUserDoorsQuerable);

			IEnumerable<WishlistViewModel> result = await wishlistService.GetWishlistDoorsAsync(emptyUserId);

			Assert.IsEmpty(result);
		}

		[Test]
		public async Task GetWishlistDoorsAsyncShouldReturnViewModelCollectionWithValidUserId()
		{
			string validUserId = "user1";

			List<ApplicationUserDoor> applicationUserDoors = new List<ApplicationUserDoor>()
			{
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user1",
					DoorId = Guid.Parse("7496d032-185d-43d8-bb7d-ff0ca4f40f0a"),
					IsDeleted = false
				},
				new ApplicationUserDoor()
				{
					ApplicationUserId = "user1",
					DoorId = Guid.Parse("b52778d8-e5e3-4901-a8f1-b5b0ae73f9b5"),
					IsDeleted = false
				}
			};

			ApplicationUserDoor applicationUserDoorFirst = applicationUserDoors.First();

			IQueryable<ApplicationUserDoor> applicUserDoorsQuerable =
				applicationUserDoors.BuildMock();

			wishlistRepositoryMock
				.Setup(wr => wr.GetAllAttached())
				.Returns(applicUserDoorsQuerable);

			IEnumerable<WishlistViewModel> result = await wishlistService.GetWishlistDoorsAsync(validUserId);

			WishlistViewModel firstRealApplicationUserDoor = result.First();


			Assert.AreEqual(applicationUserDoorFirst.ApplicationUserId.ToString() , firstRealApplicationUserDoor.Id);
			
		}
	}
}
