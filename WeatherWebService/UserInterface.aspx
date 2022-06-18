<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInterface.aspx.cs" Inherits="WeatherWebService.UserInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 373px;
        }
        #Button1 {
            height: 28px;
            margin-left: 94px;
            margin-right: 22px;
        }
        #Text2 {
            width: 369px;
            margin-left: 14px;
        }
        #form1 {
            height: 668px;
        }
        .auto-style1 {
            width: 259px;
            height: 231px;
        }
        div{
            display:inline-block;
        }
        .newStyle1 {
            font-family: "Comic Sans MS";
        }
        .newStyle2 {
            font-family: "Comic Sans MS";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div style="width: 316px; height: 399px; margin-top: 0px;">

           <br />
           <br />
           <img alt="Weather Icon" class="auto-style1" src="Assets/Imgs/weather-icon-png-15.png" /><br />

       </div>
         <div style="height: 400px; width: 500px; margin-top: 0px;" class="newStyle2">
             <blockquote>
            <strong><span class="newStyle1">Hello, Please enter your city</span></strong></blockquote>
            <strong>City :</strong>
            <asp:TextBox ID="City_Text" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="GetWeatherBTN" runat="server" Font-Names="Comic Sans MS" OnClick="Button1_Click" Text="Get Weather" BackColor="#0099FF" ForeColor="White" />
            <br />
            <br />
            <strong>Country :</strong>
            <asp:Label ID="CountryLBL" runat="server"></asp:Label>
            <br />
            <br />
            <strong>Region :</strong>
            <asp:Label ID="RegionLBL" runat="server"></asp:Label>
            <br />
            <br />
            <strong>Current Date :</strong>
            <asp:Label ID="TimeLBL" runat="server"></asp:Label>
            <br />
            <br />
            <strong>Status :</strong>
            <asp:Label ID="StatusLBL" runat="server"></asp:Label>
            <br />
            <br />
            <strong>Temperature :</strong><asp:Label ID="TempLBL" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="ErrorLBL" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
    </body>
</html>
