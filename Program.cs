using SeleniumBot;
using OpenQA.Selenium.DevTools.V112.Page;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var excel = new ReadExcel();
System.Data.DataTable dt_Data = excel.getDTFromExcel(@"C:\Users\xxx\Documents\CoE RPA\01 - CSharp\Estudo\00 - RPA\00 - Automação Teste\SeleniumBot\SeleniumBot\challenge.xlsx");
//Console.ReadLine();

var web = new AutomationWeb();
web.AcessURL("https://www.rpachallenge.com/");
web.FillInData(dt_Data);