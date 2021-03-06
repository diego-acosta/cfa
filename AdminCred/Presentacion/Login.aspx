﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title>Simple Login Form In Asp.Net Using C#.Net and VB.Net</title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server" class="form-horizontal">
        <div class="container">
            <br />
            <br />
            <br />
            <br />
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <br />

                        <div class="form-group">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:TextBox ID="txtuserid" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:Button ID="btnlogin" runat="server"
                                    Text="Login" OnClick="btnlogin_Click" CssClass="btn btn-default btn-lg btn-block" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
