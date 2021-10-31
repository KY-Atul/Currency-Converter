<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Currency.aspx.cs" Inherits="Currency_Converter.Currency" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table>
                    <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"><h3>Currency Converter</h3></td>
                        <td style="text-align:center"></td>
                    </tr>

                    <tr>
                        <td style="text-align:center"><asp:DropDownList ID="ddlfrom" runat="server" OnSelectedIndexChanged="ddlfrom_SelectedIndexChanged" AutoPostBack="true" BackColor="#CCCCCC"></asp:DropDownList></td>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"><asp:DropDownList ID="ddlto" runat="server" OnSelectedIndexChanged="ddlto_SelectedIndexChanged" AutoPostBack="true" BackColor="#CCCCCC"></asp:DropDownList></td>
                    </tr>

                    <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                    </tr>

                    <tr>
                        <td style="text-align:center"><asp:Label ID="lblfrom" runat="server" Font-Bold="true" ForeColor="Blue"></asp:Label></td>
                        <td style="text-align:center; font-size:large; color: #9900CC;">++--Conversion--++</td>
                        <td style="text-align:center"><asp:Label ID="lblto" runat="server" Font-Bold="true" ForeColor="Blue"></asp:Label></td>
                    </tr>

                    <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                    </tr>

                     <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                    </tr>

                     <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"></td>
                    </tr>

                    <tr>
                        <td style="text-align:center"><asp:Textbox ID="txtfrom" runat="server" placeholder="Input Amount" ValidationGroup="pop"></asp:Textbox></td>
                        <td style="text-align:center"><asp:Button ID="btnconvert" runat="server" Text="Convert" OnClick="btnconvert_Click" ValidationGroup="pop" /></td>
                        <td style="text-align:center"><asp:Textbox ID="txtto" runat="server" placeholder="Answer"></asp:Textbox></td>
                        <asp:RequiredFieldValidator ID="rfd" runat="server" ControlToValidate="txtfrom" Display="None" ErrorMessage="Please enter currency for conversion" ValidationGroup="pop" ></asp:RequiredFieldValidator>                    
                    </tr>

                    <tr>
                        <td style="text-align:center"></td>
                        <td style="text-align:center"><asp:Button ID="btnclr" runat="server" Text="CLR" OnClick="btnclr_Click" /></td>
                        <td style="text-align:center"></td>
                    </tr>

                     <tr>
                        <td style="text-align:center"><asp:HyperLink ID="hlinfo" runat="server" Text="Info" Font-Bold="True" ForeColor="Violet" NavigateUrl="~/Info_page.aspx" Target="_blank"></asp:HyperLink></td>
                        <td style="text-align:center"><asp:Button ID="btnprevious" runat="server" Text="View Previous Conversions" OnClick="btnprevious_Click" /></td>
                        <td style="text-align:center"><asp:Label ID="lblonoff" runat="server" Text="Off" ForeColor="Red" Font-Bold="true"></asp:Label></td>
                    </tr>

                </table>

                <table>
                    <tr>
                        <td></td>
                        <td><asp:GridView ID="grd" runat="server" AutoGenerateColumns="False" OnRowCommand="grd_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" BorderColor="Black" BorderStyle="Groove">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="FROM Currency">
                                    <ItemTemplate>
                                        <%#Eval("curr_name") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Input">
                                    <ItemTemplate>
                                        <%#Eval("input_curr") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="TO Currency">
                                    <ItemTemplate>
                                        <%#Eval("curr_name2") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Conversion">
                                    <ItemTemplate>
                                        <%#Eval("converted_value") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btndelete" runat="server" CommandArgument='<%#Eval("cid")%>' CommandName="_delete_" Text="Delete" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnredo" runat="server" CommandArgument='<%#Eval("cid")%>' CommandName="_redo_" Text="Redo" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>


                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />

                            </asp:GridView></td>
                        <td></td>
                    </tr>
                    <asp:ValidationSummary ID="vs" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="pop" />
                </table>
            </center>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
