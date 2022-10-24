<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="User_functions.start" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml%22%3E">
<head runat="server">
    <title></title>
    <style type="text/css">

       
       
     
         .auto-style1 {
             margin-bottom:10px;
            width:300px;   
            color: white;
            background-color: black;
            padding: 30px 35px;
            text-align: center;
            font-size: 16px;
          
        }
        body {
             background-image: url("lol.jpg");
        }
        #form1{
            
            width:50%;
            background-color:white;
          
            margin : auto;
            box-shadow: 10px 10px 8px #888888;
            padding: 10px;
           
        }
        .contain{
        width:42%;
     
          margin :0 auto;
        
        }
        
    </style>
</head>
<body >
    <div class="container" style="width: 100%; height: 652px;">


        <form id="form1" runat="server">


        <div class="contain">
              <asp:Button ID="reg" runat="server" Text="registration" style ="align-content :center" CssClass="auto-style1" OnClick="Button2_Click1"/>
              <asp:Button ID="login" runat="server" Text="Log in" style ="align-content :center" CssClass="auto-style1" OnClick="Button1_Click1"/>
                          
       </div>
    
      </form>

        </div>
    </body>
</html>
