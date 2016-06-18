<%@ Page Title="View calculated result" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCalculatedResult.aspx.cs" Inherits="Folkefinans.StockProductivityCalculator.Pages.ViewCalculatedResult" %>

<%@ Register Src="~/Controls/StocksControl.ascx" TagPrefix="uc1" TagName="StocksControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <uc1:StocksControl runat="server" ID="StocksControl" />
    
    <div id="productivityContainer"></div>

    <%: Scripts.Render("~/Scripts/stocks.js") %>
</asp:Content>
