using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProCodeIT.Extensions.Linq
{
    public static class List
    {
        /// <summary>
        /// Aplica a condição de filtragem caso a condição seja verdadeira.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">Fonte de dados.</param>
        /// <param name="condition">Condição que determinará se a filtragem será aplicada.</param>
        /// <param name="predicate">Expressão de filtragem.</param>
        /// <returns></returns>
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            if (condition)
            {
                return source.Where(predicate);
            }
            else
            {
                return source;
            }
        }

        /// <summary>
        /// Aplica a condição de filtragem caso a condição seja verdadeira.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">Lista de dados.</param>
        /// <param name="condition">Condição que determinará se a filtragem será aplicada.</param>
        /// <param name="predicate">Expressão de filtragem.</param>
        /// <returns></returns>
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
        {
            if (condition)
            {
                return source.Where(predicate);
            }
            else
            {
                return source;
            }
        }
    }
}
