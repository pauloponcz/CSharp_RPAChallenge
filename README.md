# Selenium Automation with C# #

This is a C# automation project that utilizes the Selenium library to automate interactions with web pages. The primary functionality of this project is to read data from an Excel file containing information about individuals and then use this data to fill out a web form.

## Overview ##

Automation is a crucial task in many business and software development scenarios. In this project, we harness the power of the Selenium library to automate repetitive tasks involving web page interactions. Specifically, this project handles the following functionality:

1. **Reading Data from Excel**: We use a C# Excel sheet reading library to extract information from an Excel file containing data about individuals. This data may include names, addresses, phone numbers, emails, among other details.

2. **Automated Form Filling**: Based on the data read from Excel, the project uses Selenium to navigate to a web page containing a form. It then automatically populates the form fields with the information read from Excel, such as names, addresses, and other relevant details.

3. **Form Submission**: After filling out the form, the automation submits the data, successfully completing the form-filling process.

## Prerequisites ##

To run this project in your environment, you'll need to have the following dependencies installed:

- [.NET Core](https://dotnet.microsoft.com/download/dotnet)
- [Selenium WebDriver](https://www.selenium.dev/documentation/en/webdriver/driver_requirements/)

## How to Use ##

1. Clone this repository to your local machine.
2. Ensure that the prerequisites are installed.
3. Configure the path to the Excel file containing people's data in the source code if necessary.
4. Run the project.

## Contribution ##

Contributions to improve this project are welcome! Feel free to open issues or submit pull requests with enhancements, bug fixes, or new features.

## License ##

This project is licensed under the **Community License**. You are free to use, modify, and distribute the code as per the terms of the Community License.

---

This project serves as a demonstration of how to use Selenium in conjunction with C# to automate form-filling tasks with data sourced from an Excel file. We hope this project proves helpful in simplifying automation tasks in your workplace or personal projects.
