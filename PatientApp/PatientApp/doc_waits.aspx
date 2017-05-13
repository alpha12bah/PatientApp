﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Postlogin.Master" AutoEventWireup="true" CodeBehind="doc_waits.aspx.cs" Inherits="PatientApp.doc_waits" %>
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
                    <h1 class="section-heading">Welcome Dr. <%=Session["fullname"] %></h1>
                    <p class="lead section-lead">Waiting Patient Appointments.</p>
                    <div class="row">
                        <div class="panel-group">
                          <div class="panel panel-default">
                            <div class="panel-heading">
                              <h4 class="panel-title">
                                <a data-toggle="collapse" href="#">Waiting Patient Appointments</a>
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
