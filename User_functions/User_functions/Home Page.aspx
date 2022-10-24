<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="User_functions.Home_Page" %>


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
               margin: auto;
        }
        body {
             background-image: url("lol.jpg");
        }
        #form1{
            
            width:30%;
            background-color:white;
          
            margin : auto;
             box-shadow: 10px 10px 8px #888888;
             padding: 10px;
             display: flex;
             align-items: center;
             justify-content: center;
            height: 552px;
        }
        .contain{
            width :72% ;
         margin:0 auto; 
        }
        
    </style>
</head>
<body >
    <div class="container" style="width: 100%; height: 652px;">


        <form id="form1" runat="server">


        <div class="contain">
                           <asp:Button ID="View" runat="server" Text="View Data" style ="align-content :center" CssClass="auto-style1" OnClick="Button1_Click1"/>
                           <asp:Button ID="Update" runat="server" Text="Update My Data" style ="align-content :center" CssClass="auto-style1" OnClick="Button2_Click1"/>
                           <asp:Button ID="Button3" runat="server" Text="Update Blood Pressure" style ="align-content :center" CssClass="auto-style1" OnClick="update_blood"/>
              
            <asp:Button ID="Button2" runat="server" Text="Diet" style ="align-content :center" CssClass="auto-style1" OnClick="DIET"/>

            <asp:Button ID="Button1" runat="server" Text="Graph" style ="align-content :center" CssClass="auto-style1" OnClick="Graph" OnLoad="Page_Load"/>
            <asp:Button ID="Button4" runat="server" Text="log out " style ="align-content :center" CssClass="auto-style1" OnClick="Logout"/>


       </div>
    
      </form>

        </div>
    </body>
</html>
