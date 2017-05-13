<%@ Page Title="" Language="C#" MasterPageFile="~/Postlogin.Master" AutoEventWireup="true" CodeBehind="docs.aspx.cs" Inherits="PatientApp.docs" %>
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
                <div class="col-md-12">
                    <div class="row">
                        <div class="panel-group">
                          <div class="panel panel-default">
                            <div class="panel-heading">
                              <h4 class="panel-title">
                                <a data-toggle="collapse" href="#collapse1">Add New Doctor</a>
                              </h4>
                            </div>
                            <div id="collapse1" class="panel-collapse collapse">
                              <div class="panel-body">
                                  <form id="form1" runat="server">
                        
                                    <div class="form-group col-md-6">
                                        <label for="dname">Doctor Name:</label>
                                        <asp:TextBox ID="dname" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="email">Specialty:</label><br />
                                        <asp:DropDownList CssClass="form-control" required="" ID="spec" runat="server"
                                              AppendDataBoundItems="true">
                                            <asp:ListItem Value="">Select</asp:ListItem>
                                            <asp:ListItem Value="Addiction Psychiatry">Addiction Psychiatry</asp:ListItem>
                                            <asp:ListItem Value="Pediatric">Pediatric</asp:ListItem>
                                            <asp:ListItem Value="Dermatology">Dermatology</asp:ListItem>
                                            <asp:ListItem Value="Family Medicine">Family Medicine</asp:ListItem>
                                            <asp:ListItem Value="Orthopaedics">Orthopaedics</asp:ListItem>
                                            <asp:ListItem Value="Neonatal-Perinatal Medicine">Neonatal-Perinatal Medicine</asp:ListItem>
                            
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">eMail:</label>
                                        <asp:TextBox ID="email" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">Office Address:</label>
                                        <asp:TextBox ID="office" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">Username:</label>
                                        <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label for="email">Password:</label>
                                        <asp:TextBox TextMode="Password" ID="pass" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group col-md-12">
                                        <br />
                                        <asp:Button ID="Button1" CssClass="btn btn-primary col-lg-12" runat="server" Text="Add New Doctor" OnClick="Button1_Click" />
                                    </div>
                                  </form>
                              </div>
                            </div>
                          </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="row">
                        <div class="panel-group">
                          <div class="panel panel-default">
                            <div class="panel-heading">
                              <h4 class="panel-title">
                                <a data-toggle="collapse" href="#">Doctor Records</a>
                              </h4>
                            </div>
                            <div id="collapse2" class="panel-collapse collapse in">
                              <div class="panel-body">
                                  <asp:Literal
                                        ID='LiteralGo' 
                                        runat="server"  
                                        Text="">
                                  </asp:Literal>
                                  <asp:Literal
                                        ID='LiteralInfo' 
                                        runat="server"  
                                        Text=" ">
                                  </asp:Literal>
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
