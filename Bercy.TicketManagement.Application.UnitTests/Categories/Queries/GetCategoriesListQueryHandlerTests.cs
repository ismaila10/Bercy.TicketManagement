using AutoMapper;
using Bercy.TicketManagement.Application.Contracts.Persistence;
using Bercy.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Bercy.TicketManagement.Application.Profiles;
using Bercy.TicketManagement.Application.UnitTests.Mocks;
using Bercy.TicketManagement.Domain.Entities;
using Moq;
using Shouldly;

namespace Bercy.TicketManagement.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mockCategoryRepository.Object, _mapper);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
