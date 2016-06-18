<%@ Page Title="Enter stock details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterStockDetails.aspx.cs" Inherits="Folkefinans.StockProductivityCalculator.Pages.EnterStockDetails" %>

<%@ Register Src="~/Controls/ProductivityControl.ascx" TagPrefix="uc1" TagName="ProductivityControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h2>Stock Information</h2>
        <table class="table table-hover">
            <thead>
                <tr>
                    <th>Field</th>
                    <th>Value</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Stock name</td>
                    <td>
                        <asp:TextBox ID="tbName" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Stock name is required." ControlToValidate="tbName" Display="Dynamic" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="tbPrice" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Price is required." ControlToValidate="tbPrice" Display="Dynamic" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="vdPrice" runat="server" ErrorMessage="Price should have a number format." ControlToValidate="tbPrice" Display="Dynamic" ValidationGroup="AllValidators" ValidationExpression="^\d+(.\d{1,2})?">Invalid format!</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Quantity</td>
                    <td>
                        <asp:TextBox ID="tbQuantity" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Quantity is required." ControlToValidate="tbQuantity" Display="Dynamic" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="vdQuantity" runat="server" ErrorMessage="Quantity should have a number format." ControlToValidate="tbQuantity" Display="Dynamic" ValidationGroup="AllValidators" ValidationExpression="\d+">Invalid format!</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Percentage</td>
                    <td>
                        <asp:TextBox ID="tbPercentage" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Percentage is required." ControlToValidate="tbPercentage" Display="Dynamic" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="vdPercentage" runat="server" ErrorMessage="Percentage should have a number format." ControlToValidate="tbPercentage" Display="Dynamic" ValidationGroup="AllValidators" ValidationExpression="^\d+(.\d{1,2})?">Invalid format!</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Years</td>
                    <td>
                        <asp:TextBox ID="tbYears" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Years is required." ControlToValidate="tbYears" Display="Dynamic" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="vdYears" runat="server" ErrorMessage="Years should have a number format." ControlToValidate="tbYears" Display="Dynamic" ValidationGroup="AllValidators" ValidationExpression="\d+">Invalid format!</asp:RegularExpressionValidator>
                    </td>
                </tr>
            </tbody>
        </table>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CssClass="btn btn-primary btn-lg" OnClick="btnCalculate_Click" ValidationGroup="AllValidators" />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        
        <uc1:ProductivityControl runat="server" ID="ProductivityControl" />
    </div>

</asp:Content>
