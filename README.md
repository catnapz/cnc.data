# cnc.data
Creatures And Caves Data Layer

Uses [Npgsql Entity Framework Core Provider](https://www.npgsql.org/efcore/#sidetoggle) database-first approach:
```bash
dotnet ef dbcontext scaffold <connection_string> Npgsql.EntityFrameworkCore.PostgreSQL -o Models --context-dir . --no-onconfiguring
```