using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.DataAccess;

//IAsyncRepository => arayüz 
//IQuery => IQueryable türünde bir metodun imzasını tanımladığımız bir interface.
//Interface interface'i extend eder. Implement etmez.
public interface IAsyncRepository<TEntity, TEntityId> : IQuery<TEntity>
    where TEntity : BaseEntity<TEntityId>
{
    //Modeldeki ilişkili tablolarda join işlemi için IIncludableQueryable interface ini kullandık.
    //Task asenkron yapının kullanılabilmesine olanak sağlar.
    //predicate = null   :> filtreleme işlemi null olabilir demek istedik. GetAll da kullandık çünkü orada bir şart olmayabilir tüm verileri listeleyebiliriz. Aşağıdaki get metodunda kullanmamamızın sebebi her türlü bir şartın geçmesi durumu olduğu için. Getirilecek veri bir şarta göre bir tane olacak şekilde gelecek sonuçta.(Çünkü List değil)
    Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);//Gelen veriler null olabilir diye "?" kullandık.
    Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null); //Gelen veriler null olabilir diye "?" kullandık.

    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task<TEntity> Delete(TEntity entity);
}