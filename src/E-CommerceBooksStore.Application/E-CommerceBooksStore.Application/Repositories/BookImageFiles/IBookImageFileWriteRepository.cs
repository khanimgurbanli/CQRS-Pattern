﻿using E_CommerceBooksStore.Application.Base;
using s = E_CommerceBooksStore.Domain.Entities;

namespace E_CommerceBooksStore.Application.Repositories.BookImageFiles
{
    public interface IBookImageFileWriteRepository : IWriteRepository<s.File> {}
}
