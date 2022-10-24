<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_blood.aspx.cs" Inherits="User_functions.Update_blood" %>
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
            left: 236px;
            top: 3px;
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

               width:40%;
            background-color:white;
             margin: auto;

             box-shadow: 10px 10px 8px #888888;
             padding: 10px;
        }
    </style>
</head>
<body  >
    <div class="container" style="width: 100%">


        <form id="form1" runat="server" style ="width:40%">


        <div  >
                 <div class ="cell" >
                    <asp:TextBox class="TextBox1" runat="server" ID="u_t5"></asp:TextBox>
                    <label class="orderName">blood pressure </label>
                </div>
                
            <asp:Button ID="Button3" runat="server" Text="Update" CssClass="auto-style1" OnClick="Button3_Click"/>

       </div>
   
      </form>


    </body>
</html>