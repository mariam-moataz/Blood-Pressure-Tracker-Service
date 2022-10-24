<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Graph3.aspx.cs" Inherits="User_functions.Graph3" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>  

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {            height: 100%;
            width: 100%;
        }
        img[title$='Chart1']
{
    height:auto !important;
    width:auto !important;
    min-width:0 !important;
}
        .auto-style1{
          
            position:relative;
            left: 228px;
            color: white;
            background-color: black;
            padding: 15px 32px;
            text-align: center;
         
            font-size: 16px;
            top: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Chart ID="Chart1" runat="server" Height="507px" OnLoad="Chart1_Load" Width="626px" >
            <series>
                <asp:Series ChartArea="ChartArea1" Name="boold Pressure">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Button ID="v_Button1" runat="server" Text="Back" CssClass="auto-style1" OnClick="v_Button1_Click"/>

        
    </form>
</body>
</html>
