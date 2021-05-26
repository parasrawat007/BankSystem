<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankSystem.WebForm1" %>

<asp:Content runat="server" ContentPlaceHolderID="data" id="form">

    <div class="container-fluid mt-3">
    <table id="TransPresentmentHeader" class="table table-hover">
        <thead>
            <tr>
                <th>TransHeadId</th>
                <th>FileNo</th>
                <th>Date</th>
                <th>BankName</th>
                <th>IsActive</th>
                <th>IsDeleted</th>
                <th>CreatedOn</th>
                <th>PresentmentHeaderNo</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
        </div>
</asp:Content>

