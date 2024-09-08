namespace API.Persistance
{
    public class ApiDbContext : MDbContext
    {
        public ApiDbContext(DbContextOptions options)
            : base(options, new NoMediator())
        {
        }

        public ApiDbContext(DbContextOptions options, IMediator mediator)
            : base(options, mediator)
        {
        }
    }
}