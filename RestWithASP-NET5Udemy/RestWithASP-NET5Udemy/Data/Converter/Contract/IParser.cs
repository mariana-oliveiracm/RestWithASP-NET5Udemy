
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Data.Converter.Contract
{
    public interface IParser <O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
