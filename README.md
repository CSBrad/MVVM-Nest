# MVVM Nest - Starter Template

Welcome to the MVVM Nest Starter Template! This project provides a clean and organized starting point for developing MVVM (Model-View-ViewModel) applications in WPF (Windows Presentation Foundation). It includes a basic setup with commands, styles, and sample views to help you get started quickly.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Customization](#customization)
- [Contributing](#contributing)
- [License](#license)
- [.NET Version](#net-version)

## Features

- **MVVM Pattern**: Implements the MVVM pattern to separate concerns.
- **Command Implementation**: Includes a `RelayCommand` class for easy command binding.
- **Basic Styles**: Includes a style template for colors and brushes.
- **Sample Views**: Provides example views with switching functionality between first names and last names.

## Getting Started

To get started with the MVVM Nest template, follow these steps:

1. **Clone the Repository**

   `git clone https://github.com/yourusername/MVVM-Nest.git`

2. **Open the Project**

   Open the solution file (`MVVM-Nest.sln`) in Visual Studio or your preferred IDE.

3. **Build the Solution**

   Build the solution to restore NuGet packages and compile the project.

4. **Run the Application**

   Start the application to see the initial view.

## Project Structure

Here’s an overview of the project structure:


```
MVVM-Nest/
│
├── Services/
│   └── Commands/
│       └── RelayCommand.cs
│
├── Model/
│   └── Person.cs
│
├── ViewModel/
│   ├── BaseViewModel.cs
│   └── PersonViewModel.cs
│
├── View/
│   └── MainWindow.xaml
│
├── Assets/
│   └── Resources/
│       └── Styles.xaml
│
└── App.xaml
```


- **Commands**: Contains command implementations like `RelayCommand`.
- **Models**: Contains data models (e.g., `Person`).
- **ViewModels**: Contains ViewModel classes (e.g., `PersonViewModel`, `BaseViewModel`).
- **Views**: Contains XAML files for the views (e.g., `MainWindow.xaml`).
- **Assets/Resources**: Contains styles and other resources.

## Usage

### Switching Views

The `MainWindow.xaml` provides two buttons to toggle between showing first names and last names:

- **Show First Names**: Displays only the first names of people.
- **Show Last Names**: Displays only the last names of people.

### Modifying Styles

You can customize the styles by editing `Styles.xaml` located in the `Assets/Resources` folder. Adjust color codes and brushes to fit your application's design.

## Customization

### Adding New ViewModels

1. Create a new class in the `ViewModels` folder.
2. Inherit from `BaseViewModel` and implement the necessary properties and commands.
3. Update `MainWindow.xaml` or other views to bind to your new ViewModel.

### Adding New Models

1. Create a new class in the `Models` folder.
2. Define the properties and methods needed for your new model.
3. Update your ViewModels and Views to include and use the new model.

## Contributing

We welcome contributions to the MVVM Nest project! If you have suggestions, improvements, or bug fixes, please follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Make your modifications and commit them.
4. Submit a pull request with a description of your changes.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## .NET Version

This project is developed using .NET 8.0. Ensure you have the appropriate version of .NET installed to build and run the project.
