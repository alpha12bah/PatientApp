<%@ Page Title="" Language="C#" MasterPageFile="~/Postlogin.Master" AutoEventWireup="true" CodeBehind="patient.aspx.cs" Inherits="PatientApp.patient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Content Section -->
    <section>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="section-heading">Welcome <%=Session["username"] %></h1>
                    <p class="lead section-lead">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                    <div class="row">
                      <div class="col-md-4">
                        <a class="thumbnail" href="/pat_apt.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>My Appointments</p>
                      </div>          
                      <div class="col-md-4">
                        <a class="thumbnail" href="/pat_req.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>My Requests</p>
                      </div>
                      <div class="col-md-4">
                        <a class="thumbnail" href="/doctors.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>Doctors</p>
                      </div>        
                   </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
