# ConversionAPI

# Currency Converter API1

A simple **.NET 8** API for converting currency amounts between **USD, INR, and EUR**.  
It uses a local JSON file for exchange rates, with the ability to override via **environment variables** and **refresh dynamically**.

---

## Features

- Convert amounts between USD, INR, EUR
- Exchange rates stored in `exchangeRates.json`
- Environment variable overrides for exchange rates
- Dynamic refresh of exchange rates without restarting the API
- Robust error handling and logging
- Fully tested with **NUnit + Moq**

---

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio, VS Code, or any C# IDE

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/CurrencyConverterAPI.git

