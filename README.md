# CV Analyser

A Windows desktop application designed to analyze and rank CVs (resumes) based on keyword matching and relevance scoring. The application helps recruiters and HR professionals quickly filter and identify the most suitable candidates from a pool of resumes.

## Features

- **Multiple CV Analysis**: Process multiple CVs in PDF format simultaneously
- **Keyword-based Ranking**: Automatically rank CVs based on keyword relevance
- **Customizable Weighting**: Adjust the importance of different sections in the CV
- **Result Export**: Save filtered CVs to a specified directory
- **User-friendly Interface**: Intuitive Windows Forms interface for easy navigation
- **Database Integration**: Local SQL database for storing and managing CV data

## System Requirements

- Windows 7 or later
- .NET Framework 4.7.2 or later
- Microsoft SQL Server Express LocalDB (included in Visual Studio)

## Installation

1. Clone or download the repository
2. Open the solution file `CV_Analyser.sln` in Visual Studio 2019 or later
3. Restore NuGet packages if prompted
4. Build the solution (Ctrl+Shift+B)

## Usage

1. **Launch the Application**
   - Run the application from Visual Studio or the compiled executable

2. **Load CVs**
   - Click on "Open Folder" to select a directory containing CVs in PDF format
   - The application will process and index all PDF files in the selected directory

3. **Set Analysis Parameters**
   - Enter relevant keywords in the "Keywords" field (comma-separated)
   - Adjust the ranking threshold using the slider
   - Toggle case sensitivity if needed

4. **Analyze and View Results**
   - Click "Analyze" to process the CVs
   - View the ranked list of candidates in the results grid
   - Click on a CV to see detailed analysis and scoring

5. **Export Results**
   - Click "Save Results" to export the filtered CVs to a specified directory
   - CVs will be renamed with their ranking position for easy reference

## Project Structure

```
CV-Analyser/
├── Data/                # Database and data access layer
│   ├── Analyser_DB.mdf  # SQL Server database file
│   ├── Query_Account.cs # Account-related database queries
│   └── Query_Resume.cs  # Resume-related database queries
├── Engine/              # Core business logic
│   ├── App.cs          # Application configuration
│   ├── Check.cs        # Input validation
│   ├── Mail.cs         # Email functionality
│   └── Resume.cs       # Resume processing logic
├── Interface/           # UI components
│   ├── Account/        # Account management forms
│   ├── Analyser/       # Main application form
│   ├── Entry/          # Login/registration forms
│   └── Password/       # Password management forms
└── Properties/         # Application properties and resources
```

## Development Setup

1. **Prerequisites**
   - Visual Studio 2019 or later
   - .NET Desktop Development workload
   - Data storage and processing workload

2. **Database Setup**
   - The application uses LocalDB by default
   - Database file is located in the `Data` folder
   - Connection string is configured in `App.config`

3. **Building the Project**
   - Open the solution in Visual Studio
   - Restore NuGet packages
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5)

## Dependencies

- iTextSharp - For PDF text extraction
- System.Data.SqlClient - For database operations
- System.Drawing - For image processing
- System.Windows.Forms - For the user interface

## Contributing

Contributions are welcome! Here's how you can help:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

For support or questions, please open an issue in the repository.

## Acknowledgments

- Thanks to all contributors who have helped improve this project
- Special thanks to the open-source community for the libraries used in this project