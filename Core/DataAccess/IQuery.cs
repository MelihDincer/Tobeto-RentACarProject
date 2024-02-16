namespace Core.DataAccess;

//
public interface IQuery<T>
{
    //IQueryable, entityframeworkde kullanabildiğimiz daha güzel sorgular yazabildiğimiz bir interface.
    IQueryable<T> Query();
}