<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="Presentacion.DatosPersonales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <br />

        <div class="panel panel-default">
            <div class="panel-body">
                <h3 class="text-warning">Datos Personales</h3>
                <div class="col-md-8">
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Apellido y Nombre" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-5">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"  onkeypress="return validarSoloLetras(event);"></asp:TextBox>
                        </div>
                        <asp:Label ID="lblDni" runat="server" Text="DNI" CssClass="col-md-1 control-label"></asp:Label>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="control-label col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:Label ID="lblProvincia" runat="server" Text="Provincia" CssClass="col-md-3 control-label"></asp:Label>
                                <div class="col-md-3">
                                    <asp:DropDownList ID="ddlProvincia" runat="server" CssClass="selectpicker form-control show-tick" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <asp:Label ID="lblLocalidad" runat="server" Text="Localidad" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-4">
                                    <asp:DropDownList ID="ddlLocalidad" runat="server" CssClass="selectpicker form-control show-tick"></asp:DropDownList>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-group">
                        <div class="panel panel-default">
                            <div class="panel-body">
                                <h4 class="text-warning">Telefonos</h4>
                                <asp:GridView ID="gdvTelefonos" runat="server" EmptyDataText="No existen telefonos registrados" ShowHeaderWhenEmpty="true" >
                                    <Columns>
                                        <asp:BoundField HeaderText="Numero" DataField="numero" HeaderStyle-BackColor="#cccccc" ItemStyle-HorizontalAlign="Center" ControlStyle-Font-Size="Small" HeaderStyle-Width="100" />
                                        <asp:BoundField HeaderText="Comentario" DataField="comentario" HeaderStyle-BackColor="#cccccc" ItemStyle-HorizontalAlign="Center" ControlStyle-Font-Size="Small" HeaderStyle-Width="100" />
                                        <asp:ButtonField Text="Editar" CommandName="select" HeaderStyle-BackColor="#cccccc" />
                                        <asp:ButtonField Text="Borrar" CommandName="delete" HeaderStyle-BackColor="#cccccc" />
                                    </Columns>
                                </asp:GridView>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <div class="form-group">
                                            <div class="col-md-6">
                                                <asp:TextBox ID="txtTelefono" runat="server" Visible="false" CssClass="form-control" placeholder="Telefono"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox ID="txtComentario" runat="server" Visible="false" CssClass="form-control" placeholder="Comentario"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-md-10 col-md-offset-1">
                                                <asp:Button ID="btnAgregarTelefono" runat="server" Text="Agregar" CssClass="btn btn-default btn-lg btn-block" OnClick="btnAgregarTelefono_Click" />
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>

                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class="panel panel-default">
            <div class="panel-body">
                <h3 class="text-warning">Datos Laborales</h3>
                <div class="col-md-8">
                    <div class="form-group">
                        <asp:Label ID="lblTrabajo" runat="server" Text="Lugar de trabajo" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtTrabajo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDireccionLaboral" runat="server" Text="Direccion" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="txtDireccionLaboral" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblProvinciaLaboral" runat="server" Text="Provincia" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-3">
                            <asp:DropDownList ID="ddlProvinciaLaboral" runat="server" CssClass="selectpicker form-control show-tick" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <asp:Label ID="lblLocalidadLaboral" runat="server" Text="Localidad" CssClass="col-md-2 control-label"></asp:Label>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlLocalidadLaboral" runat="server" CssClass="selectpicker form-control show-tick"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblAntiguedad" runat="server" Text="Antiguedad" CssClass="col-md-3 control-label"></asp:Label>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtAntiguedad" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class="col-md-2 col-md-offset-5">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success btn-lg btn-block" OnClick="btnGuardar_Click"/>
        </div>
    </div>
</asp:Content>
