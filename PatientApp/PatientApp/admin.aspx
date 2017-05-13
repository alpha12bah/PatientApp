<%@ Page Title="" Language="C#" MasterPageFile="~/Postlogin.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="PatientApp.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Content Section -->
    <section>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="section-heading">Administrator Page </h1>
                    <p class="lead section-lead">Welcome Back, <%=Session["username"] %>.</p>
                    <p class="section-paragraph">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid, suscipit, rerum quos facilis repellat architecto commodi officia atque nemo facere eum non illo voluptatem quae delectus odit vel itaque amet.</p>
                    <div class="row">
                      <div class="col-md-4">
                        <a class="thumbnail" href="/adm_pat.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>Patients</p>
                      </div>          
                      <div class="col-md-4">
                        <a class="thumbnail" href="/docs.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>Doctors</p>
                      </div>
                      <div class="col-md-4">
                        <a class="thumbnail" href="/adm_apt.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                        <p>Appointments</p>
                      </div>        
                   </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
