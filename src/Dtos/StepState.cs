using Soenneker.Quark.Steps.Enums;

namespace Soenneker.Quark.Steps.Dtos;

/// <summary>
/// Holds the information about the current state of the Steps component.
/// </summary>
public record StepState
{
    /// <summary>
    /// Gets the name of the selected step item.
    /// </summary>
    public string SelectedStep { get; init; } = string.Empty;

    /// <summary>
    /// Gets the steps rendering mode.
    /// </summary>
    public StepRenderMode RenderMode { get; init; } = StepRenderMode.Default;
}
