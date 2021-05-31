<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BankSystem.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="data" runat="server">

     <main>

        <div class="container mt-5 col-md-4">

            <div class="mb-3">
                <label for="PresentmentHeaderNo" class="form-label">Presentment Header No</label>
                <input type="text" class="form-control" id="PresentmentHeaderNo" >
            </div>

            <div class="mb-3">
                <label for="BankName" class="form-label">Bank Name</label>
                <input type="text" class="form-control" id="BankName" >
            </div>

            <div class="mb-3">
                <label for="Date" class="form-label">Date</label>
                <input type="date" class="form-control" id="Date">
            </div>

            <div class="mb-3">

                <div class="form-check form-switch d-inline-block">
                    <input class="form-check-input" type="checkbox" id="IsActive">
                    <label for="IsActive" class="form-label">Active</label>
                </div>

                <div class="form-check form-switch d-inline-block">
                    <input class="form-check-input" type="checkbox" id="IsDeleted">
                    <label for="IsDeleted" class="form-label">Deleted</label>
                </div>

            </div>

            <div class="text-center">
                <button class="btn btn-success" id="Submit">Submit</button>
            </div>
           
        </div>
        
    </main>

</asp:Content>
