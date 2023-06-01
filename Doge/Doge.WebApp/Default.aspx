<%@ Page Title="Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Doge.WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Orders list</h2>
        <script>setTimeout('window.location.href = window.location.href', 1000);</script>
        <div id="ordersContainer" class="Box">
            <% foreach(Doge.Model.Order ord in ordersList) {%>
            <div style="width:700px;height:auto;border:0px solid #000; background-color:darkgrey">
                <% var difference = (new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(ord.RequiredShippedTimestamp)) - (DateTime.Now);%>
                <h3><%=  ord.OrderId%> </h3>
                <%
                if(difference>TimeSpan.Zero)
                {%>

                <p style="color:green; font-size:20px">ON TIME</p>

                <% } 
                else 
                {
                %>
                <p style="color:red; font-size:20px">DELAYED</p>
                <% } %>
                
                
                <h4>Ship To:  <%=  ord.Address%> </h4>
                
                <%
                if(difference>TimeSpan.Zero)
                {%>

                <h4>Time left:  <%= difference.Days %> days   <%= difference.Hours %> hours  <%= difference.Minutes %> minutes  <%= difference.Seconds %> seconds</h4>

                <% } 
                else 
                {
                %>
                <h4>Time left:  0 days  0 hours  0 minutes  0 seconds</h4>
                <% } %>
                

            </div>
              
            <%}%>
        </div>
    </div>
</asp:Content>
