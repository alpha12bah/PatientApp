<%@ Page Title="" Language="C#" MasterPageFile="~/Postlogin.Master" AutoEventWireup="true" CodeBehind="appointment.aspx.cs" Inherits="PatientApp.appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='col-md-12'>
        <asp:Literal
            ID='LiteralMsg' 
            runat="server"  
            Text="">
        </asp:Literal>
    </div>
    <!-- Content Section -->
    <section>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="section-heading">Welcome <%=Session["username"] %></h1>
                    <p class="lead section-lead">Appointment Requests.</p>
                    <div class="row">
                        <div class="panel-group">
                          <div class="panel panel-default">
                            <div class="panel-heading">
                              <h4 class="panel-title">
                                <a data-toggle="collapse1" href="#">New Appointment Request</a>
                              </h4>
                            </div>
                            <div id="collapse1" class="panel-collapse collapse in">
                              <div class="panel-body">
                                  <form id="form1" runat="server">
                                    <div class="form-group col-md-4">
                                        <label for="email">Apt. ID:</label>
                                        <asp:TextBox ID="aid" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-md-8">
                                        <label for="email">Patient Name:</label>
                                        <asp:TextBox ID="pname" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-lg-4">
                                        <label for="email">Day:</label>
                                        <asp:TextBox ID="day" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-lg-4">
                                        <label for="email">Date:</label>
                                        <asp:TextBox ID="date" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-lg-4">
                                        <label for="email">Time:</label>
                                        <asp:TextBox ID="time" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-lg-12">
                                        <br />
                                        <asp:Button ID="Button1" CssClass="btn btn-primary col-lg-12" runat="server" Text="Close Appointement Request" OnClick="Button1_Click" />
                                    </div>
                                    
                                  </form>
                              </div>
                            </div>
                          </div>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
    </section>
</asp:Content>
