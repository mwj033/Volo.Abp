using JetBrains.Annotations;

namespace Volo.Abp.DependencyInjection
{
    public interface IObjectAccessor<out T>
    {
        [CanBeNull]
        T Value { get; }
    }
}

//C# 泛型修饰符in 和 out,用于interface和delegate中，
//用来支持逆变和协变（in是逆变，out是协变）
// 1. 协变中的泛型T只能用于函数返回值
// 2. 逆变则相反 ,只能用于参数值
/*
class Base
{
}

class Derive : Base
{
}

interface ITest<out T>
{
    T GetInstance();

    //void ShowMe(T obj);  报错
}
interface ITest2<in T>
{
    //T GetInstance(); 报错

    void ShowMe(T obj); 
}
class A : ITest<Derive>
{
    public Derive GetInstance()
    {
        throw new System.NotImplementedException();
    }
}
class B : ITest<Base>
{
    public Base GetInstance()
    {
        throw new System.NotImplementedException();
    }
}
class C<T> : ITest<T>
{
    public T GetInstance()
    {
        throw new System.NotImplementedException();
    }
}
*/
