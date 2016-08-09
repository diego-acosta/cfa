<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PruebaWebMethod.aspx.cs" Inherits="Presentacion.PruebaWebMethod" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <script src="Scripts/json2.js"></script>
        <script type="text/javascript">

            $().ready(function () {

                $("#<%=ddlProvincias.ClientID%>").change(function () {

                // armo el objeto que servira de parametro, para ello utilizo una libreria de JSON
                //este parametro mapeara con el definido en el web service
                var params = new Object();
                params.idProvincia = $("#<%=ddlProvincias.ClientID%>").val();
                params = JSON.stringify(params);

                $.ajax({
                    type: "POST",
                    url: "PruebaWebMethod.aspx/GetCiudadesByPais",
                    data: params,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: false,
                    success: LoadCiudades(msg),
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(textStatus + ": " + XMLHttpRequest.responseText);
                    }
                });

            });

            $("#<%=ddlCiudades.ClientID%>").change(function () {
                alert("Ha seleccionado: " + $("#<%=ddlCiudades.ClientID%> :selected").text());
            });

        });

        function LoadCiudades(msg) {
            var datos = $.parseJSON(msg.d);

            $(datos).each(function () {
                var option = $(document.createElement('option'));

                option.text(this.Nombre);
                option.val(this.Codigo);

                $("#<%=ddlCiudades.ClientID%>").append(option);
            });
    }
        </script>
    
    <div class="container">
        <table>
            <tr>
                <td>Paises:</td>
                <td>
                    <asp:DropDownList ID="ddlProvincias" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td>Ciudades:</td>
                <td>
                    <asp:DropDownList ID="ddlCiudades" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>




</asp:Content>
