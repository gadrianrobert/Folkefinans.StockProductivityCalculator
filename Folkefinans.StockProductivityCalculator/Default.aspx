<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Folkefinans.StockProductivityCalculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p><a runat="server" href="~/Pages/EnterStockDetails" class="btn btn-primary btn-lg btn-block">Enter stock details</a></p>
        <p><a runat="server" href="~/Pages/EnterStockDetails" class="btn btn-primary btn-lg btn-block">View calculated result</a></p>
    </div>

</asp:Content>
