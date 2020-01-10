using FluentValidation;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using Lezizz.Core.Domain.Entities;
using MediatR;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Foods.Commands
{
    public class CreateFoodCommand : IRequest<int>
    {
        public CreateFoodCommand(
            string name,
            string description,
            int categoryId)
        {
            Name = name;
            Description = description;
            CategoryId = categoryId;
        }

        public string Name { get; }
        public string Description { get; }
        public int CategoryId { get; }


        public static explicit operator Food(CreateFoodCommand createFoodCommand) =>
            JsonConvert.DeserializeObject<Food>(JsonConvert.SerializeObject(createFoodCommand));


        public class FoodCommandHandlers : IRequestHandler<CreateFoodCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public FoodCommandHandlers(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateFoodCommand createFoodCommand, CancellationToken cancellationToken)
            {
                var food = (Food)createFoodCommand;
                _context.Foods.Add(food);

                await _context.SaveChangesAsync(cancellationToken);

                return food.FoodId;
            }
        }
        public class CreateFoodCommandValidator : AbstractValidator<CreateFoodCommand>
        {
            public CreateFoodCommandValidator()
            {
                RuleFor(food => food.Name)
                                .MaximumLength(200)
                                .NotEmpty();

                RuleFor(food => food.Description)
                                .MaximumLength(400)
                                .Empty();
            }
        }
    }
}
