<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Calculadora4.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Proyecto Programacion II UH</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
        }
        .set {
            margin-left:350px;
            margin-right:350px;
            padding:30px;
        }
        .auto-style3 {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Calculadora Proyecto - Programacion II / UH</strong>
            <br />
        </div>
        <div class="container m-4 p-4">
                <center class="set" style="background-color:#D6DBDF;">
                    <asp:TextBox ID="CajaTexto" runat="server" Height="41px" Width="329px"></asp:TextBox>
                    <br />
                    <asp:Label ID="ErrorLabel1" runat="server" Text="-"></asp:Label>
                    <br />
                    <strong>
                    <asp:Button ID="btnRaiz" runat="server" CssClass="auto-style3" Height="46px" Text="²√" Width="60px" OnClick="btnRaiz_Click" />
&nbsp;
                    <asp:Button ID="btnLimpiarPantalla" runat="server" CssClass="auto-style3" Height="46px" Text="C" Width="60px" OnClick="btnLimpiarPantalla_Click" BackColor="#FF5050" />
&nbsp;
                    <asp:Button ID="btnBorrar" runat="server" CssClass="auto-style3" Height="46px" Text="&lt;" Width="60px" OnClick="btnBorrar_Click" BackColor="#FF5050" />
&nbsp;
                    <asp:Button ID="btnFactorial" runat="server" CssClass="auto-style3" Height="46px" Text="n!" Width="60px" OnClick="btnFactorial_Click" />
&nbsp;
                    <asp:Button ID="btnDivision" runat="server" CssClass="auto-style3" Height="46px" Text="/" Width="60px" OnClick="btnDivision_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnPotencia2" runat="server" CssClass="auto-style3" Height="46px" Text="x^y" Width="60px" OnClick="btnPotencia2_Click" />
&nbsp;
                    <asp:Button ID="btn7" runat="server" CssClass="auto-style3" Height="46px" Text="7" Width="60px" OnClick="btn7_Click" />
&nbsp;
                    <asp:Button ID="btn8" runat="server" CssClass="auto-style3" Height="46px" Text="8" Width="60px" OnClick="btn8_Click" />
&nbsp;
                    <asp:Button ID="btn9" runat="server" CssClass="auto-style3" Height="46px" Text="9" Width="60px" OnClick="btn9_Click" />
&nbsp;
                    <asp:Button ID="btnMultiplicacion" runat="server" CssClass="auto-style3" Height="46px" Text="*" Width="60px" OnClick="btnMultiplicacion_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnBase10" runat="server" CssClass="auto-style3" Height="46px" Text="10^x" Width="60px" OnClick="btnBase10_Click" />
&nbsp;
                    <asp:Button ID="btn4" runat="server" CssClass="auto-style3" Height="46px" Text="4" Width="60px" OnClick="btn4_Click" />
&nbsp;
                    <asp:Button ID="btn5" runat="server" CssClass="auto-style3" Height="46px" Text="5" Width="60px" OnClick="btn5_Click" />
&nbsp;
                    <asp:Button ID="btn6" runat="server" CssClass="auto-style3" Height="46px" Text="6" Width="60px" OnClick="btn6_Click" />
&nbsp;
                    <asp:Button ID="btnResta" runat="server" CssClass="auto-style3" Height="46px" Text="-" Width="60px" OnClick="btnResta_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnLog" runat="server" CssClass="auto-style3" Height="46px" Text="Log" Width="60px" OnClick="btnLog_Click" />
&nbsp;
                    <asp:Button ID="btn1" runat="server" CssClass="auto-style3" Height="46px" Text="1" Width="60px" OnClick="btn1_Click" />
&nbsp;
                    <asp:Button ID="btn2" runat="server" CssClass="auto-style3" Height="46px" Text="2" Width="60px" OnClick="btn2_Click" />
&nbsp;
                    <asp:Button ID="btn3" runat="server" CssClass="auto-style3" Height="46px" Text="3" Width="60px" OnClick="btn3_Click" />
&nbsp;
                    <asp:Button ID="btnSuma" runat="server" CssClass="auto-style3" Height="46px" Text="+" Width="60px" OnClick="btnSuma_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnPotencia" runat="server" CssClass="auto-style3" Height="46px" Text="x²" Width="60px" OnClick="btnPotencia_Click" />
&nbsp;
                    <asp:Button ID="Button23" runat="server" CssClass="auto-style3" Height="46px" Text="+/-" Width="60px" OnClick="Button23_Click" />
&nbsp;
                    <asp:Button ID="btn0" runat="server" CssClass="auto-style3" Height="46px" Text="0" Width="60px" OnClick="Button24_Click" />
&nbsp;
                    <asp:Button ID="Button25" runat="server" CssClass="auto-style3" Height="46px" Text="." Width="60px" OnClick="Button25_Click" />
&nbsp;
                    <asp:Button ID="btnIgual" runat="server" CssClass="auto-style3" Height="46px" Text="=" Width="60px" OnClick="btnIgual_Click" BackColor="#00CC00" />
                    </strong>
                </center>
            </div>
    </form>
</body>
</html>
