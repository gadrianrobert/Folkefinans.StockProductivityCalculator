<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StocksControl.ascx.cs" Inherits="Folkefinans.StockProductivityCalculator.Controls.StocksControl" %>


<% if (Stocks != null && Stocks.Any())
    { %>
<table class="table table-hover">
    <thead>
        <tr>
            <th>Name</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>Percentage</th>
            <th>Years</th>
        </tr>
    </thead>
    <tbody>
        <% foreach (var item in Stocks)
            { %>
        <tr>
            <td><%=item.Name %></td>
            <td><%=item.Price %></td>
            <td><%=item.Quantity %></td>
            <td><%=item.Percentage %></td>
            <td><%=item.Years %></td>
        </tr>
        <% } %>
    </tbody>
</table>
<% }
    else
    { %>
<div class="alert alert-info">
    <strong>Info!</strong> There are no stocks to display.
</div>

<% } %>