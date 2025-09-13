using System.Threading;
using System.Threading.Tasks;
using Soenneker.Quark.Steps.Abstract;
using Soenneker.Blazor.Utils.ResourceLoader.Abstract;
using Soenneker.Utils.AsyncSingleton;

namespace Soenneker.Quark.Steps;

///<inheritdoc cref="IStepsInterop"/>
public sealed class StepsInterop : IStepsInterop
{
    private readonly AsyncSingleton _cssInitializer;

    private const string _cssPath = "_content/Soenneker.Quark.Steps/css/steps.css";

    public StepsInterop(IResourceLoader resourceLoader)
    {
        _cssInitializer = new AsyncSingleton(async (token, arg) =>
        {
            await resourceLoader.LoadStyle(_cssPath, cancellationToken: token);
            return new object();
        });
    }

    public ValueTask Initialize(CancellationToken cancellationToken = default)
    {
        return _cssInitializer.Init(cancellationToken);
    }

    public ValueTask DisposeAsync()
    {
        return _cssInitializer.DisposeAsync();
    }
}
