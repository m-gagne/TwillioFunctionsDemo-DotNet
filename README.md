# Twillio Azure Function Demo Script

Sample C# code to use to demo [Azure Functions](https://azure.microsoft.com/en-us/services/functions/).

## Setup

- Create new Azure Function
- Click `+ New Function`
  - `Language` > `C#`
  - Click `HttpTrigger-CSharp`
  - Click `Create`
- Upload `run.csx`, `project.json` & `function.json`
- Edit AppSettings by clicking `Function app settings` > `Configure app settings` under `App settings`
    - `TwillioAccountSid`
    - `TwillioAuthToken`
    - `TwillioFromNumber`
