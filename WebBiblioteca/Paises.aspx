<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="WebBiblioteca.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Lista de paises
    </h2>
    <br />
    <div style="margin-left: 40px">
     
        <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblPais" runat="server" Text="Pais:"></asp:Label>
     
       <asp:TextBox ID="txtNombre" runat="server" Height="16px"></asp:TextBox>
        <asp:Button ID="btnEnviar" runat="server" Height="24px" Text="Nuevo Pais" Width="87px" OnClick="btnEnviar_Click" />
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        <asp:Button ID="btnModif" runat="server" Text="Modificar" OnClick="btnModif_Click" />
        <asp:GridView ID="gvPaises" runat="server" Width="581px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvPaises_SelectedIndexChanged">
        
        </asp:GridView>
       
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        
       
    </div>

</asp:Content>
