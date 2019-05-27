<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RavenMail._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <script>
    //$(function () {
    //    $.ajax({
    //        dataType: "json",
    //        type: "GET",
    //        url: "http://localhost:53568",
    //        success: function (dados) {
    //            $(dados).each(function (i) {
    //                document.writeln("<p>Nome: " + dados[i].IdContratante + " | URL: " + dados[i].IdPrestador + "</p>")
    //            });
    //        }
    //    });
    //});
        $(document).ready(function () {
            $.get("http://localhost:53568/Default.aspx", function (data) {
                console.log(data.d.IdContratante);
            });
        });
</script>

    <asp:Label Text="" runat="server" id="respostaEnvioLabel"/>
    
</asp:Content>
