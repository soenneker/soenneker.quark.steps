[![](https://img.shields.io/nuget/v/soenneker.quark.steps.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.steps/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.steps/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.steps/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.steps.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.steps/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Quark.Steps
### A comprehensive Blazor component library for step indicators and navigation.

## Installation

```
dotnet add package Soenneker.Quark.Steps
```

## Features

- **Step Navigation**: Clickable steps with built-in navigation
- **State Management**: Automatic step state tracking and management
- **Custom Markers**: Support for custom step markers and icons
- **Content Areas**: Separate content panels for each step
- **Render Modes**: Default, lazy load, and lazy reload rendering options
- **Color Theming**: Built-in color support for step styling
- **Navigation Control**: Optional navigation validation and control
- **Responsive Design**: Works across different screen sizes

## Components

### Steps
The main container component that manages step state and navigation.

```razor
<Steps @bind-SelectedStep="currentStep">
    <Step Name="step1" Caption="@(() => "Personal Information")" />
    <Step Name="step2" Caption="@(() => "Contact Details")" />
    <Step Name="step3" Caption="@(() => "Review")" />
</Steps>
```

### Step
Individual step component with customizable markers and content.

```razor
<Step Name="step1" Color="Color.Primary" Completed="true">
    <Marker>
        <svg><!-- Custom icon --></svg>
    </Marker>
    <Caption>Step Title</Caption>
</Step>
```

### StepPanel
Content panel that displays when its corresponding step is active.

```razor
<StepPanel Name="step1">
    <h3>Step Content</h3>
    <p>This content shows when step1 is selected.</p>
</StepPanel>
```

### StepContent
Separate content area that can be placed anywhere on the page.

```razor
<StepContent @bind-SelectedPanel="selectedPanel">
    <StepPanel Name="info">Information content</StepPanel>
    <StepPanel Name="settings">Settings content</StepPanel>
</StepContent>
```

## Examples

### Basic Steps with Navigation
```razor
<Steps @bind-SelectedStep="currentStep">
    <Step Name="step1" Caption="@(() => "Step 1")" />
    <Step Name="step2" Caption="@(() => "Step 2")" />
    <Step Name="step3" Caption="@(() => "Step 3")" />
</Steps>

<button @onclick="() => currentStep = 'step2'">Go to Step 2</button>
```

### Steps with Content Areas
```razor
<Steps SelectedStep="activeStep">
    <Items>
        <Step Name="info" Caption="@(() => "Information")" />
        <Step Name="settings" Caption="@(() => "Settings")" />
    </Items>
    <Content>
        <StepPanel Name="info">
            <h3>Information Panel</h3>
            <p>Step content here</p>
        </StepPanel>
        <StepPanel Name="settings">
            <h3>Settings Panel</h3>
            <p>Settings content here</p>
        </StepPanel>
    </Content>
</Steps>
```

### Custom Markers
```razor
<Steps>
    <Step Name="step1">
        <Marker>
            <svg width="16" height="16" viewBox="0 0 24 24">
                <path d="M12 2L2 7L12 12L22 7L12 2Z" fill="currentColor"/>
            </svg>
        </Marker>
        <Caption>Custom Step</Caption>
    </Step>
</Steps>
```

### Navigation Control
```razor
<Steps SelectedStep="currentStep" NavigationAllowed="@ValidateNavigation">
    <Step Name="step1" Caption="@(() => "Step 1")" />
    <Step Name="step2" Caption="@(() => "Step 2")" />
</Steps>

@code {
    private bool ValidateNavigation(StepNavigationContext context)
    {
        // Custom validation logic
        return context.NextStepIndex > context.CurrentStepIndex || 
               CanGoBackward(context.NextStepIndex);
    }
}
```

## Properties

### Steps Properties
- `SelectedStep` - Currently selected step name
- `RenderMode` - How steps content is rendered (Default, LazyLoad, LazyReload)
- `NavigationAllowed` - Function to validate step navigation
- `Items` - Template for step items
- `Content` - Template for step content panels

### Step Properties
- `Name` - Unique identifier for the step
- `Index` - Override the step index
- `Completed` - Mark step as completed
- `Color` - Step color theme
- `Marker` - Custom marker content
- `Caption` - Step title/caption content

### StepPanel Properties
- `Name` - Must match corresponding step name
- `ChildContent` - Panel content

## License

MIT License - see [LICENSE](LICENSE) file for details.
