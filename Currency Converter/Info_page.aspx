<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info_page.aspx.cs" Inherits="Currency_Converter.Info_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table border="1">
                    <tr>
                        <td style="text-align:center"><h1>Info</h1></td>
                        <td><h3>Browser Static Currency Converter</h3></td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">From DropDown:</td>
                        <td>Choose curency</td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">To DropDown:</td>
                        <td>Choose currency</td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">From Textbox:</td>
                        <td>Enter amount of currency to be converted</td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">Convert Button:</td>
                        <td>Convert currency and show it in to textbox and add data to database</td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">CLR Button:</td>
                        <td>Clear all selections and remove display of data from database</td>
                    </tr>

                    <tr>
                        <td style="text-align:center; color:brown">View Previsions Conversions Button:</td>
                        <td>Show data from database</td>
                    </tr>

                </table>

                <br>
                <br>

                <table>
                    <tr>
                        <td></td>
                        <td><asp:HyperLink ID="hlbacktoconverter" runat="server" Target="_parent" NavigateUrl="~/Currency.aspx" Text="Back to Converter"></asp:HyperLink></td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
