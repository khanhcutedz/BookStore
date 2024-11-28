using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService :
        CrudAppService<
        Book,
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDto
        >,
        IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository) : base(repository)
        {

        }
    }
    /*
        public class BookAppService : BookStoreAppService, IBookAppService
        {
            private readonly IDapperRepository<Book, long> _dapperRepo;
            private readonly IRepository<Book, long> _repo;
        }

        public async Task<PagedResultDto<BookDto>> GetAll(GetBookInput input)
        {
            string _sql = "Exec INV_GPS_PARTLIST_BY_CATEGORY_SEARCH @p_Item, @p_Category, @p_Location, @p_PartType";

            IEnumerable<BookDto> result = await _dapperRepo.QueryAsync<BookDto>(_sql, new
            {
                p_Item = input.Item,
                p_Category = input.Category,
                p_Location = input.Location,
                p_PartType = input.PartType,
            });

            var listResult = result.ToList();

            var pagedAndFiltered = listResult.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

            var totalCount = result.ToList().Count();

            return new PagedResultDto<BookDto>(totalCount, pagedAndFiltered);
        }*/
}
