<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="User_functions.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml%22%3E">
<head runat="server">
    <title></title>
    <style type="text/css">

        .orderName{


            font-size: 25px;

            font-family: Times, "Times New Roman", serif;

       }
        .cell {
            margin :10px;
 padding:20px;
       }
        .TextBox1{
  float:right;
       }
        .auto-style1 {

            border-style: none;
            border-color: inherit;
            border-width: medium;
            position:relative;
       
            color: white;
            background-color: black;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
        }
        body {
             background-image: url("lol.jpg");
        }
        #form1{

            
            background-color:white;
             margin: auto;

             box-shadow: 10px 10px 8px #888888;
             padding: 10px;
        }
    </style>
</head>
<body  >
    <div class="container" style="width: 100%; height: 529px;">


        <form id="form1" runat="server" style ="width:39%; height: 344px;">


        <div  >
                <div class ="cell" >
                  <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="8" Columns="40" Height="224px" Width="414px"></asp:TextBox>
                   <asp:Button ID="v_Button1" runat="server" Text="Back" CssClass="auto-style1" OnClick="v_Button1_Click"/>

                </div>

       </div>
   
      </form>


    </body>
</html>