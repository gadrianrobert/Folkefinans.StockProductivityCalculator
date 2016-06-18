<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductivityControl.ascx.cs" Inherits="Folkefinans.StockProductivityCalculator.Controls.ProductivityControl" %>

<% if (Productivity != null && Productivity.Any())
    { %>
<table class="table table-hover">
    <thead>
        <tr>
            <th>Year</th>
            <th>Value</th>
        </tr>
    </thead>
    <tbody>
        <% foreach (var item in Productivity)
            { %>
        <tr>
            <td><%=item.Year %></td>
            <td><%=item.Value %></td>
        </tr>
        <% } %>
    </tbody>
</table>
<% }
    else
    { %>
<%--<div class="alert alert-info">
    <strong>Info!</strong> There is no information to display.
</div>--%>

<% } %>