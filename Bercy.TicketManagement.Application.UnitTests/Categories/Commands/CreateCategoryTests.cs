﻿using AutoMapper;
using Bercy.TicketManagement.Application.Contracts.Persistence;
using Bercy.TicketManagement.Application.Features.Categories.Commands;
using Bercy.TicketManagement.Application.Profiles;
using Bercy.TicketManagement.Application.UnitTests.Mocks;
using Bercy.TicketManagement.Domain.Entities;
using Moq;
using Shouldly;

namespace Bercy.TicketManagement.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mockCategoryRepository.Object, _mapper);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();

            allCategories.Count.ShouldBe(5);
        }
    }
}
